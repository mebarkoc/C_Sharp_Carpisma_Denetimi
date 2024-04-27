/****************************************************************************
**					           SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA ÖDEVİ
**	
**				ÖDEV NUMARASI…............: 2023-2024 Bahar Dönemi İkinci Ödev
**				ÖĞRENCİ ADI...............: Muhammed Emin BARKOÇ
**				ÖĞRENCİ NUMARASI..........: G231210452
**				DERS GRUBU…………............: İkinci Öğretim A Grubu
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödeviki
{
    public partial class Form1 : Form
    {
        public int carpDenetComboBoxIndex;

        public void carpDenetCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carpDenetComboBoxIndex = carpDenetCombobox.SelectedIndex;

            void noktaBirdeAktif()
            {
                secilenBirDegisen.Text = "Nokta";
                yaricapBirDegisen.Enabled = false;
                yukseklikBirDegisen.Enabled = false;
                kenarlarBirBirDegisen.Enabled = false;
                kenarlarBirIkiDegisen.Enabled = false;
                kenarlarBirUcDegisen.Enabled = false;
                kenarlarBirDortDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
                zBirDegisen.Enabled = true;
            }

            void dörtgenBirdeAktif()
            {
                secilenIkiDegisen.Text = "Dörtgen";
                yaricapIkiDegisen.Enabled = false;
                yukseklikIkiDegisen.Enabled = false;
                kenarlarIkiBirDegisen.Enabled = true;
                kenarlarIkiIkiDegisen.Enabled = true;
                kenarlarIkiUcDegisen.Enabled = true;
                kenarlarIkiDortDegisen.Enabled = true;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
                zIkiDegisen.Enabled = true;
            }

            void cemberBirdeAktif()
            {
                secilenBirDegisen.Text = "Çember";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = false;
                kenarlarBirBirDegisen.Enabled = false;
                kenarlarBirIkiDegisen.Enabled = false;
                kenarlarBirUcDegisen.Enabled = false;
                kenarlarBirDortDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
                zBirDegisen.Enabled = true;
            }

            void cemberIkideAktif()
            {
                secilenIkiDegisen.Text = "Çember";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = false;
                kenarlarIkiBirDegisen.Enabled = false;
                kenarlarIkiIkiDegisen.Enabled = false;
                kenarlarIkiUcDegisen.Enabled = false;
                kenarlarIkiDortDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
                zIkiDegisen.Enabled = true;
            }

            void dikdortgenPrizmaBirdeAktif()
            {
                secilenBirDegisen.Text = "Dikdörtgen Prizma";
                yaricapBirDegisen.Enabled = false;
                yukseklikBirDegisen.Enabled = true;
                kenarlarBirBirDegisen.Enabled = true;
                kenarlarBirIkiDegisen.Enabled = true;
                kenarlarBirUcDegisen.Enabled = false;
                kenarlarBirDortDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
                zBirDegisen.Enabled = true;
            }

            void dikdortgenPrizmaIkideAktif()
            {
                secilenIkiDegisen.Text = "Dikdörtgen Prizma";
                yaricapIkiDegisen.Enabled = false;
                yukseklikIkiDegisen.Enabled = true;
                kenarlarIkiBirDegisen.Enabled = true;
                kenarlarIkiIkiDegisen.Enabled = true;
                kenarlarIkiUcDegisen.Enabled = false;
                kenarlarIkiDortDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
                zIkiDegisen.Enabled = true;
            }

            void kureBirdeAktif()
            {
                secilenBirDegisen.Text = "Küre";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = false;
                kenarlarBirBirDegisen.Enabled = false;
                kenarlarBirIkiDegisen.Enabled = false;
                kenarlarBirUcDegisen.Enabled = false;
                kenarlarBirDortDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
                zBirDegisen.Enabled = true;
            }

            void kureIkideAktif()
            {
                secilenIkiDegisen.Text = "Küre";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = false;
                kenarlarIkiBirDegisen.Enabled = false;
                kenarlarIkiIkiDegisen.Enabled = false;
                kenarlarIkiUcDegisen.Enabled = false;
                kenarlarIkiDortDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
                zIkiDegisen.Enabled = true;

            }

            void silindirBirdeAktif()
            {
                secilenBirDegisen.Text = "Silindir";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = true;
                kenarlarBirBirDegisen.Enabled = false;
                kenarlarBirIkiDegisen.Enabled = false;
                kenarlarBirUcDegisen.Enabled = false;
                kenarlarBirDortDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
                zBirDegisen.Enabled = true;
            }

            void silindirIkideAktif()
            {
                secilenIkiDegisen.Text = "Silindir";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = true;
                kenarlarIkiBirDegisen.Enabled = false;
                kenarlarIkiIkiDegisen.Enabled = false;
                kenarlarIkiUcDegisen.Enabled = false;
                kenarlarIkiDortDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
                zIkiDegisen.Enabled = true;
            }


            switch (carpDenetComboBoxIndex)
            {
                

                case 0:
       
                    noktaBirdeAktif();

                    dörtgenBirdeAktif();
                    

                    break;

                case 1:

                    noktaBirdeAktif();

                    cemberIkideAktif();

                    break;

                case 2:

                    dikdortgenPrizmaBirdeAktif();

                    dikdortgenPrizmaIkideAktif();

                    break;

                case 3:

                    dikdortgenPrizmaBirdeAktif();

                    cemberIkideAktif();
                    break;

                case 4:

                    cemberBirdeAktif();

                    cemberIkideAktif();
                    break;

                case 5:
                    
                    noktaBirdeAktif();

                    kureIkideAktif();

                    break;

                case 6:
                    
                    noktaBirdeAktif();

                    dikdortgenPrizmaIkideAktif();
                    
                    break;

                case 7:

                    noktaBirdeAktif();

                    silindirIkideAktif();

                    break;

                case 8:

                    silindirBirdeAktif();

                    silindirIkideAktif();
                    
                    break;

                case 9:

                    kureBirdeAktif();

                    kureIkideAktif();

                    break;

                case 10:

                    kureBirdeAktif();

                    silindirIkideAktif();

                    break;

                case 11:
                    secilenBirDegisen.Text = "Yüzey";
                    kureIkideAktif();
                    break;

                case 12:
                    secilenBirDegisen.Text = "Yüzey";
                    dikdortgenPrizmaIkideAktif();
                    break;

                case 13:
                    secilenBirDegisen.Text = "Yüzey";
                    silindirIkideAktif();
                    break;

                case 14:
                    kureBirdeAktif();
                    dikdortgenPrizmaIkideAktif();
                    break;

                case 15:
                    dikdortgenPrizmaBirdeAktif();
                    dikdortgenPrizmaIkideAktif();
                    break;

            }
        }



        public Form1()
        {   
            InitializeComponent();
        }
   
        private void butonCalistir_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();

            int seciliCarpDenetComboBoxIndex = carpDenetCombobox.SelectedIndex;

            int pictureBoxOrijinX = pictureBox1.Width  / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;

            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xBirDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yBirDegisen.Text);
            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);


            switch (seciliCarpDenetComboBoxIndex)
            {
                case 0:
                    
                    // Birinci şekil Nokta
                    Nokta nokta = new Nokta(Convert.ToInt32(koordinatBirX), Convert.ToInt32(koordinatBirY));
                    Graphics gNokta = pictureBox1.CreateGraphics();
                    gNokta.FillEllipse(Brushes.Black, nokta.X - 2, nokta.Y - 2, 5, 5);


                    // İkinci şekil Dörtgen
                    int dortgenMerkeziX = koordinatIkiX - Convert.ToInt32(xIkiDegisen.Text) / 2;
                    int dortgenMerkeziY = koordinatIkiY - Convert.ToInt32(yIkiDegisen.Text) / 2;

                    
                    

                    Dortgen dortgen = new Dortgen(dortgenMerkeziX, dortgenMerkeziY, Convert.ToInt32(kenarlarIkiBirDegisen.Text), Convert.ToInt32(kenarlarIkiIkiDegisen.Text));

                    dortgen.SolUstKose.X = dortgenMerkeziX - Convert.ToInt32(kenarlarIkiBirDegisen.Text) / 2;
                    dortgen.SolUstKose.Y = dortgenMerkeziY - Convert.ToInt32(kenarlarIkiIkiDegisen.Text) / 2;


                    Graphics gDortgen = pictureBox1.CreateGraphics();
                    gDortgen.DrawRectangle(Pens.Red, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.Genislik, dortgen.Yuksekik);


                    break;
            }




            


        }







        private void Form1_Load(object sender, EventArgs e)
        {
            butonCalistir.Enabled = true;

            yaricapBirDegisen.Enabled = false;
            yukseklikBirDegisen.Enabled = false;
            kenarlarBirBirDegisen.Enabled = false;
            kenarlarBirIkiDegisen.Enabled = false;
            kenarlarBirUcDegisen.Enabled = false;
            kenarlarBirDortDegisen.Enabled = false;
            xBirDegisen.Enabled = false;
            yBirDegisen.Enabled = false;
            zBirDegisen.Enabled = false;


            yaricapIkiDegisen.Enabled = false;
            yukseklikIkiDegisen.Enabled = false;
            kenarlarIkiBirDegisen.Enabled = false;
            kenarlarIkiIkiDegisen.Enabled = false;
            kenarlarIkiUcDegisen.Enabled = false;
            kenarlarIkiDortDegisen.Enabled = false;
            xIkiDegisen.Enabled = false;
            yIkiDegisen.Enabled = false;
            zIkiDegisen.Enabled = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.FromArgb(100, Color.Gray)); // Gri renkte, %40 saydamlıkta bir kalem
            SolidBrush fırca = new SolidBrush(Color.FromArgb(100, Color.Gray)); // Gri renkte, %40 saydamlıkta bir fırça

            // Picturebox'ın boyutları
            int pbGenislik = pictureBox1.Width;
            int pbYukseklik = pictureBox1.Height;

            // Picturebox'ın merkez koordinatları
            int pbMerkezX = pbGenislik / 2;
            int pbMerkezY = pbYukseklik / 2;


            // Yatay ekseni çiz
            e.Graphics.DrawLine(kalem, 0, pbMerkezY, pbGenislik, pbMerkezY);
            // Dikey ekseni çiz
            e.Graphics.DrawLine(kalem, pbMerkezX, 0, pbMerkezX, pbYukseklik);

            // Yatay eksende kılavuz çizgileri
            for (int i = 0; i < pbGenislik; i += 10)
                e.Graphics.DrawLine(kalem, i, pbMerkezY - 2, i, pbMerkezY + 2);

            // Dikey eksende kılavuz çizgileri
            for (int i = 0; i < pbYukseklik; i += 10)
                e.Graphics.DrawLine(kalem, pbMerkezX - 2, i, pbMerkezX + 2, i);

            // Orta noktayı gösteren kare çiz
            e.Graphics.FillRectangle(fırca, pbMerkezX - 2, pbMerkezY - 2, 5, 5);

            // Kullanılan nesneleri temizle
            kalem.Dispose();
            fırca.Dispose();
        }
    }
}
