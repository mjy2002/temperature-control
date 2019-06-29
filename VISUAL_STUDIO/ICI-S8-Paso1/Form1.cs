using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICI_S8_Paso1
{
    public partial class Form1 : Form
    {
        double temperatura_local, temperatura_remota, pos_servo_local, pos_servo_remoto, vel_motor_local, vel_motor_remoto;
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            temperatura_local = 0;  //inicializamos
            temperatura_remota = 0;
            pos_servo_local = 0;
            vel_motor_local = 0;
            pos_servo_remoto = 0;
            vel_motor_remoto = 0;
            serialPort1.DiscardInBuffer(); // Descarto todo lo que haya en buffer del puerto serie
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*while (serialPort1.BytesToRead > 0)
            {
                byte[] packet = new byte[4];
                byte c = (byte)(serialPort1.ReadByte());
                packet[0] = packet[1];
                packet[1] = packet[2];
                packet[2] = packet[3];
                packet[3] = c;            //Desplaza 1 byte a la izquierda


               if (c != 0xE0) {        //Si c no es final de trama (0xE0), vuelve al principio del bucle
            */
            byte[] packet = new byte[4];
            serialPort1.Read(packet, 0, 4);

            switch (packet[0])
                {
                case 0x20:
                    string cadena;
                    pos_servo_local = packet[1];
                    cadena = Convert.ToString(pos_servo_local) + "º";
                    TBServoLocal.Invoke((MethodInvoker)delegate { TBServoLocal.Text = cadena; });
                    //KPosServoLocal.Invoke((MethodInvoker)delegate { KPosServoLocal.Value = (float)pos_servo_local; });
                    break;

                case 0x30:
                    temperatura_local = packet[1] + packet[2] / 100.0;
                    DMTempLocal.Invoke((MethodInvoker)delegate { DMTempLocal.Value = temperatura_local; });
                    break;

                case 0x40:
                    vel_motor_local = packet[1];
                    AMVelMotLocal.Invoke((MethodInvoker)delegate { AMVelMotLocal.Value = vel_motor_local; });
                    break;

                case 0x21:
                    pos_servo_remoto = packet[1];
                    cadena = Convert.ToString(pos_servo_remoto) + "º";
                    TBServoRemoto.Invoke((MethodInvoker)delegate { TBServoRemoto.Text = cadena; });
                    break;

                case 0x31:
                    temperatura_remota = packet[1] + packet[2] / 100.0;
                    DMTempRemota.Invoke((MethodInvoker)delegate { DMTempRemota.Value = temperatura_remota; });
                    break;

                case 0x41:
                    vel_motor_remoto = packet[1] + packet[2] / 100.0;
                    AMVelMotRemoto.Invoke((MethodInvoker)delegate { AMVelMotRemoto.Value = vel_motor_remoto; });
                    break;

                }
            //}

            serialPort1.DiscardInBuffer(); // Descarto todo lo que haya en buffer del puerto serie
        }

        private void KVelMotorLocal_KnobChangeValue(object sender, LBSoft.IndustrialCtrls.Knobs.LBKnobEventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x4D;
                packet[1] = (byte)KVelMotorLocal.Value;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTActivarDisplay_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x58;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTCancelarTodo_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x43;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTMonitorRemoto_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x52;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void KPosServoLocal_KnobChangeValue(object sender, LBSoft.IndustrialCtrls.Knobs.LBKnobEventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x53;
                packet[1] = (byte)KPosServoLocal.Value;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTTiempoLectura_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x54;
                packet[1] = Convert.ToByte(TBTiempoTemperatura.Text);
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTMotorIzq_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x49;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTMotorDer_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x44;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTControlPot_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x50;
                packet[1] = (byte)0xFF;
                packet[2] = (byte)0xFF;
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }

        private void BTAperturaCierre_Click(object sender, EventArgs e)
        {
            byte[] packet = new byte[4];
            if (serialPort1.IsOpen)
            {
                packet[0] = (byte)0x41;
                packet[1] = Convert.ToByte(TBTiempoEsperaApC.Text);
                packet[2] = Convert.ToByte(TBVelApertCierre.Text);
                packet[3] = (byte)0xE0;
                serialPort1.Write(packet, 0, 4);
            }
        }
    }
}
