/******************************************************************************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Annamyrat Övezov
**				ÖĞRENCİ NUMARASI.......: B120910058
**              DERSİN ALINDIĞI GRUP...: 1A
******************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Double sonuc = 0;
        bool optDurum = false;
        string opt = ""; //eski operatör bilgisi
        public Form1()
        {
            InitializeComponent();
            txtSonuc.Text = "0";
        }

        private void raklamOlay(object sender, EventArgs e) // Rakamlar text değerine ekleniyor
        {
            
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void islemOlay(object sender, EventArgs e) // İşlemler gerçeklerşiyor
        {
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbSonuc.Text = lbSonuc.Text +" "+ txtSonuc.Text+ " " + yeniOpt;
            //önceki operatör bilgisine ihtiyaç var.
            switch(opt) // Text' deki duruma göre giriyor
            {
                // İşlemler
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break; 
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "X2":txtSonuc.Text= (sonuc * sonuc).ToString(); break;
                case "X3": txtSonuc.Text = (sonuc * sonuc * sonuc).ToString(); break;
                case "sin":txtSonuc.Text = Math.Sin((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "sinh": txtSonuc.Text = Math.Sinh((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "cos": txtSonuc.Text = Math.Cos((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "cosh": txtSonuc.Text = Math.Cosh((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "π": txtSonuc.Text = (sonuc * 3.14159265358979323846).ToString(); break;
                case "tan":txtSonuc.Text = (Math.Sin((Math.PI * Double.Parse(txtSonuc.Text)) / 180) / Math.Cos((Math.PI * Double.Parse(txtSonuc.Text)) / 180)).ToString(); break;
                case "tanh": txtSonuc.Text = (Math.Sinh((Math.PI * Double.Parse(txtSonuc.Text)) / 180) / Math.Cosh((Math.PI * Double.Parse(txtSonuc.Text)) / 180)).ToString(); break;
                case "√": txtSonuc.Text = (Math.Sqrt(Double.Parse(txtSonuc.Text)).ToString()); break;
                case "10x":txtSonuc.Text= (Math.Pow(10, Double.Parse(txtSonuc.Text)).ToString()); break;
                case "log": txtSonuc.Text = System.Math.Log(Double.Parse(txtSonuc.Text), 10).ToString(); break;
                case "Exp": txtSonuc.Text = (Math.Exp(Double.Parse(txtSonuc.Text))).ToString(); break;
                case "n!":
                    for (int i = 1; i <= Double.Parse(txtSonuc.Text)-1; i++)
                    {
                        sonuc *= i;
                    }
                    txtSonuc.Text = (sonuc).ToString();
                    break;
                case "+,-": txtSonuc.Text = (Double.Parse("-") * Double.Parse(txtSonuc.Text)).ToString(); break; 
            }
            sonuc = Double.Parse(txtSonuc.Text);
            optDurum = true;
            opt = yeniOpt;
        }

        private void bCE_Click(object sender, EventArgs e) // Hesap kısmını temizliyor
        {
            txtSonuc.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e) // İşlem ve hesap kısmını temizliyor
        {
            txtSonuc.Text = "0";
            sonuc = 0;
            lbSonuc.Text = "";
            opt = "";
        }

        private void bEsit_Click(object sender, EventArgs e) // Eşittire basıldığında işlemler tekrar giriliyor
        {
            lbSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "X2": txtSonuc.Text = (sonuc * sonuc).ToString(); break;
                case "X3": txtSonuc.Text = (sonuc * sonuc * sonuc).ToString(); break;
                case "sin": txtSonuc.Text = Math.Sin((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "sinh": txtSonuc.Text = Math.Sinh((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "cos": txtSonuc.Text = Math.Cos((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "cosh": txtSonuc.Text = Math.Cosh((Math.PI * Double.Parse(txtSonuc.Text)) / 180).ToString(); break;
                case "π": txtSonuc.Text = (sonuc *3.14159265358979323846).ToString(); break;
                case "tan": txtSonuc.Text = (Math.Sin((Math.PI * Double.Parse(txtSonuc.Text)) / 180) / Math.Cos((Math.PI * Double.Parse(txtSonuc.Text)) / 180)).ToString(); break;
                case "tanh": txtSonuc.Text = (Math.Sinh((Math.PI * Double.Parse(txtSonuc.Text)) / 180) / Math.Cosh((Math.PI * Double.Parse(txtSonuc.Text)) / 180)).ToString(); break;
                case "√": txtSonuc.Text = (Math.Sqrt(Double.Parse(txtSonuc.Text)).ToString()); break;
                case "10x": txtSonuc.Text = (Math.Pow(10, Double.Parse(txtSonuc.Text)).ToString()); break;
                case "log": txtSonuc.Text = System.Math.Log(Double.Parse(txtSonuc.Text), 10).ToString(); break;
                case "Exp": txtSonuc.Text = (Math.Exp(Double.Parse(txtSonuc.Text))).ToString(); break;
                case "n!":
                    for (int i = 1; i <= Double.Parse(txtSonuc.Text) - 1; i++)
                    {
                        sonuc *= i;
                    }
                    txtSonuc.Text = (sonuc).ToString();
                    break;
                default: break;
                case "+,-": txtSonuc.Text = (Double.Parse("-") * Double.Parse(txtSonuc.Text)).ToString(); break; 
            }
            sonuc = Double.Parse(txtSonuc.Text);
            
            txtSonuc.Text = sonuc.ToString();
            sonuc = 0; //atama yaptıktan sonra belleği boşaltıyor.
            opt = "";


        }

        private void bNotkta_Click(object sender, EventArgs e) // Ondalık ekleniyor
        {
             if(txtSonuc.Text== "0")
             {
                 txtSonuc.Text = "0";
             }
             else if(optDurum)
            {
                txtSonuc.Text = "0";
            }

            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }

            optDurum = false;

        }

        private void bSil_Click(object sender, EventArgs e) // string' in son elemanı siliniyor
        {
            int temp = txtSonuc.Text.Length;
            txtSonuc.Text = txtSonuc.Text.Substring(0, temp-1);
        }
    }
}
