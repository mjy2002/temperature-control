#include "mbed.h"
#include "sMotor.h"
#include "ssd1306.h"
#include "mcp_can.h" 

Serial pc(SERIAL_TX, SERIAL_RX);
//DigitalOut myled(LED1);
AnalogIn adc (A0);
AnalogIn pot (A1);
Ticker Tadc, Tserie, Tap_cierre, Tcan;
PwmOut servo(D9);
sMotor motor(D3, D4, D5, D6);
SSD1306 display (I2C_SDA, I2C_SCL, 0x78); 
CAN_FRAME mymsg;

unsigned char trama_can[8], trama_rx [4], trama_temp[4], trama_servo[4], trama_smotor[4], irx, tiempo_temperatura=10, pos_servo_remota, temp_remota_ent, temp_remota_dec, vel_smotor_remota_ent, vel_smotor_remota_dec, estado_ap_cierre=0;
int i=0, posicion_servo_pot=0, tiempo_ap_cierre=0, vel_ap_cierre=0;//Servo movido por potenciometro
float temp, resval, step_speed, vel_smotor_rpm, aux_t_ap_cierre=0, aux_t_temp=0;
int numstep=20, velocidad_smotor, posicion_servo;        //Número de pasos que dará el motor en el sentido de giro que indique dir
bool can_funciona=0, enable_monitor_can=0, trama_valida=0, enable_read_temp=1, enable_servo_pot=0, enable_apertura_cierre=0, dir=0, leer_velocidad_smotor=0, enable_smotor_pot=0, frenar_smotor=1, mostrar_estado_sistema = 1;

void envia_can()
{
	trama_can[0] = (unsigned char)temp; //parte entera de temperatura
	trama_can[1] = (unsigned char)((temp - (float)trama_can[0])*100.0); //parte decimal de temperatura. Se pone el .0 en 100.0 para que lo tome como float
	trama_can[2] = (unsigned char)posicion_servo;
	trama_can[3] = (unsigned char)vel_smotor_rpm;	//Velocidad entera del Step Motor
	trama_can[4] = (unsigned char)((vel_smotor_rpm-(float)trama_can[3])*100.0);	//Velocidad decimal del Step Motor
	trama_can[5] = 0x1;
	trama_can[6] = 0xC;
	trama_can[7] = 0x1;
	CAN.sendMsgBuf(0x25,0,8,trama_can);
}

void leer_serie()   //Lee byte por puerto serie. Entra cada vez que recibe un byte
{    
	trama_rx[irx++] = pc.getc();

	if (irx==4)		//Recibida trama completa? (4 bytes)
	{
		if(trama_rx[3]==0xE0) {trama_valida=true;} //...Sí. Último byte = 0xE0? ...Sí. Trama es válida
		irx=0; trama_rx[3]=0;				//Reinicia valores
	}
}

void enviar_serie (unsigned char trama0, unsigned char trama1, unsigned char trama2, unsigned char trama3)
{
	pc.putc(trama0);
	pc.putc(trama1);
	pc.putc(trama2);
	pc.putc(trama3);
}

void activa_remota()
{
	unsigned char buf[8];
	buf[0] = 0;		//Activar monitorización de placa remota
	buf[1] = 0;				//Mensaje vacio
	buf[2] = 0;
	buf[3] = 0;
	buf[4] = 0;
	buf[5] = 0;
	buf[6] = 0;
	buf[7] = 0;
	CAN.sendMsgBuf(0x11,0,8,buf);	
}

void actualiza_display()
{
	display.locate(1,5);    //Fila 1 en el centro
	display.printf("%6.2f", temp);
	display.locate(2,5);    //Fila 2 en el centro
	display.printf("%6.2d", posicion_servo);
	vel_smotor_rpm= 60000000/(step_speed*4096);   //Pasa step speed a rpm
	display.locate(3,5);    //Fila 3 en el centro
	display.printf("%6.2f", vel_smotor_rpm);
	if (can_funciona){
		display.locate(4,5);
		display.printf("CAN Activado");
	}
	else display.printf("CAN Desactivado");
	display.redraw();
}
void periodic_adc()
{
	if (enable_read_temp){
		if (aux_t_temp==tiempo_temperatura) {	
			temp = (adc.read()*330); //(float)(adc.read_u16()*10)/4096;  
			aux_t_temp=0;
			trama_temp[0]= 0x30;
			trama_temp[1]= (unsigned char)temp; // solo la parte entera de la temperatura
			trama_temp[2]= (unsigned char)((temp-(float)trama_temp[1])*100.0); //la parte decimal, solo dos decimales.
			trama_temp[3]= 0xE0;
			enviar_serie(trama_temp[0], trama_temp[1], trama_temp[2], trama_temp[3]);
			if (enable_monitor_can) envia_can();
		}
		else aux_t_temp++;
	}
}

void poner_servo()
{
	servo.pulsewidth_us (700 + posicion_servo*2000/180.0);
	trama_servo[0] = 0x20;
	trama_servo[1] = (unsigned char)posicion_servo;
	trama_servo[2] = 0xFF;
	trama_servo[3] = 0E0;
	enviar_serie(trama_servo[0], trama_servo[1], trama_servo[2], trama_servo[3]);
	if (enable_monitor_can) envia_can();
}

void apertura_cierre()
{
	if (enable_apertura_cierre)
	{
		switch (estado_ap_cierre){	//0 = Abriendo, 1 = Esperando, 2 = Cerrando
			case 0:										//Abriendo puerta
				if (posicion_servo==90) estado_ap_cierre=1;
				else posicion_servo += vel_ap_cierre;	
				if (posicion_servo>90) posicion_servo=90;	//Evita que se pase abriendo
				break;
			case 1:										//Esperando
				if (aux_t_ap_cierre==tiempo_ap_cierre){
					aux_t_ap_cierre=0;
					estado_ap_cierre=2;
				}
				else aux_t_ap_cierre++;
				break;
			case 2:										//Cerrando
				if (posicion_servo==0){
					enable_apertura_cierre=false;
				}
				else posicion_servo -= vel_ap_cierre;
				if (posicion_servo<0) posicion_servo=0;		//Evita que se pase cerrando
				break;
		}
		
		if (estado_ap_cierre!=1){
			servo.pulsewidth_us (700 + posicion_servo*2000/180.0);
			trama_servo[0] = 0x20;
			trama_servo[1] = (unsigned char)posicion_servo;
			trama_servo[2] = 0xFF;
			trama_servo[3] = 0E0;
			enviar_serie(trama_servo[0], trama_servo[1], trama_servo[2], trama_servo[3]);
		}
	}
}

void control_servo_pot ()
{
	resval = pot.read();
	if (resval*90 <0) posicion_servo = 0;
	else if (resval*90 >90) posicion_servo = 90;
	else posicion_servo = resval*90;
	servo.pulsewidth_us (700 + posicion_servo*2000/180.0);
	trama_servo[0] = 0x20;
	trama_servo[1] = (unsigned char)posicion_servo;
	trama_servo[2] = 0xFF;
	trama_servo[3] = 0E0;
	enviar_serie(trama_servo[0], trama_servo[1], trama_servo[2], trama_servo[3]);
	if (enable_monitor_can) envia_can();
}

void info_smotor()
{
	if (velocidad_smotor<1) velocidad_smotor=1;
	else if (velocidad_smotor>9) velocidad_smotor=9;
	step_speed = 900+velocidad_smotor*260;
	vel_smotor_rpm= 60000000/(step_speed*4096);   //Pasa step speed a rpm
	trama_smotor[0] = 0x40;
	trama_smotor[1] = vel_smotor_rpm;
	trama_smotor[2] = 0xFF;
	trama_smotor[3] = 0E0;
	enviar_serie(trama_smotor[0], trama_smotor[1], trama_smotor[2], trama_smotor[3]);
	if (enable_monitor_can) envia_can();
}

int main()
{
	servo.period_ms(10);
	
	if (CAN.begin(CAN_500KBPS)==CAN_OK) can_funciona=1;	//Señala de forma visual que el CAN está activado
	else can_funciona=0;
	
	display.speed(SSD1306::Medium);	//Configura display
	display.init();
	display.cls();
		
	Tadc.attach(&periodic_adc,0.01);	//Interrupcion temperatura
	pc.attach(&leer_serie,Serial::RxIrq);	//Interrupcion serie
	Tap_cierre.attach(&apertura_cierre, 0.1);	//Interrupcion apertura cierre
	//Tcan.attach(&envia_can, 0.1);
	
					
	posicion_servo = 0;	//Inicializa servo en 0º
	poner_servo();
	display.cls();      //Limpia pantalla
	display.redraw();
	
	while(1) {		
		if (Flag_int_CAN) {
			Flag_int_CAN = 0;
			CAN.receiveFrame(mymsg);
			if (mymsg.id == 0x22) enable_monitor_can = 1;
			else if (mymsg.id == 0x15)
			{
				if (i==0){
					i++;
					temp_remota_ent = mymsg.data.byte[0];
					temp_remota_dec = mymsg.data.byte[1];
					enviar_serie(0x31, temp_remota_ent, temp_remota_dec, 0xE0);	//Envia temperatura remota
				}
				else if(i==1){
					i++;
					pos_servo_remota = mymsg.data.byte[2];
					enviar_serie(0x21, pos_servo_remota, 0xFF, 0xE0);	//Envia servo remota
				}
				else if(i==2){
					i=0;
					vel_smotor_remota_ent = mymsg.data.byte[3];
					vel_smotor_remota_dec = mymsg.data.byte[4];
					enviar_serie(0x41, vel_smotor_remota_ent, vel_smotor_remota_dec, 0xE0);	//Envia velocidad de motor remota
				}
			}
		}
			
		if (frenar_smotor!=1) motor.step(numstep, dir, step_speed);
		if (mostrar_estado_sistema) actualiza_display();
		if (enable_servo_pot) control_servo_pot();
				
		if (trama_valida)
		{
			trama_valida=0;
			switch (trama_rx[0])
			{
				case 'S':
					enable_apertura_cierre = 0;
					enable_servo_pot=0;
					posicion_servo = trama_rx[1];
					poner_servo();
					break;
				case 'A':
					enable_servo_pot = 0;
					estado_ap_cierre = 0;
					tiempo_ap_cierre = trama_rx[1] * 10;
					vel_ap_cierre = trama_rx[2];
					enable_apertura_cierre=1;
					break;
				case 'P':
					enable_apertura_cierre=0;
					enable_servo_pot=1;
					break;
				case 'T':
					tiempo_temperatura = trama_rx[1];
					enable_read_temp=1;
					break;
				case 'M':
					frenar_smotor=0;
					velocidad_smotor=trama_rx[1];
					info_smotor();
					break;
				case 'D':
					dir=0;
					break;
				case 'I':
					dir=1;
					break;
				case 'X':
					mostrar_estado_sistema=1;
					break;
				case 'C':
					enable_apertura_cierre=0;	//Desactiva apertura cierre
					estado_ap_cierre=0;		//Pone apertura cierre en modo abriendo para la próxima vez
					mostrar_estado_sistema=0;   //Desactiva pantalla
					enable_read_temp=0;     //Desactiva lectura de temperatura
					enable_servo_pot=0; //Desactiva control del servo
					frenar_smotor=1;	//Frena Step Motor
					display.cls();      //Limpia pantalla
					display.redraw();
					break;
				case 'R':
					activa_remota();
					break;
			}
		}
	}
}
