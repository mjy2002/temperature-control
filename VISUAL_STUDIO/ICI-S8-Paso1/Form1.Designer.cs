namespace ICI_S8_Paso1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTControlPot = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BTMonitorRemoto = new System.Windows.Forms.Button();
            this.DMTempLocal = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.labelTempLocal = new System.Windows.Forms.Label();
            this.labelVelMotorLocal = new System.Windows.Forms.Label();
            this.AMVelMotLocal = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.KVelMotorLocal = new LBSoft.IndustrialCtrls.Knobs.LBKnob();
            this.BTTiempoLectura = new System.Windows.Forms.Button();
            this.BTAperturaCierre = new System.Windows.Forms.Button();
            this.BTMotorIzq = new System.Windows.Forms.Button();
            this.BTMotorDer = new System.Windows.Forms.Button();
            this.KPosServoLocal = new LBSoft.IndustrialCtrls.Knobs.LBKnob();
            this.labelPosServoLocal = new System.Windows.Forms.Label();
            this.TBTiempoEsperaApC = new System.Windows.Forms.TextBox();
            this.labelTiempoEsperaServo = new System.Windows.Forms.Label();
            this.labelVelocidadServo = new System.Windows.Forms.Label();
            this.TBVelApertCierre = new System.Windows.Forms.TextBox();
            this.DMTempRemota = new LBSoft.IndustrialCtrls.Meters.LBDigitalMeter();
            this.labelVelMotorRemoto = new System.Windows.Forms.Label();
            this.AMVelMotRemoto = new LBSoft.IndustrialCtrls.Meters.LBAnalogMeter();
            this.labelTempRemota = new System.Windows.Forms.Label();
            this.labelPosServoRemoto = new System.Windows.Forms.Label();
            this.BTActivarDisplay = new System.Windows.Forms.Button();
            this.BTCancelarTodo = new System.Windows.Forms.Button();
            this.TBServoLocal = new System.Windows.Forms.TextBox();
            this.TBServoRemoto = new System.Windows.Forms.TextBox();
            this.TBTiempoTemperatura = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTControlPot
            // 
            this.BTControlPot.Location = new System.Drawing.Point(179, 262);
            this.BTControlPot.Margin = new System.Windows.Forms.Padding(2);
            this.BTControlPot.Name = "BTControlPot";
            this.BTControlPot.Size = new System.Drawing.Size(201, 31);
            this.BTControlPot.TabIndex = 0;
            this.BTControlPot.Text = "Activar control por potenciómetro";
            this.BTControlPot.UseVisualStyleBackColor = true;
            this.BTControlPot.Click += new System.EventHandler(this.BTControlPot_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReceivedBytesThreshold = 4;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // BTMonitorRemoto
            // 
            this.BTMonitorRemoto.Location = new System.Drawing.Point(417, 27);
            this.BTMonitorRemoto.Margin = new System.Windows.Forms.Padding(2);
            this.BTMonitorRemoto.Name = "BTMonitorRemoto";
            this.BTMonitorRemoto.Size = new System.Drawing.Size(304, 29);
            this.BTMonitorRemoto.TabIndex = 1;
            this.BTMonitorRemoto.Text = "Monitorizar placa remota";
            this.BTMonitorRemoto.UseVisualStyleBackColor = true;
            this.BTMonitorRemoto.Click += new System.EventHandler(this.BTMonitorRemoto_Click);
            // 
            // DMTempLocal
            // 
            this.DMTempLocal.BackColor = System.Drawing.Color.Transparent;
            this.DMTempLocal.ForeColor = System.Drawing.Color.Black;
            this.DMTempLocal.Format = "00.00";
            this.DMTempLocal.Location = new System.Drawing.Point(21, 54);
            this.DMTempLocal.Name = "DMTempLocal";
            this.DMTempLocal.Renderer = null;
            this.DMTempLocal.Signed = false;
            this.DMTempLocal.Size = new System.Drawing.Size(127, 46);
            this.DMTempLocal.TabIndex = 3;
            this.DMTempLocal.Value = 0D;
            // 
            // labelTempLocal
            // 
            this.labelTempLocal.AutoSize = true;
            this.labelTempLocal.Location = new System.Drawing.Point(30, 27);
            this.labelTempLocal.Name = "labelTempLocal";
            this.labelTempLocal.Size = new System.Drawing.Size(96, 13);
            this.labelTempLocal.TabIndex = 5;
            this.labelTempLocal.Text = "Temperatura Local";
            // 
            // labelVelMotorLocal
            // 
            this.labelVelMotorLocal.AutoSize = true;
            this.labelVelMotorLocal.Location = new System.Drawing.Point(176, 27);
            this.labelVelMotorLocal.Name = "labelVelMotorLocal";
            this.labelVelMotorLocal.Size = new System.Drawing.Size(113, 13);
            this.labelVelMotorLocal.TabIndex = 6;
            this.labelVelMotorLocal.Text = "Velocidad Motor Local";
            // 
            // AMVelMotLocal
            // 
            this.AMVelMotLocal.BackColor = System.Drawing.Color.Transparent;
            this.AMVelMotLocal.BodyColor = System.Drawing.Color.DodgerBlue;
            this.AMVelMotLocal.Location = new System.Drawing.Point(162, 54);
            this.AMVelMotLocal.MaxValue = 15D;
            this.AMVelMotLocal.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.AMVelMotLocal.MinValue = 0D;
            this.AMVelMotLocal.Name = "AMVelMotLocal";
            this.AMVelMotLocal.NeedleColor = System.Drawing.Color.Yellow;
            this.AMVelMotLocal.Renderer = null;
            this.AMVelMotLocal.ScaleColor = System.Drawing.Color.White;
            this.AMVelMotLocal.ScaleDivisions = 15;
            this.AMVelMotLocal.ScaleSubDivisions = 5;
            this.AMVelMotLocal.Size = new System.Drawing.Size(150, 150);
            this.AMVelMotLocal.TabIndex = 7;
            this.AMVelMotLocal.Value = 0D;
            this.AMVelMotLocal.ViewGlass = false;
            // 
            // KVelMotorLocal
            // 
            this.KVelMotorLocal.BackColor = System.Drawing.Color.Transparent;
            this.KVelMotorLocal.DrawRatio = 0.31F;
            this.KVelMotorLocal.IndicatorColor = System.Drawing.Color.Brown;
            this.KVelMotorLocal.IndicatorOffset = 10F;
            this.KVelMotorLocal.KnobCenter = ((System.Drawing.PointF)(resources.GetObject("KVelMotorLocal.KnobCenter")));
            this.KVelMotorLocal.KnobColor = System.Drawing.Color.Orange;
            this.KVelMotorLocal.KnobRect = ((System.Drawing.RectangleF)(resources.GetObject("KVelMotorLocal.KnobRect")));
            this.KVelMotorLocal.Location = new System.Drawing.Point(322, 142);
            this.KVelMotorLocal.MaxValue = 9F;
            this.KVelMotorLocal.MinValue = 1F;
            this.KVelMotorLocal.Name = "KVelMotorLocal";
            this.KVelMotorLocal.Renderer = null;
            this.KVelMotorLocal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KVelMotorLocal.ScaleColor = System.Drawing.Color.Gray;
            this.KVelMotorLocal.Size = new System.Drawing.Size(68, 62);
            this.KVelMotorLocal.StepValue = 1F;
            this.KVelMotorLocal.Style = LBSoft.IndustrialCtrls.Knobs.LBKnob.KnobStyle.Circular;
            this.KVelMotorLocal.TabIndex = 8;
            this.KVelMotorLocal.Value = 0F;
            this.KVelMotorLocal.KnobChangeValue += new LBSoft.IndustrialCtrls.Knobs.KnobChangeValue(this.KVelMotorLocal_KnobChangeValue);
            // 
            // BTTiempoLectura
            // 
            this.BTTiempoLectura.Location = new System.Drawing.Point(21, 115);
            this.BTTiempoLectura.Margin = new System.Windows.Forms.Padding(2);
            this.BTTiempoLectura.Name = "BTTiempoLectura";
            this.BTTiempoLectura.Size = new System.Drawing.Size(127, 31);
            this.BTTiempoLectura.TabIndex = 9;
            this.BTTiempoLectura.Text = "Tiempo de lectura";
            this.BTTiempoLectura.UseVisualStyleBackColor = true;
            this.BTTiempoLectura.Click += new System.EventHandler(this.BTTiempoLectura_Click);
            // 
            // BTAperturaCierre
            // 
            this.BTAperturaCierre.Location = new System.Drawing.Point(179, 297);
            this.BTAperturaCierre.Margin = new System.Windows.Forms.Padding(2);
            this.BTAperturaCierre.Name = "BTAperturaCierre";
            this.BTAperturaCierre.Size = new System.Drawing.Size(201, 31);
            this.BTAperturaCierre.TabIndex = 10;
            this.BTAperturaCierre.Text = "Apertura y cierre";
            this.BTAperturaCierre.UseVisualStyleBackColor = true;
            this.BTAperturaCierre.Click += new System.EventHandler(this.BTAperturaCierre_Click);
            // 
            // BTMotorIzq
            // 
            this.BTMotorIzq.Location = new System.Drawing.Point(179, 211);
            this.BTMotorIzq.Margin = new System.Windows.Forms.Padding(2);
            this.BTMotorIzq.Name = "BTMotorIzq";
            this.BTMotorIzq.Size = new System.Drawing.Size(93, 31);
            this.BTMotorIzq.TabIndex = 11;
            this.BTMotorIzq.Text = "Izquierda";
            this.BTMotorIzq.UseVisualStyleBackColor = true;
            this.BTMotorIzq.Click += new System.EventHandler(this.BTMotorIzq_Click);
            // 
            // BTMotorDer
            // 
            this.BTMotorDer.Location = new System.Drawing.Point(285, 211);
            this.BTMotorDer.Margin = new System.Windows.Forms.Padding(2);
            this.BTMotorDer.Name = "BTMotorDer";
            this.BTMotorDer.Size = new System.Drawing.Size(95, 31);
            this.BTMotorDer.TabIndex = 12;
            this.BTMotorDer.Text = "Derecha";
            this.BTMotorDer.UseVisualStyleBackColor = true;
            this.BTMotorDer.Click += new System.EventHandler(this.BTMotorDer_Click);
            // 
            // KPosServoLocal
            // 
            this.KPosServoLocal.BackColor = System.Drawing.Color.Transparent;
            this.KPosServoLocal.DrawRatio = 0.31F;
            this.KPosServoLocal.IndicatorColor = System.Drawing.Color.Brown;
            this.KPosServoLocal.IndicatorOffset = 10F;
            this.KPosServoLocal.KnobCenter = ((System.Drawing.PointF)(resources.GetObject("KPosServoLocal.KnobCenter")));
            this.KPosServoLocal.KnobColor = System.Drawing.Color.Orange;
            this.KPosServoLocal.KnobRect = ((System.Drawing.RectangleF)(resources.GetObject("KPosServoLocal.KnobRect")));
            this.KPosServoLocal.Location = new System.Drawing.Point(21, 277);
            this.KPosServoLocal.MaxValue = 90F;
            this.KPosServoLocal.MinValue = 0F;
            this.KPosServoLocal.Name = "KPosServoLocal";
            this.KPosServoLocal.Renderer = null;
            this.KPosServoLocal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.KPosServoLocal.ScaleColor = System.Drawing.Color.Gray;
            this.KPosServoLocal.Size = new System.Drawing.Size(68, 62);
            this.KPosServoLocal.StepValue = 1F;
            this.KPosServoLocal.Style = LBSoft.IndustrialCtrls.Knobs.LBKnob.KnobStyle.Circular;
            this.KPosServoLocal.TabIndex = 13;
            this.KPosServoLocal.Value = 0F;
            this.KPosServoLocal.KnobChangeValue += new LBSoft.IndustrialCtrls.Knobs.KnobChangeValue(this.KPosServoLocal_KnobChangeValue);
            // 
            // labelPosServoLocal
            // 
            this.labelPosServoLocal.AutoSize = true;
            this.labelPosServoLocal.Location = new System.Drawing.Point(18, 252);
            this.labelPosServoLocal.Name = "labelPosServoLocal";
            this.labelPosServoLocal.Size = new System.Drawing.Size(107, 13);
            this.labelPosServoLocal.TabIndex = 14;
            this.labelPosServoLocal.Text = "Posición Servo Local";
            // 
            // TBTiempoEsperaApC
            // 
            this.TBTiempoEsperaApC.Font = new System.Drawing.Font("Arial", 12F);
            this.TBTiempoEsperaApC.Location = new System.Drawing.Point(179, 363);
            this.TBTiempoEsperaApC.Margin = new System.Windows.Forms.Padding(2);
            this.TBTiempoEsperaApC.Name = "TBTiempoEsperaApC";
            this.TBTiempoEsperaApC.Size = new System.Drawing.Size(61, 26);
            this.TBTiempoEsperaApC.TabIndex = 16;
            this.TBTiempoEsperaApC.Text = "1";
            this.TBTiempoEsperaApC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTiempoEsperaServo
            // 
            this.labelTiempoEsperaServo.AutoSize = true;
            this.labelTiempoEsperaServo.Location = new System.Drawing.Point(176, 339);
            this.labelTiempoEsperaServo.Name = "labelTiempoEsperaServo";
            this.labelTiempoEsperaServo.Size = new System.Drawing.Size(88, 13);
            this.labelTiempoEsperaServo.TabIndex = 17;
            this.labelTiempoEsperaServo.Text = "tiempo de espera";
            // 
            // labelVelocidadServo
            // 
            this.labelVelocidadServo.AutoSize = true;
            this.labelVelocidadServo.Location = new System.Drawing.Point(295, 339);
            this.labelVelocidadServo.Name = "labelVelocidadServo";
            this.labelVelocidadServo.Size = new System.Drawing.Size(53, 13);
            this.labelVelocidadServo.TabIndex = 19;
            this.labelVelocidadServo.Text = "velocidad";
            // 
            // TBVelApertCierre
            // 
            this.TBVelApertCierre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBVelApertCierre.Location = new System.Drawing.Point(298, 363);
            this.TBVelApertCierre.Margin = new System.Windows.Forms.Padding(2);
            this.TBVelApertCierre.Name = "TBVelApertCierre";
            this.TBVelApertCierre.Size = new System.Drawing.Size(47, 26);
            this.TBVelApertCierre.TabIndex = 18;
            this.TBVelApertCierre.Text = "10";
            this.TBVelApertCierre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DMTempRemota
            // 
            this.DMTempRemota.BackColor = System.Drawing.Color.Transparent;
            this.DMTempRemota.ForeColor = System.Drawing.Color.Black;
            this.DMTempRemota.Format = "00.00";
            this.DMTempRemota.Location = new System.Drawing.Point(417, 91);
            this.DMTempRemota.Name = "DMTempRemota";
            this.DMTempRemota.Renderer = null;
            this.DMTempRemota.Signed = false;
            this.DMTempRemota.Size = new System.Drawing.Size(127, 46);
            this.DMTempRemota.TabIndex = 20;
            this.DMTempRemota.Value = 0D;
            // 
            // labelVelMotorRemoto
            // 
            this.labelVelMotorRemoto.AutoSize = true;
            this.labelVelMotorRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelMotorRemoto.Location = new System.Drawing.Point(593, 75);
            this.labelVelMotorRemoto.Name = "labelVelMotorRemoto";
            this.labelVelMotorRemoto.Size = new System.Drawing.Size(143, 15);
            this.labelVelMotorRemoto.TabIndex = 22;
            this.labelVelMotorRemoto.Text = "Velocidad Motor Remoto";
            // 
            // AMVelMotRemoto
            // 
            this.AMVelMotRemoto.BackColor = System.Drawing.Color.Transparent;
            this.AMVelMotRemoto.BodyColor = System.Drawing.Color.Firebrick;
            this.AMVelMotRemoto.Location = new System.Drawing.Point(596, 101);
            this.AMVelMotRemoto.MaxValue = 15D;
            this.AMVelMotRemoto.MeterStyle = LBSoft.IndustrialCtrls.Meters.LBAnalogMeter.AnalogMeterStyle.Circular;
            this.AMVelMotRemoto.MinValue = 0D;
            this.AMVelMotRemoto.Name = "AMVelMotRemoto";
            this.AMVelMotRemoto.NeedleColor = System.Drawing.Color.Yellow;
            this.AMVelMotRemoto.Renderer = null;
            this.AMVelMotRemoto.ScaleColor = System.Drawing.Color.White;
            this.AMVelMotRemoto.ScaleDivisions = 15;
            this.AMVelMotRemoto.ScaleSubDivisions = 5;
            this.AMVelMotRemoto.Size = new System.Drawing.Size(150, 150);
            this.AMVelMotRemoto.TabIndex = 23;
            this.AMVelMotRemoto.Value = 0D;
            this.AMVelMotRemoto.ViewGlass = false;
            // 
            // labelTempRemota
            // 
            this.labelTempRemota.AutoSize = true;
            this.labelTempRemota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempRemota.Location = new System.Drawing.Point(414, 73);
            this.labelTempRemota.Name = "labelTempRemota";
            this.labelTempRemota.Size = new System.Drawing.Size(125, 15);
            this.labelTempRemota.TabIndex = 24;
            this.labelTempRemota.Text = "Temperatura Remota";
            // 
            // labelPosServoRemoto
            // 
            this.labelPosServoRemoto.AutoSize = true;
            this.labelPosServoRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosServoRemoto.Location = new System.Drawing.Point(414, 160);
            this.labelPosServoRemoto.Name = "labelPosServoRemoto";
            this.labelPosServoRemoto.Size = new System.Drawing.Size(135, 15);
            this.labelPosServoRemoto.TabIndex = 25;
            this.labelPosServoRemoto.Text = "Posición Servo Remoto";
            // 
            // BTActivarDisplay
            // 
            this.BTActivarDisplay.Location = new System.Drawing.Point(417, 275);
            this.BTActivarDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.BTActivarDisplay.Name = "BTActivarDisplay";
            this.BTActivarDisplay.Size = new System.Drawing.Size(304, 29);
            this.BTActivarDisplay.TabIndex = 26;
            this.BTActivarDisplay.Text = "Mostrar en el Display";
            this.BTActivarDisplay.UseVisualStyleBackColor = true;
            this.BTActivarDisplay.Click += new System.EventHandler(this.BTActivarDisplay_Click);
            // 
            // BTCancelarTodo
            // 
            this.BTCancelarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelarTodo.Location = new System.Drawing.Point(417, 310);
            this.BTCancelarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.BTCancelarTodo.Name = "BTCancelarTodo";
            this.BTCancelarTodo.Size = new System.Drawing.Size(304, 42);
            this.BTCancelarTodo.TabIndex = 27;
            this.BTCancelarTodo.Text = "Cancelar todos los comandos";
            this.BTCancelarTodo.UseVisualStyleBackColor = true;
            this.BTCancelarTodo.Click += new System.EventHandler(this.BTCancelarTodo_Click);
            // 
            // TBServoLocal
            // 
            this.TBServoLocal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBServoLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBServoLocal.Enabled = false;
            this.TBServoLocal.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServoLocal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBServoLocal.Location = new System.Drawing.Point(90, 294);
            this.TBServoLocal.Margin = new System.Windows.Forms.Padding(2);
            this.TBServoLocal.Name = "TBServoLocal";
            this.TBServoLocal.Size = new System.Drawing.Size(72, 31);
            this.TBServoLocal.TabIndex = 28;
            this.TBServoLocal.Text = "0º";
            // 
            // TBServoRemoto
            // 
            this.TBServoRemoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TBServoRemoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBServoRemoto.Enabled = false;
            this.TBServoRemoto.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBServoRemoto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBServoRemoto.Location = new System.Drawing.Point(462, 189);
            this.TBServoRemoto.Margin = new System.Windows.Forms.Padding(2);
            this.TBServoRemoto.Name = "TBServoRemoto";
            this.TBServoRemoto.Size = new System.Drawing.Size(77, 31);
            this.TBServoRemoto.TabIndex = 29;
            this.TBServoRemoto.Text = "0º";
            // 
            // TBTiempoTemperatura
            // 
            this.TBTiempoTemperatura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTiempoTemperatura.Location = new System.Drawing.Point(21, 150);
            this.TBTiempoTemperatura.Margin = new System.Windows.Forms.Padding(2);
            this.TBTiempoTemperatura.Name = "TBTiempoTemperatura";
            this.TBTiempoTemperatura.Size = new System.Drawing.Size(84, 29);
            this.TBTiempoTemperatura.TabIndex = 30;
            this.TBTiempoTemperatura.Text = "10";
            this.TBTiempoTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "x10ms";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(243, 368);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(29, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "seg";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(350, 363);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(40, 26);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "grados/seg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 408);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TBTiempoTemperatura);
            this.Controls.Add(this.TBServoRemoto);
            this.Controls.Add(this.TBServoLocal);
            this.Controls.Add(this.BTCancelarTodo);
            this.Controls.Add(this.BTActivarDisplay);
            this.Controls.Add(this.labelPosServoRemoto);
            this.Controls.Add(this.labelTempRemota);
            this.Controls.Add(this.AMVelMotRemoto);
            this.Controls.Add(this.labelVelMotorRemoto);
            this.Controls.Add(this.DMTempRemota);
            this.Controls.Add(this.labelVelocidadServo);
            this.Controls.Add(this.TBVelApertCierre);
            this.Controls.Add(this.labelTiempoEsperaServo);
            this.Controls.Add(this.TBTiempoEsperaApC);
            this.Controls.Add(this.labelPosServoLocal);
            this.Controls.Add(this.KPosServoLocal);
            this.Controls.Add(this.BTMotorDer);
            this.Controls.Add(this.BTMotorIzq);
            this.Controls.Add(this.BTAperturaCierre);
            this.Controls.Add(this.BTTiempoLectura);
            this.Controls.Add(this.KVelMotorLocal);
            this.Controls.Add(this.AMVelMotLocal);
            this.Controls.Add(this.labelVelMotorLocal);
            this.Controls.Add(this.labelTempLocal);
            this.Controls.Add(this.DMTempLocal);
            this.Controls.Add(this.BTMonitorRemoto);
            this.Controls.Add(this.BTControlPot);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Santiago Fernández Scagliusi - Placa B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTControlPot;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BTMonitorRemoto;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter DMTempLocal;
        private System.Windows.Forms.Label labelTempLocal;
        private System.Windows.Forms.Label labelVelMotorLocal;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter AMVelMotLocal;
        private LBSoft.IndustrialCtrls.Knobs.LBKnob KVelMotorLocal;
        private System.Windows.Forms.Button BTTiempoLectura;
        private System.Windows.Forms.Button BTAperturaCierre;
        private System.Windows.Forms.Button BTMotorIzq;
        private System.Windows.Forms.Button BTMotorDer;
        private LBSoft.IndustrialCtrls.Knobs.LBKnob KPosServoLocal;
        private System.Windows.Forms.Label labelPosServoLocal;
        private System.Windows.Forms.TextBox TBTiempoEsperaApC;
        private System.Windows.Forms.Label labelTiempoEsperaServo;
        private System.Windows.Forms.Label labelVelocidadServo;
        private System.Windows.Forms.TextBox TBVelApertCierre;
        private LBSoft.IndustrialCtrls.Meters.LBDigitalMeter DMTempRemota;
        private System.Windows.Forms.Label labelVelMotorRemoto;
        private LBSoft.IndustrialCtrls.Meters.LBAnalogMeter AMVelMotRemoto;
        private System.Windows.Forms.Label labelTempRemota;
        private System.Windows.Forms.Label labelPosServoRemoto;
        private System.Windows.Forms.Button BTActivarDisplay;
        private System.Windows.Forms.Button BTCancelarTodo;
        private System.Windows.Forms.TextBox TBServoLocal;
        private System.Windows.Forms.TextBox TBServoRemoto;
        private System.Windows.Forms.TextBox TBTiempoTemperatura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

