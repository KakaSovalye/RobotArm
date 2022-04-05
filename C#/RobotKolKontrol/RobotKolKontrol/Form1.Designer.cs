
namespace RobotKolKontrol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtAng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtAltKol = new System.Windows.Forms.TextBox();
            this.txtUstKol = new System.Windows.Forms.TextBox();
            this.btHesapla = new System.Windows.Forms.Button();
            this.btXArti = new System.Windows.Forms.Button();
            this.btXEksi = new System.Windows.Forms.Button();
            this.btYEksi = new System.Windows.Forms.Button();
            this.btYArti = new System.Windows.Forms.Button();
            this.btAciArti = new System.Windows.Forms.Button();
            this.btAciEksi = new System.Windows.Forms.Button();
            this.cmbAci = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.chkArduino = new System.Windows.Forms.CheckBox();
            this.btReset = new System.Windows.Forms.Button();
            this.txtBurgu = new System.Windows.Forms.TextBox();
            this.txtKiskac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTemel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btBaglan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btKEksi = new System.Windows.Forms.Button();
            this.btKArti = new System.Windows.Forms.Button();
            this.btBEksi = new System.Windows.Forms.Button();
            this.btBArti = new System.Windows.Forms.Button();
            this.btUEksi = new System.Windows.Forms.Button();
            this.btUArti = new System.Windows.Forms.Button();
            this.btAEksi = new System.Windows.Forms.Button();
            this.btAArti = new System.Windows.Forms.Button();
            this.btPEksi = new System.Windows.Forms.Button();
            this.btPArti = new System.Windows.Forms.Button();
            this.btTEksi = new System.Windows.Forms.Button();
            this.btTArti = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btPortYenile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btTemizle = new System.Windows.Forms.Button();
            this.chkALog = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btPozisyonSil = new System.Windows.Forms.Button();
            this.btPozisyonEkle = new System.Windows.Forms.Button();
            this.btPosizyonDon = new System.Windows.Forms.Button();
            this.btPozisyonDur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btArduinoOutSil = new System.Windows.Forms.Button();
            this.btPosGeri = new System.Windows.Forms.Button();
            this.btPosIleri = new System.Windows.Forms.Button();
            this.lstPozisyon = new System.Windows.Forms.ListBox();
            this.lstArduinoOut = new System.Windows.Forms.ListBox();
            this.lstArduinoLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(61, 86);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(61, 132);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtAng
            // 
            this.txtAng.Location = new System.Drawing.Point(61, 219);
            this.txtAng.Name = "txtAng";
            this.txtAng.Size = new System.Drawing.Size(100, 20);
            this.txtAng.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Platform";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "AltKol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "UstKol";
            // 
            // txtPlatform
            // 
            this.txtPlatform.Enabled = false;
            this.txtPlatform.Location = new System.Drawing.Point(68, 12);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(100, 20);
            this.txtPlatform.TabIndex = 9;
            // 
            // txtAltKol
            // 
            this.txtAltKol.Enabled = false;
            this.txtAltKol.Location = new System.Drawing.Point(68, 38);
            this.txtAltKol.Name = "txtAltKol";
            this.txtAltKol.ReadOnly = true;
            this.txtAltKol.Size = new System.Drawing.Size(100, 20);
            this.txtAltKol.TabIndex = 10;
            // 
            // txtUstKol
            // 
            this.txtUstKol.Enabled = false;
            this.txtUstKol.Location = new System.Drawing.Point(68, 64);
            this.txtUstKol.Name = "txtUstKol";
            this.txtUstKol.ReadOnly = true;
            this.txtUstKol.Size = new System.Drawing.Size(100, 20);
            this.txtUstKol.TabIndex = 11;
            // 
            // btHesapla
            // 
            this.btHesapla.Location = new System.Drawing.Point(168, 19);
            this.btHesapla.Name = "btHesapla";
            this.btHesapla.Size = new System.Drawing.Size(101, 23);
            this.btHesapla.TabIndex = 12;
            this.btHesapla.Text = "Hesapla";
            this.btHesapla.UseVisualStyleBackColor = true;
            this.btHesapla.Click += new System.EventHandler(this.btHesapla_Click);
            // 
            // btXArti
            // 
            this.btXArti.Location = new System.Drawing.Point(168, 86);
            this.btXArti.Name = "btXArti";
            this.btXArti.Size = new System.Drawing.Size(32, 23);
            this.btXArti.TabIndex = 13;
            this.btXArti.Text = "+";
            this.btXArti.UseVisualStyleBackColor = true;
            this.btXArti.Click += new System.EventHandler(this.btXArti_Click);
            // 
            // btXEksi
            // 
            this.btXEksi.Location = new System.Drawing.Point(22, 84);
            this.btXEksi.Name = "btXEksi";
            this.btXEksi.Size = new System.Drawing.Size(33, 23);
            this.btXEksi.TabIndex = 14;
            this.btXEksi.Text = "-";
            this.btXEksi.UseVisualStyleBackColor = true;
            this.btXEksi.Click += new System.EventHandler(this.btXEksi_Click);
            // 
            // btYEksi
            // 
            this.btYEksi.Location = new System.Drawing.Point(22, 129);
            this.btYEksi.Name = "btYEksi";
            this.btYEksi.Size = new System.Drawing.Size(33, 23);
            this.btYEksi.TabIndex = 15;
            this.btYEksi.Text = "-";
            this.btYEksi.UseVisualStyleBackColor = true;
            this.btYEksi.Click += new System.EventHandler(this.btYEksi_Click);
            // 
            // btYArti
            // 
            this.btYArti.Location = new System.Drawing.Point(168, 132);
            this.btYArti.Name = "btYArti";
            this.btYArti.Size = new System.Drawing.Size(32, 23);
            this.btYArti.TabIndex = 16;
            this.btYArti.Text = "+";
            this.btYArti.UseVisualStyleBackColor = true;
            this.btYArti.Click += new System.EventHandler(this.btYArti_Click);
            // 
            // btAciArti
            // 
            this.btAciArti.Location = new System.Drawing.Point(168, 219);
            this.btAciArti.Name = "btAciArti";
            this.btAciArti.Size = new System.Drawing.Size(33, 23);
            this.btAciArti.TabIndex = 17;
            this.btAciArti.Text = "+";
            this.btAciArti.UseVisualStyleBackColor = true;
            this.btAciArti.Click += new System.EventHandler(this.btAciArti_Click);
            // 
            // btAciEksi
            // 
            this.btAciEksi.Location = new System.Drawing.Point(22, 217);
            this.btAciEksi.Name = "btAciEksi";
            this.btAciEksi.Size = new System.Drawing.Size(33, 23);
            this.btAciEksi.TabIndex = 18;
            this.btAciEksi.Text = "-";
            this.btAciEksi.UseVisualStyleBackColor = true;
            this.btAciEksi.Click += new System.EventHandler(this.btAciEksi_Click);
            // 
            // cmbAci
            // 
            this.cmbAci.FormattingEnabled = true;
            this.cmbAci.Items.AddRange(new object[] {
            "Girilen Değer",
            "Max",
            "Min"});
            this.cmbAci.Location = new System.Drawing.Point(22, 190);
            this.cmbAci.Name = "cmbAci";
            this.cmbAci.Size = new System.Drawing.Size(178, 21);
            this.cmbAci.TabIndex = 19;
            this.cmbAci.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=xx.xx.xx.xx;Initial Catalog=UtilDB;User ID=user;Password=pass";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // chkArduino
            // 
            this.chkArduino.AutoSize = true;
            this.chkArduino.Enabled = false;
            this.chkArduino.Location = new System.Drawing.Point(15, 252);
            this.chkArduino.Name = "chkArduino";
            this.chkArduino.Size = new System.Drawing.Size(111, 17);
            this.chkArduino.TabIndex = 20;
            this.chkArduino.Text = "Arduino\'ya gönder";
            this.chkArduino.UseVisualStyleBackColor = true;
            this.chkArduino.CheckStateChanged += new System.EventHandler(this.chkArduino_CheckStateChanged);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(198, 10);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 21;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // txtBurgu
            // 
            this.txtBurgu.Enabled = false;
            this.txtBurgu.Location = new System.Drawing.Point(68, 90);
            this.txtBurgu.Name = "txtBurgu";
            this.txtBurgu.Size = new System.Drawing.Size(100, 20);
            this.txtBurgu.TabIndex = 22;
            // 
            // txtKiskac
            // 
            this.txtKiskac.Enabled = false;
            this.txtKiskac.Location = new System.Drawing.Point(68, 116);
            this.txtKiskac.Name = "txtKiskac";
            this.txtKiskac.Size = new System.Drawing.Size(100, 20);
            this.txtKiskac.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Burgu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Kıskaç";
            // 
            // txtTemel
            // 
            this.txtTemel.Enabled = false;
            this.txtTemel.Location = new System.Drawing.Point(68, 142);
            this.txtTemel.Name = "txtTemel";
            this.txtTemel.Size = new System.Drawing.Size(100, 20);
            this.txtTemel.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Temel";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(15, 225);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Arduino Portu";
            // 
            // btBaglan
            // 
            this.btBaglan.Location = new System.Drawing.Point(142, 225);
            this.btBaglan.Name = "btBaglan";
            this.btBaglan.Size = new System.Drawing.Size(75, 23);
            this.btBaglan.TabIndex = 30;
            this.btBaglan.Text = "Bağlan";
            this.btBaglan.UseVisualStyleBackColor = true;
            this.btBaglan.Click += new System.EventHandler(this.btBaglan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXArti);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtAng);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btXEksi);
            this.groupBox1.Controls.Add(this.btYEksi);
            this.groupBox1.Controls.Add(this.btYArti);
            this.groupBox1.Controls.Add(this.btAciArti);
            this.groupBox1.Controls.Add(this.btAciEksi);
            this.groupBox1.Controls.Add(this.btHesapla);
            this.groupBox1.Controls.Add(this.cmbAci);
            this.groupBox1.Location = new System.Drawing.Point(323, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 272);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IK Kontrolleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btKEksi);
            this.groupBox2.Controls.Add(this.btKArti);
            this.groupBox2.Controls.Add(this.btBEksi);
            this.groupBox2.Controls.Add(this.btBArti);
            this.groupBox2.Controls.Add(this.btUEksi);
            this.groupBox2.Controls.Add(this.btUArti);
            this.groupBox2.Controls.Add(this.btAEksi);
            this.groupBox2.Controls.Add(this.btAArti);
            this.groupBox2.Controls.Add(this.btPEksi);
            this.groupBox2.Controls.Add(this.btPArti);
            this.groupBox2.Controls.Add(this.btTEksi);
            this.groupBox2.Controls.Add(this.btTArti);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(631, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 270);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manuel Kontrol";
            // 
            // btKEksi
            // 
            this.btKEksi.Location = new System.Drawing.Point(13, 220);
            this.btKEksi.Name = "btKEksi";
            this.btKEksi.Size = new System.Drawing.Size(39, 23);
            this.btKEksi.TabIndex = 17;
            this.btKEksi.Text = "-";
            this.btKEksi.UseVisualStyleBackColor = true;
            this.btKEksi.Click += new System.EventHandler(this.btKEksi_Click);
            // 
            // btKArti
            // 
            this.btKArti.Location = new System.Drawing.Point(103, 220);
            this.btKArti.Name = "btKArti";
            this.btKArti.Size = new System.Drawing.Size(41, 23);
            this.btKArti.TabIndex = 16;
            this.btKArti.Text = "+";
            this.btKArti.UseVisualStyleBackColor = true;
            this.btKArti.Click += new System.EventHandler(this.btKArti_Click);
            // 
            // btBEksi
            // 
            this.btBEksi.Location = new System.Drawing.Point(12, 187);
            this.btBEksi.Name = "btBEksi";
            this.btBEksi.Size = new System.Drawing.Size(40, 23);
            this.btBEksi.TabIndex = 15;
            this.btBEksi.Text = "-";
            this.btBEksi.UseVisualStyleBackColor = true;
            this.btBEksi.Click += new System.EventHandler(this.btBEksi_Click);
            // 
            // btBArti
            // 
            this.btBArti.Location = new System.Drawing.Point(102, 187);
            this.btBArti.Name = "btBArti";
            this.btBArti.Size = new System.Drawing.Size(42, 23);
            this.btBArti.TabIndex = 14;
            this.btBArti.Text = "+";
            this.btBArti.UseVisualStyleBackColor = true;
            this.btBArti.Click += new System.EventHandler(this.btBArti_Click);
            // 
            // btUEksi
            // 
            this.btUEksi.Location = new System.Drawing.Point(13, 153);
            this.btUEksi.Name = "btUEksi";
            this.btUEksi.Size = new System.Drawing.Size(40, 23);
            this.btUEksi.TabIndex = 13;
            this.btUEksi.Text = "-";
            this.btUEksi.UseVisualStyleBackColor = true;
            this.btUEksi.Click += new System.EventHandler(this.btUEksi_Click);
            // 
            // btUArti
            // 
            this.btUArti.Location = new System.Drawing.Point(102, 155);
            this.btUArti.Name = "btUArti";
            this.btUArti.Size = new System.Drawing.Size(42, 23);
            this.btUArti.TabIndex = 12;
            this.btUArti.Text = "+";
            this.btUArti.UseVisualStyleBackColor = true;
            this.btUArti.Click += new System.EventHandler(this.btUArti_Click);
            // 
            // btAEksi
            // 
            this.btAEksi.Location = new System.Drawing.Point(13, 120);
            this.btAEksi.Name = "btAEksi";
            this.btAEksi.Size = new System.Drawing.Size(39, 23);
            this.btAEksi.TabIndex = 11;
            this.btAEksi.Text = "-";
            this.btAEksi.UseVisualStyleBackColor = true;
            this.btAEksi.Click += new System.EventHandler(this.btAEksi_Click);
            // 
            // btAArti
            // 
            this.btAArti.Location = new System.Drawing.Point(102, 120);
            this.btAArti.Name = "btAArti";
            this.btAArti.Size = new System.Drawing.Size(41, 23);
            this.btAArti.TabIndex = 10;
            this.btAArti.Text = "+";
            this.btAArti.UseVisualStyleBackColor = true;
            this.btAArti.Click += new System.EventHandler(this.btAArti_Click);
            // 
            // btPEksi
            // 
            this.btPEksi.Location = new System.Drawing.Point(14, 85);
            this.btPEksi.Name = "btPEksi";
            this.btPEksi.Size = new System.Drawing.Size(39, 23);
            this.btPEksi.TabIndex = 9;
            this.btPEksi.Text = "-";
            this.btPEksi.UseVisualStyleBackColor = true;
            this.btPEksi.Click += new System.EventHandler(this.btPEksi_Click);
            // 
            // btPArti
            // 
            this.btPArti.Location = new System.Drawing.Point(103, 85);
            this.btPArti.Name = "btPArti";
            this.btPArti.Size = new System.Drawing.Size(41, 23);
            this.btPArti.TabIndex = 8;
            this.btPArti.Text = "+";
            this.btPArti.UseVisualStyleBackColor = true;
            this.btPArti.Click += new System.EventHandler(this.btPArti_Click);
            // 
            // btTEksi
            // 
            this.btTEksi.Location = new System.Drawing.Point(14, 54);
            this.btTEksi.Name = "btTEksi";
            this.btTEksi.Size = new System.Drawing.Size(39, 23);
            this.btTEksi.TabIndex = 7;
            this.btTEksi.Text = "-";
            this.btTEksi.UseVisualStyleBackColor = true;
            this.btTEksi.Click += new System.EventHandler(this.btTEksi_Click);
            // 
            // btTArti
            // 
            this.btTArti.Location = new System.Drawing.Point(103, 54);
            this.btTArti.Name = "btTArti";
            this.btTArti.Size = new System.Drawing.Size(41, 23);
            this.btTArti.TabIndex = 6;
            this.btTArti.Text = "+";
            this.btTArti.UseVisualStyleBackColor = true;
            this.btTArti.Click += new System.EventHandler(this.btTArti_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Kıskaç";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Burgu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Üst Kol";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Alt Kol";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Platform";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Temel";
            // 
            // btPortYenile
            // 
            this.btPortYenile.Location = new System.Drawing.Point(92, 199);
            this.btPortYenile.Name = "btPortYenile";
            this.btPortYenile.Size = new System.Drawing.Size(131, 23);
            this.btPortYenile.TabIndex = 33;
            this.btPortYenile.Text = "Port Listesini Güncelle";
            this.btPortYenile.UseVisualStyleBackColor = true;
            this.btPortYenile.Click += new System.EventHandler(this.btPortYenile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cursor Dinlendir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Arduino Log";
            // 
            // btTemizle
            // 
            this.btTemizle.Location = new System.Drawing.Point(384, 348);
            this.btTemizle.Name = "btTemizle";
            this.btTemizle.Size = new System.Drawing.Size(75, 23);
            this.btTemizle.TabIndex = 37;
            this.btTemizle.Text = "Log Temizle";
            this.btTemizle.UseVisualStyleBackColor = true;
            this.btTemizle.Click += new System.EventHandler(this.btTemizle_Click);
            // 
            // chkALog
            // 
            this.chkALog.AutoSize = true;
            this.chkALog.Location = new System.Drawing.Point(15, 275);
            this.chkALog.Name = "chkALog";
            this.chkALog.Size = new System.Drawing.Size(91, 17);
            this.chkALog.TabIndex = 38;
            this.chkALog.Text = "Arduino Logla";
            this.chkALog.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(631, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Pozisyonlar";
            // 
            // btPozisyonSil
            // 
            this.btPozisyonSil.Location = new System.Drawing.Point(1009, 456);
            this.btPozisyonSil.Name = "btPozisyonSil";
            this.btPozisyonSil.Size = new System.Drawing.Size(75, 39);
            this.btPozisyonSil.TabIndex = 41;
            this.btPozisyonSil.Text = "Pozisyonları Temizle";
            this.btPozisyonSil.UseVisualStyleBackColor = true;
            this.btPozisyonSil.Click += new System.EventHandler(this.btPozisyonSil_Click);
            // 
            // btPozisyonEkle
            // 
            this.btPozisyonEkle.Location = new System.Drawing.Point(838, 31);
            this.btPozisyonEkle.Name = "btPozisyonEkle";
            this.btPozisyonEkle.Size = new System.Drawing.Size(75, 39);
            this.btPozisyonEkle.TabIndex = 42;
            this.btPozisyonEkle.Text = "Poziyonu Ekle";
            this.btPozisyonEkle.UseVisualStyleBackColor = true;
            this.btPozisyonEkle.Click += new System.EventHandler(this.btPozisyonEkle_Click);
            // 
            // btPosizyonDon
            // 
            this.btPosizyonDon.Location = new System.Drawing.Point(1009, 351);
            this.btPosizyonDon.Name = "btPosizyonDon";
            this.btPosizyonDon.Size = new System.Drawing.Size(75, 39);
            this.btPosizyonDon.TabIndex = 43;
            this.btPosizyonDon.Text = "Pozisyonları Dolaş";
            this.btPosizyonDon.UseVisualStyleBackColor = true;
            this.btPosizyonDon.Click += new System.EventHandler(this.btPosizyonDon_Click);
            // 
            // btPozisyonDur
            // 
            this.btPozisyonDur.Location = new System.Drawing.Point(1009, 396);
            this.btPozisyonDur.Name = "btPozisyonDur";
            this.btPozisyonDur.Size = new System.Drawing.Size(75, 23);
            this.btPozisyonDur.TabIndex = 44;
            this.btPozisyonDur.Text = "Dur";
            this.btPozisyonDur.UseVisualStyleBackColor = true;
            this.btPozisyonDur.Click += new System.EventHandler(this.btPozisyonDur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btArduinoOutSil
            // 
            this.btArduinoOutSil.Location = new System.Drawing.Point(1101, 293);
            this.btArduinoOutSil.Name = "btArduinoOutSil";
            this.btArduinoOutSil.Size = new System.Drawing.Size(75, 23);
            this.btArduinoOutSil.TabIndex = 46;
            this.btArduinoOutSil.Text = "Temizle";
            this.btArduinoOutSil.UseVisualStyleBackColor = true;
            this.btArduinoOutSil.Click += new System.EventHandler(this.btArduinoOutSil_Click);
            // 
            // btPosGeri
            // 
            this.btPosGeri.Location = new System.Drawing.Point(1090, 351);
            this.btPosGeri.Name = "btPosGeri";
            this.btPosGeri.Size = new System.Drawing.Size(34, 23);
            this.btPosGeri.TabIndex = 47;
            this.btPosGeri.Text = "<";
            this.btPosGeri.UseVisualStyleBackColor = true;
            this.btPosGeri.Click += new System.EventHandler(this.btPosGeri_Click);
            // 
            // btPosIleri
            // 
            this.btPosIleri.Location = new System.Drawing.Point(1142, 351);
            this.btPosIleri.Name = "btPosIleri";
            this.btPosIleri.Size = new System.Drawing.Size(34, 23);
            this.btPosIleri.TabIndex = 48;
            this.btPosIleri.Text = ">";
            this.btPosIleri.UseVisualStyleBackColor = true;
            this.btPosIleri.Click += new System.EventHandler(this.btPosIleri_Click);
            // 
            // lstPozisyon
            // 
            this.lstPozisyon.FormattingEnabled = true;
            this.lstPozisyon.Location = new System.Drawing.Point(631, 351);
            this.lstPozisyon.Name = "lstPozisyon";
            this.lstPozisyon.Size = new System.Drawing.Size(359, 225);
            this.lstPozisyon.TabIndex = 49;
            // 
            // lstArduinoOut
            // 
            this.lstArduinoOut.FormattingEnabled = true;
            this.lstArduinoOut.Location = new System.Drawing.Point(838, 81);
            this.lstArduinoOut.Name = "lstArduinoOut";
            this.lstArduinoOut.Size = new System.Drawing.Size(338, 199);
            this.lstArduinoOut.TabIndex = 50;
            // 
            // lstArduinoLog
            // 
            this.lstArduinoLog.FormattingEnabled = true;
            this.lstArduinoLog.Location = new System.Drawing.Point(19, 351);
            this.lstArduinoLog.Name = "lstArduinoLog";
            this.lstArduinoLog.Size = new System.Drawing.Size(359, 225);
            this.lstArduinoLog.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 671);
            this.Controls.Add(this.lstArduinoLog);
            this.Controls.Add(this.lstArduinoOut);
            this.Controls.Add(this.lstPozisyon);
            this.Controls.Add(this.btPosIleri);
            this.Controls.Add(this.btPosGeri);
            this.Controls.Add(this.btArduinoOutSil);
            this.Controls.Add(this.btPozisyonDur);
            this.Controls.Add(this.btPosizyonDon);
            this.Controls.Add(this.btPozisyonEkle);
            this.Controls.Add(this.btPozisyonSil);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.chkALog);
            this.Controls.Add(this.btTemizle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPortYenile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBaglan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTemel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKiskac);
            this.Controls.Add(this.txtBurgu);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.chkArduino);
            this.Controls.Add(this.txtUstKol);
            this.Controls.Add(this.txtAltKol);
            this.Controls.Add(this.txtPlatform);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtAng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtAltKol;
        private System.Windows.Forms.TextBox txtUstKol;
        private System.Windows.Forms.Button btHesapla;
        private System.Windows.Forms.Button btXArti;
        private System.Windows.Forms.Button btXEksi;
        private System.Windows.Forms.Button btYEksi;
        private System.Windows.Forms.Button btYArti;
        private System.Windows.Forms.Button btAciArti;
        private System.Windows.Forms.Button btAciEksi;
        private System.Windows.Forms.ComboBox cmbAci;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.CheckBox chkArduino;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox txtBurgu;
        private System.Windows.Forms.TextBox txtKiskac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTemel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btBaglan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btKEksi;
        private System.Windows.Forms.Button btKArti;
        private System.Windows.Forms.Button btBEksi;
        private System.Windows.Forms.Button btBArti;
        private System.Windows.Forms.Button btUEksi;
        private System.Windows.Forms.Button btUArti;
        private System.Windows.Forms.Button btAEksi;
        private System.Windows.Forms.Button btAArti;
        private System.Windows.Forms.Button btPEksi;
        private System.Windows.Forms.Button btPArti;
        private System.Windows.Forms.Button btTEksi;
        private System.Windows.Forms.Button btTArti;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btPortYenile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btTemizle;
        private System.Windows.Forms.CheckBox chkALog;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btPozisyonSil;
        private System.Windows.Forms.Button btPozisyonEkle;
        private System.Windows.Forms.Button btPosizyonDon;
        private System.Windows.Forms.Button btPozisyonDur;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btArduinoOutSil;
        private System.Windows.Forms.Button btPosGeri;
        private System.Windows.Forms.Button btPosIleri;
        private System.Windows.Forms.ListBox lstPozisyon;
        private System.Windows.Forms.ListBox lstArduinoOut;
        private System.Windows.Forms.ListBox lstArduinoLog;
    }
}

