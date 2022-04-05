using RobotKolKontrol.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotKolKontrol
{
    public partial class Form1 : Form
    {

        private bool boolOtomatikAci = false;
        private bool boolMaxAci = false;
        private bool boolHataOlustu = false;
        private int sonHareketliEkrem = 0;
        /// <summary>
        /// Hareketli eklemler
        /// 1 - Temel
        /// 2 - Platform
        /// 3 - AltKol
        /// 4 - UstKol
        /// 5 - Burgu
        /// 6 - Kiskac
        /// </summary>

        private int PozisyonPointer = 0;

        private SerialPort port;

        public Form1()
        {
            InitializeComponent();

        }

        private void btHesapla_Click(object sender, EventArgs e)
        {
            if (txtX.Text.Length == 0 | txtY.Text.Length == 0)
                return;

            IKKontrol IK = new IKKontrol();

            if (boolOtomatikAci)
            {
                int aci = AciGetir(int.Parse(txtX.Text), int.Parse(txtY.Text));
                if (aci != -1)
                    txtAng.Text = aci.ToString();
                else
                    return;
            }

            IK.EklemleriPozisyonla(int.Parse(txtY.Text), int.Parse(txtX.Text), int.Parse(txtAng.Text));

            if (IK.Platform > 0)
            {
                txtPlatform.Text = IK.Platform.ToString();
                txtAltKol.Text = IK.AltKol.ToString();
                txtUstKol.Text = IK.UstKol.ToString();

                string ArduinoData = "R-1S-1D-1T-1P" + txtPlatform.Text + "A" + txtAltKol.Text + "U" + txtUstKol.Text;
                ArduinoyaVeriGonder(ArduinoData);

            }
            else
            {
                MessageBox.Show("ERİŞİLEMEYECEK KOORDİNAT GİRDİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                boolHataOlustu = true;
            }

        }

        private void ArduinoyaVeriGonder(string data)
        {
            if (chkALog.Checked)
            {
                lstArduinoLog.Items.Add("\nGönderilen data :" + data);
                lstArduinoLog.SetSelected(lstArduinoLog.Items.Count - 1, true);
                
            }
            if (chkArduino.Checked)
            {
                if (port == null)
                    return;
                port.WriteLine(data);
            }
        }

        private int AciGetir(int X, int Y)
        {
            try
            {
                sqlCommand1 = new System.Data.SqlClient.SqlCommand();
                sqlCommand1.Connection = sqlConnection1;

                sqlCommand1.CommandType = CommandType.StoredProcedure;
                if (boolMaxAci)
                    sqlCommand1.CommandText = "spsel_KoordinataGoreMaxAci";
                else
                    sqlCommand1.CommandText = "spsel_KoordinataGoreMinAci";
                sqlCommand1.Parameters.AddWithValue("@X", X);
                sqlCommand1.Parameters.AddWithValue("@Y", Y);
                if (sqlConnection1.State == ConnectionState.Closed)
                    sqlConnection1.Open();
                int deger = (int)sqlCommand1.ExecuteScalar();
                sqlConnection1.Close();
                return deger;
            }
            catch 
            {
                MessageBox.Show("ERİŞİLEMEYECEK KOORDİNAT GİRDİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (sqlConnection1.State == ConnectionState.Open) sqlConnection1.Close();
                boolHataOlustu = true;
                return -1;
            }

        }

        private void PozisyonEkle()
        {
            string PozisyonData = String.Format("R-1S-1D-1T{0}P{1}A{2}U{3}B{4}K{5}", txtTemel.Text, txtPlatform.Text, txtAltKol.Text, txtUstKol.Text, txtBurgu.Text, txtKiskac.Text);
            //if (rtPozisyonlar.Lines.Length == 0)
            //    rtPozisyonlar.AppendText(PozisyonData);
            //else
            //    rtPozisyonlar.AppendText("\n" + PozisyonData);

            lstPozisyon.Items.Add(PozisyonData);
            lstPozisyon.SetSelected(lstPozisyon.Items.Count - 1, true);
        }


        private void ResetPozisyonlari()
        {
            txtPlatform.Text = "100";
            txtAltKol.Text = "86";
            txtUstKol.Text = "100";
            txtBurgu.Text = "100";
            txtKiskac.Text = "0";
            txtTemel.Text = "90";
            if (lstPozisyon.Items.Count !=0)
                PozisyonEkle();
        }

        private void btXArti_Click(object sender, EventArgs e)
        {
            txtX.Text = (int.Parse(txtX.Text) + 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtX.Text = (int.Parse(txtX.Text) - 1).ToString();
                boolHataOlustu = false;
            }
        }

        private void btYArti_Click(object sender, EventArgs e)
        {
            txtY.Text = (int.Parse(txtY.Text) + 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtY.Text = (int.Parse(txtY.Text) - 1).ToString();
                boolHataOlustu = false;
            }
        }

        private void btAciEksi_Click(object sender, EventArgs e)
        {
            txtAng.Text = (int.Parse(txtAng.Text) - 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtAng.Text = (int.Parse(txtAng.Text) + 1).ToString();
                boolHataOlustu = false;
            }

        }

        private void btXEksi_Click(object sender, EventArgs e)
        {
            txtX.Text = (int.Parse(txtX.Text) - 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtX.Text = (int.Parse(txtX.Text) + 1).ToString();
                boolHataOlustu = false;
            }
        }

        private void btYEksi_Click(object sender, EventArgs e)
        {
            txtY.Text = (int.Parse(txtY.Text) - 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtY.Text = (int.Parse(txtY.Text) + 1).ToString();
                boolHataOlustu = false;
            }
        }

        private void btAciArti_Click(object sender, EventArgs e)
        {
            txtAng.Text = (int.Parse(txtAng.Text) + 1).ToString();
            btHesapla_Click(null, null);
            if (boolHataOlustu)
            {
                txtAng.Text = (int.Parse(txtAng.Text) - 1).ToString();
                boolHataOlustu = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbAci.SelectedItem.ToString())
            {
                case "Girilen Değer":
                    txtAng.Enabled = true;
                    boolOtomatikAci = false;
                    btAciArti.Enabled = true;
                    btAciEksi.Enabled = true;
                    break;
                case "Max":
                    txtAng.Enabled = false;
                    boolOtomatikAci = true;
                    boolMaxAci = true;
                    txtAng.Text = "";
                    btAciArti.Enabled = false;
                    btAciEksi.Enabled = false;
                    if (txtX.Text.Length > 0 && txtY.Text.Length > 0)
                        btHesapla_Click(null, null);
                    break;
                case "Min":
                    boolOtomatikAci = true;
                    txtAng.Enabled = false;
                    boolMaxAci = false;
                    txtAng.Text = "";
                    btAciArti.Enabled = false;
                    btAciEksi.Enabled = false;
                    if (txtX.Text.Length > 0 && txtY.Text.Length > 0)
                        btHesapla_Click(null, null);
                    break;
                default:
                    break;
            }



        }

        private void btReset_Click(object sender, EventArgs e)
        {
            string arduinoData = "R1";
            ArduinoyaVeriGonder(arduinoData);

            ResetPozisyonlari();
        }

        

        private void btBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                if (port == null)
                {
                    btBaglan.Text = "Kes";
                    port = new SerialPort(cmbPort.SelectedItem.ToString(), 9600);
                    port.Open();
                    chkArduino.Enabled = true;
                }

                else if (port.IsOpen)
                {
                    btReset_Click(null, null);
                    port.Close();
                    port = null;
                    btBaglan.Text = "Bağlan";
                    chkArduino.Enabled = false;
                    chkArduino.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası. Hata :" + ex.Message);
                btBaglan.Text = "Bağlan";
                port = null;
                chkArduino.Checked = false;
                chkArduino.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] portlar = SerialPort.GetPortNames();
            foreach (string port in portlar)
            {
                cmbPort.Items.Add(port);
            }

            ResetPozisyonlari();
        }

        private void chkArduino_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkArduino.Checked)
                btHesapla.Text = "Git";
            else
                btHesapla.Text = "Hesapla";
        }

        private void btPortYenile_Click(object sender, EventArgs e)
        {
            cmbPort.Items.Clear();
            string[] portlar = SerialPort.GetPortNames();
            foreach (string port in portlar)
            {
                cmbPort.Items.Add(port);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtX.Text.Length > 0 && txtY.Text.Length > 0 && txtAng.Text.Length > 0)
            {
                if (e.KeyCode == Keys.W)
                    btYArti_Click(null, null);
                if (e.KeyCode == Keys.S)
                    btYEksi_Click(null, null);
                if (e.KeyCode == Keys.A)
                    btXEksi_Click(null, null);
                if (e.KeyCode == Keys.D)
                    btXArti_Click(null, null);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btTArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 1;
            if (int.Parse(txtTemel.Text) < 180)
            {
                if (sonHareketliEkrem != 1)
                    PozisyonEkle();
                sonHareketliEkrem = 1;
                txtTemel.Text = (int.Parse(txtTemel.Text) + 1).ToString();
                string ArduinoData = "R-1S-1D-1T" + txtTemel.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }

        }

        

        private void btPArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 2;
            if (int.Parse(txtPlatform.Text) < 180)
            {
                if (sonHareketliEkrem != 2)
                    PozisyonEkle();
                sonHareketliEkrem = 2;
                txtPlatform.Text = (int.Parse(txtPlatform.Text) + 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P" + txtPlatform.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btAArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 2;
            if (int.Parse(txtAltKol.Text) < 180)
            {
                if (sonHareketliEkrem != 3)
                    PozisyonEkle();
                sonHareketliEkrem = 3;
                txtAltKol.Text = (int.Parse(txtAltKol.Text) + 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A" + txtAltKol.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btUArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 3;
            if (int.Parse(txtUstKol.Text) < 180)
            {
                if (sonHareketliEkrem != 4)
                    PozisyonEkle();
                sonHareketliEkrem = 4;
                txtUstKol.Text = (int.Parse(txtUstKol.Text) + 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U" + txtUstKol.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btBArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 4;
            if (int.Parse(txtBurgu.Text) < 180)
            {
                if (sonHareketliEkrem != 5)
                    PozisyonEkle();
                sonHareketliEkrem = 5;
                txtBurgu.Text = (int.Parse(txtBurgu.Text) + 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U-1B" + txtBurgu.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btKArti_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 5;
            if (int.Parse(txtKiskac.Text) < 180)
            {
                if (sonHareketliEkrem != 6)
                    PozisyonEkle();
                sonHareketliEkrem = 6;
                txtKiskac.Text = (int.Parse(txtKiskac.Text) + 10).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U-1B-1K" + txtKiskac.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btTEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 1;
            if (int.Parse(txtTemel.Text) > 0)
            {
                if (sonHareketliEkrem != 1)
                    PozisyonEkle();
                sonHareketliEkrem = 1;
                txtTemel.Text = (int.Parse(txtTemel.Text) - 1).ToString();
                string ArduinoData = "R-1S-1D-1T" + txtTemel.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btPEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 2;
            if (int.Parse(txtPlatform.Text) > 0)
            {
                if (sonHareketliEkrem != 2)
                    PozisyonEkle();
                sonHareketliEkrem = 2;
                txtPlatform.Text = (int.Parse(txtPlatform.Text) - 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P" + txtPlatform.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btAEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 3;
            if (int.Parse(txtAltKol.Text) > 0)
            {
                if (sonHareketliEkrem != 3)
                    PozisyonEkle();
                sonHareketliEkrem = 3;
                txtAltKol.Text = (int.Parse(txtAltKol.Text) - 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A" + txtAltKol.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btUEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 4;
            if (int.Parse(txtUstKol.Text) > 0)
            {
                if (sonHareketliEkrem != 4)
                    PozisyonEkle();
                sonHareketliEkrem = 4;
                txtUstKol.Text = (int.Parse(txtUstKol.Text) - 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U" + txtUstKol.Text; 
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btBEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 5;
            if (int.Parse(txtBurgu.Text) > 0)
            {
                if (sonHareketliEkrem != 5)
                    PozisyonEkle();
                sonHareketliEkrem = 5;
                txtBurgu.Text = (int.Parse(txtBurgu.Text) - 1).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U-1B" + txtBurgu.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }

        private void btKEksi_Click(object sender, EventArgs e)
        {
            if (sonHareketliEkrem == 0)
                sonHareketliEkrem = 6;
            if (int.Parse(txtKiskac.Text) > 0)
            {
                if (sonHareketliEkrem != 6)
                    PozisyonEkle();
                sonHareketliEkrem = 6;
                txtKiskac.Text = (int.Parse(txtKiskac.Text) - 10).ToString();
                string ArduinoData = "R-1S-1D-1T-1P-1A-1U-1B-1K" + txtKiskac.Text;
                ArduinoyaVeriGonder(ArduinoData);
            }
        }


        

        private void btTemizle_Click(object sender, EventArgs e)
        {
            lstArduinoLog.Items.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port != null)
                if (port.IsOpen)
                    btReset_Click(null, null);
        }

        private void btPozisyonSil_Click(object sender, EventArgs e)
        {
            lstPozisyon.Items.Clear();
        }

        private void btPozisyonEkle_Click(object sender, EventArgs e)
        {
            sonHareketliEkrem = 0;
            PozisyonEkle();
        }

        private void btPosizyonDon_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btReset.Enabled = false;
            btPozisyonSil.Enabled = false;
            btPosIleri.Enabled = false;
            btPosGeri.Enabled = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkArduino.Checked)
            { 
                string arduinoOut = port.ReadLine();
                //arduinoOut = arduinoOut.Remove(0, 1);
                int arduinoOutLenght = arduinoOut.Length;
                arduinoOut=arduinoOut.Remove(arduinoOutLenght - 1, 1);
                lstArduinoOut.Items.Add(arduinoOut);
                lstArduinoOut.SetSelected(lstArduinoOut.Items.Count - 1, true);
                if (lstPozisyon.Items[PozisyonPointer].ToString() == arduinoOut)
                    return;
            }

            PozisyonPointer++;
            if (PozisyonPointer > lstPozisyon.Items.Count-1)
                PozisyonPointer = 0;
            lstPozisyon.SelectedIndex = PozisyonPointer;
            ArduinoyaVeriGonder(lstPozisyon.Items[PozisyonPointer].ToString());            
        }

        private void btPozisyonDur_Click(object sender, EventArgs e)
        {            
            timer1.Stop();
            groupBox1.Enabled = true;
            btReset.Enabled = true;
            btPozisyonSil.Enabled = true;
            btPosIleri.Enabled = true;
            btPosGeri.Enabled = true;
            
        }

        private void btArduinoOutSil_Click(object sender, EventArgs e)
        {
            lstArduinoOut.Items.Clear();
        }

        private void btPosIleri_Click(object sender, EventArgs e)
        {
            if (lstPozisyon.Items.Count == 0)
                return;
            ArduinoyaVeriGonder(lstPozisyon.Items[lstPozisyon.SelectedIndex].ToString());
            int odak = lstPozisyon.SelectedIndex + 1;
            if (odak < lstPozisyon.Items.Count)
                lstPozisyon.SelectedIndex = odak;
            else lstPozisyon.SelectedIndex = 0;
            
        }

        private void btPosGeri_Click(object sender, EventArgs e)
        {
            if (lstPozisyon.Items.Count == 0)
                return;
            ArduinoyaVeriGonder(lstPozisyon.Items[lstPozisyon.SelectedIndex].ToString());
            int odak = lstPozisyon.SelectedIndex - 1;
            if (odak >= 0)
                lstPozisyon.SelectedIndex = odak;
            else lstPozisyon.SetSelected(lstPozisyon.Items.Count - 1, true);
        }
    }
}
