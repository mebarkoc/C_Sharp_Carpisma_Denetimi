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

            void noktaAktif()
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

            void dörtgenAktif()
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


            switch (carpDenetComboBoxIndex)
            {
                

                case 0:
                    
                    noktaAktif();

                    dörtgenAktif();
                    

                    break;

                case 1:
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

                    secilenIkiDegisen.Text = "Çember";
                    yaricapIkiDegisen.Enabled = true;
                    yukseklikBirDegisen.Enabled = false;
                    kenarlarBirBirDegisen.Enabled = false;
                    kenarlarBirIkiDegisen.Enabled = false;
                    kenarlarBirUcDegisen.Enabled = false;
                    kenarlarBirDortDegisen.Enabled = false;
                    xBirDegisen.Enabled = true;
                    yBirDegisen.Enabled = true;
                    zBirDegisen.Enabled = true;

                    break;

                case 2:
                    secilenBirDegisen.Text = "Dikdörtgen Prizma";
                    secilenIkiDegisen.Text = "Dikdörtgen Prizma";
                    break;

                case 3:
                    secilenBirDegisen.Text = "Dikdörtgen Prizma";
                    secilenIkiDegisen.Text = "Çember";
                    break;

                case 4:
                    secilenBirDegisen.Text = "Çember";
                    secilenIkiDegisen.Text = "Çember";
                    break;

                case 5:
                    secilenBirDegisen.Text = "Nokta";
                    secilenIkiDegisen.Text = "Küre";
                    break;

                case 6:
                    secilenBirDegisen.Text = "Nokta";
                    secilenIkiDegisen.Text = "Dikdörtgen Prizma";
                    break;

                case 7:
                    secilenBirDegisen.Text = "Nokta";
                    secilenIkiDegisen.Text = "Silindir";
                    break;

                case 8:
                    secilenBirDegisen.Text = "Silindir";
                    secilenIkiDegisen.Text = "Silindir";
                    break;

                case 9:
                    secilenBirDegisen.Text = "Küre";
                    secilenIkiDegisen.Text = "Küre";
                    break;

                case 10:
                    secilenBirDegisen.Text = "Küre";
                    secilenIkiDegisen.Text = "Silindir";
                    break;

                case 11:
                    secilenBirDegisen.Text = "Yüzey";
                    secilenIkiDegisen.Text = "Küre";
                    break;

                case 12:
                    secilenBirDegisen.Text = "Yüzey";
                    secilenIkiDegisen.Text = "Dikdörtgen Prizması";
                    break;

                case 13:
                    secilenBirDegisen.Text = "Yüzey";
                    secilenIkiDegisen.Text = "Silindir";
                    break;

                case 14:
                    secilenBirDegisen.Text = "Yüzey";
                    secilenIkiDegisen.Text = "Küre";
                    break;

                case 15:
                    secilenBirDegisen.Text = "Küre";
                    secilenIkiDegisen.Text = "Dikdörtgen Prizması";
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
