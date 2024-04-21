/****************************************************************************
**					           SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				          NESNEYE DAYALI PROGRAMLAMA ÖDEVİ
**	
**				ÖDEV NUMARASI…............:
**				ÖĞRENCİ ADI...............: Muhammed Emin BARKOÇ
**				ÖĞRENCİ NUMARASI..........: G
**				DERS GRUBU…………............:
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butonCalistir.Enabled = false;

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
    }
}
