﻿/****************************************************************************
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
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
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

            yaricapBirDegisen.Clear();
            yukseklikBirDegisen.Clear();
            genislikBirDegisen.Clear();
            derinlikBirDegisen.Clear();
            xBirDegisen.Clear();
            yBirDegisen.Clear();
            xIkiDegisen.Clear();
            yIkiDegisen.Clear();
            yaricapIkiDegisen.Clear();
            yukseklikIkiDegisen.Clear();
            genislikIkiDegisen.Clear();
            derinlikIkiDegisen.Clear();

            void noktaBirdeAktif()
            {
                secilenBirDegisen.Text = "Nokta";
                yaricapBirDegisen.Enabled = false;
                yukseklikBirDegisen.Enabled = false;
                genislikBirDegisen.Enabled = false;
                derinlikBirDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
            }

            void dortgenBirdeAktif()
            {
                secilenIkiDegisen.Text = "Dörtgen";
                yaricapIkiDegisen.Enabled = false;
                yukseklikIkiDegisen.Enabled = true;
                genislikIkiDegisen.Enabled = true;
                derinlikIkiDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
            }

            void cemberBirdeAktif()
            {
                secilenBirDegisen.Text = "Çember";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = false;
                genislikBirDegisen.Enabled = false;
                derinlikBirDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
            }

            void cemberIkideAktif()
            {
                secilenIkiDegisen.Text = "Çember";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = false;
                genislikIkiDegisen.Enabled = false;
                derinlikIkiDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
            }

            void dikdortgenPrizmaBirdeAktif()
            {
                secilenBirDegisen.Text = "Dikdörtgen Prizma";
                yaricapBirDegisen.Enabled = false;
                yukseklikBirDegisen.Enabled = true;
                genislikBirDegisen.Enabled = true;
                derinlikBirDegisen.Enabled = true;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
            }

            void dikdortgenPrizmaIkideAktif()
            {
                secilenIkiDegisen.Text = "Dikdörtgen Prizma";
                yaricapIkiDegisen.Enabled = false;
                yukseklikIkiDegisen.Enabled = true;
                genislikIkiDegisen.Enabled = true;
                derinlikIkiDegisen.Enabled = true;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
            }

            void kureBirdeAktif()
            {
                secilenBirDegisen.Text = "Küre";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = false;
                genislikBirDegisen.Enabled = false;
                derinlikBirDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
            }

            void kureIkideAktif()
            {
                secilenIkiDegisen.Text = "Küre";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = false;
                genislikIkiDegisen.Enabled = false;
                derinlikIkiDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;

            }

            void silindirBirdeAktif()
            {
                secilenBirDegisen.Text = "Silindir";
                yaricapBirDegisen.Enabled = true;
                yukseklikBirDegisen.Enabled = true;
                genislikBirDegisen.Enabled = false;
                derinlikBirDegisen.Enabled = false;
                xBirDegisen.Enabled = true;
                yBirDegisen.Enabled = true;
            }

            void silindirIkideAktif()
            {
                secilenIkiDegisen.Text = "Silindir";
                yaricapIkiDegisen.Enabled = true;
                yukseklikIkiDegisen.Enabled = true;
                genislikIkiDegisen.Enabled = false;
                derinlikIkiDegisen.Enabled = false;
                xIkiDegisen.Enabled = true;
                yIkiDegisen.Enabled = true;
            }


            switch (carpDenetComboBoxIndex)
            {
                

                case 0:
       
                    noktaBirdeAktif();

                    dortgenBirdeAktif();
                    

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
                    kureBirdeAktif();
                    dikdortgenPrizmaIkideAktif();
                    break;
            }
        }

        public Form1()
        {   
            InitializeComponent();
        
            

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        
        public Nokta noktaBireCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;

            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xBirDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yBirDegisen.Text);

            Nokta nokta = new Nokta(koordinatBirX, koordinatBirY);
            Graphics gNokta = pictureBox1.CreateGraphics();
            gNokta.FillEllipse(Brushes.Blue, nokta.X - 2, nokta.Y - 2, 5, 5);
            return nokta ;
        }
        public Dortgen dortgenIkiyeCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;

            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);

            
            Dortgen dortgen = new Dortgen(koordinatIkiX, koordinatIkiY, Convert.ToInt32(genislikIkiDegisen.Text), Convert.ToInt32(yukseklikIkiDegisen.Text));
            
            dortgen.SolUstKose.X = koordinatIkiX - Convert.ToInt32(genislikIkiDegisen.Text) / 2;
            dortgen.SolUstKose.Y = koordinatIkiY - Convert.ToInt32(yukseklikIkiDegisen.Text) / 2;
            Graphics gDortgen = pictureBox1.CreateGraphics();
            gDortgen.DrawRectangle(Pens.Red, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.Genislik, dortgen.Yukseklik);

            return dortgen;
        }
        public Cember cemberBireCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);
            int cemberYaricap = Convert.ToInt32(yaricapIkiDegisen.Text);

            Cember cember = new Cember(koordinatBirX, koordinatBirY, cemberYaricap);
            Graphics gCember = pictureBox1.CreateGraphics();
            cember.SolUstNokta.X = koordinatBirX - cemberYaricap;
            cember.SolUstNokta.Y = koordinatBirY - cemberYaricap;
            gCember.DrawEllipse(Pens.Red, cember.SolUstNokta.X, cember.SolUstNokta.Y, cember.YariCap * 2, cember.YariCap * 2);

            return cember;
        }
        public Cember cemberIkiyeCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);
            int cemberYaricap = Convert.ToInt32(yaricapIkiDegisen.Text);

            Cember cember = new Cember(koordinatIkiX,koordinatIkiY,cemberYaricap);
            Graphics gCember = pictureBox1.CreateGraphics();
            cember.SolUstNokta.X = koordinatIkiX - cemberYaricap;
            cember.SolUstNokta.Y = koordinatIkiY - cemberYaricap;
            gCember.DrawEllipse(Pens.Red, cember.SolUstNokta.X, cember.SolUstNokta.Y, cember.YariCap*2, cember.YariCap*2);

            return cember;
        }
        public DıkdortgenPrizma dıkdortgenBireCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xBirDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yBirDegisen.Text);

            Dortgen dortgen = new Dortgen(koordinatBirX, koordinatBirY, Convert.ToInt32(genislikBirDegisen.Text), Convert.ToInt32(yukseklikBirDegisen.Text));
            DıkdortgenPrizma dıkdortgenPrizma = new DıkdortgenPrizma(dortgen, Convert.ToInt32(yukseklikBirDegisen.Text));
            dortgen.SolUstKose.X = koordinatBirX - Convert.ToInt32(genislikBirDegisen.Text) + Convert.ToInt32(genislikBirDegisen.Text) / 6;
            dortgen.SolUstKose.Y = koordinatBirY - Convert.ToInt32(yukseklikBirDegisen.Text) / 6;
            Graphics gDıkdortgenPrizma = pictureBox1.CreateGraphics();
           
            gDıkdortgenPrizma.DrawRectangle(Pens.Blue, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.Genislik, dortgen.Yukseklik);

            double derinlikReferans = Convert.ToInt32(derinlikBirDegisen.Text) / Math.Sqrt(2);
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + dortgen.Genislik, dortgen.SolUstKose.Y, dortgen.SolUstKose.X + dortgen.Genislik + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X, dortgen.SolUstKose.Y + dortgen.Yukseklik, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans) + dortgen.Yukseklik);
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + dortgen.Genislik + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Blue, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y -  Convert.ToSingle(derinlikReferans));

            return dıkdortgenPrizma;
        }
        public DıkdortgenPrizma dıkdortgenIkideCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);

            Dortgen dortgen = new Dortgen(koordinatIkiX, koordinatIkiY, Convert.ToInt32(genislikIkiDegisen.Text), Convert.ToInt32(yukseklikIkiDegisen.Text));
            DıkdortgenPrizma dıkdortgenPrizma = new DıkdortgenPrizma(dortgen, Convert.ToInt32(yukseklikIkiDegisen.Text));
            dortgen.SolUstKose.X = koordinatIkiX - Convert.ToInt32(genislikIkiDegisen.Text)  + Convert.ToInt32(genislikIkiDegisen.Text) / 6;
            dortgen.SolUstKose.Y = koordinatIkiY - Convert.ToInt32(yukseklikIkiDegisen.Text) / 6;
            Graphics gDıkdortgenPrizma = pictureBox1.CreateGraphics();
            gDıkdortgenPrizma.DrawRectangle(Pens.Red, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.Genislik, dortgen.Yukseklik);

            double derinlikReferans = Convert.ToInt32(derinlikIkiDegisen.Text) / Math.Sqrt(2);
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X, dortgen.SolUstKose.Y, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + dortgen.Genislik, dortgen.SolUstKose.Y, dortgen.SolUstKose.X + dortgen.Genislik + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X, dortgen.SolUstKose.Y + dortgen.Yukseklik, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans) + dortgen.Yukseklik);
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + dortgen.Genislik + Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans));
            gDıkdortgenPrizma.DrawLine(Pens.Red, dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y + dortgen.Yukseklik - Convert.ToSingle(derinlikReferans), dortgen.SolUstKose.X + Convert.ToSingle(derinlikReferans) + dortgen.Genislik, dortgen.SolUstKose.Y - Convert.ToSingle(derinlikReferans));
       
            return dıkdortgenPrizma;
        }
        public void kureBireCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xBirDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yBirDegisen.Text);
            int kureYaricap = Convert.ToInt32(yaricapBirDegisen.Text);

            Kure kure = new Kure(koordinatBirX, koordinatBirY, kureYaricap);
            kure.SolUstNokta.X = koordinatBirX - kureYaricap;
            kure.SolUstNokta.Y = koordinatBirY - kureYaricap;
            Graphics gKure = pictureBox1.CreateGraphics();
            gKure.DrawEllipse(Pens.Blue, kure.SolUstNokta.X, kure.SolUstNokta.Y, kureYaricap * 2, kureYaricap * 2);
            gKure.DrawEllipse(Pens.Blue, kure.SolUstNokta.X + kureYaricap / 2, kure.SolUstNokta.Y, kureYaricap, kureYaricap * 2);
            gKure.DrawEllipse(Pens.Blue, kure.SolUstNokta.X, kure.SolUstNokta.Y + kureYaricap / 2, kureYaricap * 2, kureYaricap);
        }
        public void kureIkiyeCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);
            int kureYaricap = Convert.ToInt32(yaricapIkiDegisen.Text);

            Kure kure = new Kure(koordinatIkiX, koordinatIkiY, kureYaricap);
            kure.SolUstNokta.X = koordinatIkiX - kureYaricap;
            kure.SolUstNokta.Y = koordinatIkiY - kureYaricap;
            Graphics gKure = pictureBox1.CreateGraphics();
            gKure.DrawEllipse(Pens.Red, kure.SolUstNokta.X, kure.SolUstNokta.Y, kureYaricap * 2, kureYaricap * 2);
            gKure.DrawEllipse(Pens.Red, kure.SolUstNokta.X + kureYaricap/2, kure.SolUstNokta.Y, kureYaricap, kureYaricap * 2);
            gKure.DrawEllipse(Pens.Red, kure.SolUstNokta.X, kure.SolUstNokta.Y + kureYaricap/2, kureYaricap * 2, kureYaricap);
        }
        public void silindirBireCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatBirX = pictureBoxOrijinX + Convert.ToInt32(xBirDegisen.Text);
            int koordinatBirY = pictureBoxOrijinY - Convert.ToInt32(yBirDegisen.Text);
            int silindirYaricap = Convert.ToInt32(yaricapBirDegisen.Text);
            int silindirYukseklik = Convert.ToInt32(yukseklikBirDegisen.Text);

            Cember tabanCember = new Cember(koordinatBirX, koordinatBirY, silindirYaricap * 2);

            Silindir silindir = new Silindir(tabanCember, silindirYukseklik);

            tabanCember.SolUstNokta.X = koordinatBirX - silindirYaricap;
            tabanCember.SolUstNokta.Y = koordinatBirY - silindirYaricap;


            Graphics gSilindir = pictureBox1.CreateGraphics();
            gSilindir.DrawEllipse(Pens.Blue, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y, silindirYaricap * 2, silindirYaricap * 2);
            gSilindir.DrawEllipse(Pens.Blue, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y - silindir.Yukseklik, silindirYaricap * 2, silindirYaricap * 2);
            gSilindir.DrawLine(Pens.Blue, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y + silindirYaricap, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y - silindirYukseklik + silindirYaricap);
            gSilindir.DrawLine(Pens.Blue, tabanCember.SolUstNokta.X + silindirYaricap * 2, tabanCember.SolUstNokta.Y + silindirYaricap, tabanCember.SolUstNokta.X + silindirYaricap * 2, tabanCember.SolUstNokta.Y + silindirYaricap - silindirYukseklik);
        }
        public void silindirIkiyeCiz()
        {
            int pictureBoxOrijinX = pictureBox1.Width / 2;
            int pictureBoxOrijinY = pictureBox1.Height / 2;
            int koordinatIkiX = pictureBoxOrijinX + Convert.ToInt32(xIkiDegisen.Text);
            int koordinatIkiY = pictureBoxOrijinY - Convert.ToInt32(yIkiDegisen.Text);
            int silindirYaricap = Convert.ToInt32(yaricapIkiDegisen.Text);
            int silindirYukseklik = Convert.ToInt32(yukseklikIkiDegisen.Text);

            Cember tabanCember = new Cember(koordinatIkiX, koordinatIkiY, silindirYaricap * 2);

            Silindir silindir = new Silindir(tabanCember, silindirYukseklik);

            tabanCember.SolUstNokta.X = koordinatIkiX - silindirYaricap;
            tabanCember.SolUstNokta.Y = koordinatIkiY - silindirYaricap;


            Graphics gSilindir = pictureBox1.CreateGraphics();
            gSilindir.DrawEllipse(Pens.Red, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y, silindirYaricap * 2, silindirYaricap * 2);
            gSilindir.DrawEllipse(Pens.Red, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y - silindir.Yukseklik, silindirYaricap * 2, silindirYaricap * 2);
            gSilindir.DrawLine(Pens.Red, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y + silindirYaricap, tabanCember.SolUstNokta.X, tabanCember.SolUstNokta.Y - silindirYukseklik + silindirYaricap);
            gSilindir.DrawLine(Pens.Red, tabanCember.SolUstNokta.X + silindirYaricap * 2, tabanCember.SolUstNokta.Y + silindirYaricap, tabanCember.SolUstNokta.X + silindirYaricap * 2, tabanCember.SolUstNokta.Y + silindirYaricap - silindirYukseklik);
        }

        private void butonCalistir_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            
            int seciliCarpDenetComboBoxIndex = carpDenetCombobox.SelectedIndex;

            switch (seciliCarpDenetComboBoxIndex)
            {

                case 0:
                    Nokta noktaBir = new Nokta(noktaBireCiz().X, noktaBireCiz().Y);
                    Dortgen dortgenIki = new Dortgen(dortgenIkiyeCiz().SolUstKose.X, dortgenIkiyeCiz().SolUstKose.Y, dortgenIkiyeCiz().Genislik, dortgenIkiyeCiz().Yukseklik);


                    noktaBireCiz();
                    dortgenIkiyeCiz();
                    Carpisma.noktaDortgenCarpismaVarMi(noktaBir, dortgenIki);

                    if (Carpisma.noktaDortgenCarpismaVarMi(noktaBir, dortgenIki) == true)
                    {
                        carpismaVarBaslik.ForeColor = Color.Black;
                        carpismaYokBaslik.ForeColor = Color.Gray;
                    }
                    else
                    {
                        carpismaYokBaslik.ForeColor = Color.Black;   
                        carpismaVarBaslik.ForeColor = Color.Gray;    
                    }

                    break; // nokta ile dörtgen çizer ve çarpışma denetimini yapar.

                case 1:
                    Cember cemberIki = new Cember(cemberIkiyeCiz().SolUstNokta.X, cemberIkiyeCiz().SolUstNokta.Y, cemberIkiyeCiz().YariCap);
                    Nokta noktaBirCaseBir = new Nokta(noktaBireCiz().X, noktaBireCiz().Y);

                    noktaBireCiz();
                    cemberIkiyeCiz();
                    Carpisma.noktaCemberCarpismaVarMi(noktaBirCaseBir, cemberIki);

                    if (Carpisma.noktaCemberCarpismaVarMi(noktaBirCaseBir, cemberIki) == true)
                    {
                        carpismaVarBaslik.ForeColor = Color.Black;
                        carpismaYokBaslik.ForeColor = Color.Gray;
                    }
                    else
                    {
                        carpismaYokBaslik.ForeColor = Color.Black;
                        carpismaVarBaslik.ForeColor = Color.Gray;
                    }

                    break; // nokta ile çember çizer ve çarpışma denetimi yapar. 

                case 2:
                    DıkdortgenPrizma dikdortgenBir = new DıkdortgenPrizma(dıkdortgenBireCiz().Taban, dıkdortgenBireCiz().Yukseklik);
                    DıkdortgenPrizma dikdortgenIki = new DıkdortgenPrizma(dıkdortgenIkideCiz().Taban, dıkdortgenIkideCiz().Yukseklik);

                    dıkdortgenBireCiz();
                    dıkdortgenIkideCiz();
                    Carpisma.dikdortgenDikdortgenCarpismaVarMi(dikdortgenBir, dikdortgenIki);

                    

                    if (Carpisma.dikdortgenDikdortgenCarpismaVarMi(dikdortgenBir, dikdortgenIki))
                    {
                        carpismaVarBaslik.ForeColor = Color.Black;
                        carpismaYokBaslik.ForeColor = Color.Gray;
                    }
                    else
                    {
                        carpismaYokBaslik.ForeColor = Color.Black;
                        carpismaVarBaslik.ForeColor = Color.Gray;
                    }

                    break; // dikdörtgen ile dikdörtgen çizer ve çarpışma denetimi yapar.

                case 3:
                    DıkdortgenPrizma dikdortgen = new DıkdortgenPrizma(dıkdortgenBireCiz().Taban, dıkdortgenBireCiz().Yukseklik);
                    Cember cember = new Cember(cemberIkiyeCiz().SolUstNokta.X, cemberIkiyeCiz().SolUstNokta.Y, cemberIkiyeCiz().YariCap);

                    dıkdortgenBireCiz();
                    cemberIkiyeCiz();
                    Carpisma.dikdortgenCemberCarpismaVarMi(dikdortgen, cember);

                    if (Carpisma.dikdortgenCemberCarpismaVarMi(dikdortgen, cember))
                    {
                        carpismaVarBaslik.ForeColor = Color.Black;
                        carpismaYokBaslik.ForeColor = Color.Gray;
                    }
                    else
                    {
                        carpismaYokBaslik.ForeColor = Color.Black;
                        carpismaVarBaslik.ForeColor = Color.Gray;
                    }

                    break; // dikdörtgen ile cember çizer ve çarpışma denetimi yapar.

                case 4:
                    Cember cember1 = new Cember(cemberBireCiz().SolUstNokta.X, cemberBireCiz().SolUstNokta.Y, cemberBireCiz().YariCap);
                    Cember cember2 = new Cember(cemberIkiyeCiz().SolUstNokta.X, cemberIkiyeCiz().SolUstNokta.Y, cemberIkiyeCiz().YariCap);
                    cemberBireCiz();
                    cemberIkiyeCiz();

                    if (Carpisma.cemberCemberCarpismaVarMi(cember1, cember2))
                    {
                        carpismaVarBaslik.ForeColor = Color.Black;
                        carpismaYokBaslik.ForeColor = Color.Gray;
                    }
                    else
                    {
                        carpismaYokBaslik.ForeColor = Color.Black;
                        carpismaVarBaslik.ForeColor = Color.Gray;
                    }
                    break; // çember ile çember çizer ve çarpışma denetimi yapar.

                case 5:
                    noktaBireCiz();
                    kureIkiyeCiz();
                    break;

                case 6:
                    noktaBireCiz();
                    dıkdortgenIkideCiz();
                    break;

                case 7:
                    noktaBireCiz();
                    silindirIkiyeCiz();
                    break;

                case 8:
                    silindirBireCiz();
                    silindirIkiyeCiz();
                    break;

                case 9:
                    kureBireCiz();
                    kureIkiyeCiz();
                    break;

                case 10:
                    kureBireCiz();
                    silindirIkiyeCiz();
                    break;

                case 11:
                    kureBireCiz();
                    dıkdortgenIkideCiz();
                    break;
            }
        }

        public  class Carpisma
        {
            public static bool noktaDortgenCarpismaVarMi(Nokta nokta, Dortgen dortgen)
            {

                if (nokta != null && dortgen != null)
                {
                    int dortgenMerkezX = dortgen.SolUstKose.X + dortgen.Genislik  / 2;
                    int dortgenMerkezY = dortgen.SolUstKose.Y + dortgen.Yukseklik / 2;
                    
                    if (Math.Abs( dortgenMerkezX - nokta.X) <= dortgen.Genislik /2 && Math.Abs(dortgenMerkezY - nokta.Y) <= dortgen.Yukseklik / 2 )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }

            public static bool noktaCemberCarpismaVarMi(Nokta nokta, Cember cember)
            {
                if (nokta != null && cember != null)
                {
                    int cemberMerkeziX = cember.SolUstNokta.X + cember.YariCap;
                    int cemberMerkeziY = cember.SolUstNokta.Y + cember.YariCap;

                    if (Math.Abs( cemberMerkeziX - nokta.X) <= cember.YariCap && Math.Abs(cemberMerkeziY - nokta.Y) <= cember.YariCap)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }

            public static bool dikdortgenDikdortgenCarpismaVarMi(DıkdortgenPrizma dikdortgen1, DıkdortgenPrizma dikdortgen2)
            {
                if (dikdortgen1 != null && dikdortgen2 != null)
                {
                    int dikdortgenBirMerkezX = dikdortgen1.Taban.SolUstKose.X + dikdortgen1.Taban.Genislik - dikdortgen1.Taban.Genislik / 6;
                    int dikdortgenBirMerkezY = dikdortgen1.Taban.SolUstKose.Y + dikdortgen1.Taban.SolUstKose.Y / 6;

                    int dikdortgenIkiMerkezX = dikdortgen2.Taban.SolUstKose.X + dikdortgen2.Taban.Genislik - dikdortgen2.Taban.Genislik / 6;
                    int dikdortgenIkiMerkezY = dikdortgen2.Taban.SolUstKose.Y + dikdortgen2.Taban.SolUstKose.Y / 6;

                    if (
                        Math.Abs(dikdortgen1.Taban.SolUstKose.X - dikdortgen2.Taban.SolUstKose.X) 
                        <= 
                        Math.Abs(dikdortgen1.Taban.Genislik - dikdortgen2.Taban.Genislik)
                        && 
                        Math.Abs(dikdortgen1.Taban.SolUstKose.Y - dikdortgen2.Taban.SolUstKose.Y)
                        <=
                        Math.Abs(dikdortgen1.Taban.Yukseklik - dikdortgen2.Taban.Yukseklik)
                       )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }  
                }

                return false;
            }

            public static bool dikdortgenCemberCarpismaVarMi(DıkdortgenPrizma dikdortgen, Cember cember)
            {
                int dikdortgenBirMerkezXCase3 = dikdortgen.Taban.SolUstKose.X + dikdortgen.Taban.Genislik - dikdortgen.Taban.Genislik / 6;
                int dikdortgenBirMerkezYCase3 = dikdortgen.Taban.SolUstKose.Y + dikdortgen.Taban.SolUstKose.Y / 6;

                int cemberMerkeziXCase3 = cember.SolUstNokta.X + cember.YariCap;
                int cemberMerkeziYCase3 = cember.SolUstNokta.Y + cember.YariCap;

                if (dikdortgen != null && cember != null)
                {
                    if (
                        Math.Abs(dikdortgenBirMerkezXCase3 - cemberMerkeziXCase3)
                        <=
                        Math.Abs((dikdortgen.Taban.Genislik - dikdortgen.Taban.Genislik / 6) + cember.YariCap)
                        &&
                        Math.Abs(dikdortgenBirMerkezYCase3 - cemberMerkeziYCase3)
                        <=
                        Math.Abs(dikdortgen.Taban.Yukseklik - dikdortgen.Taban.Yukseklik / 6) + cember.YariCap
                        )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }

            public static bool cemberCemberCarpismaVarMi(Cember cember1, Cember cember2)
            {
                int cember1MerkezX = cember1.SolUstNokta.X + cember1.YariCap;
                int cember1MerkezY = cember1.SolUstNokta.Y + cember1.YariCap;

                int cember2MerkezX = cember1.SolUstNokta.X + cember1.YariCap;
                int cember2MerkezY = cember1.SolUstNokta.Y + cember1.YariCap;

                if (cember1 != null && cember2 != null)
                {
                    if (
                        Math.Abs(cember1MerkezX - cember2MerkezX) <= cember1.YariCap + cember2.YariCap 
                        &&
                        Math.Abs(cember1MerkezY - cember2MerkezY) <= cember1.YariCap + cember2.YariCap
                        )
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            butonCalistir.Enabled = true;

            yaricapBirDegisen.Enabled = false;
            yukseklikBirDegisen.Enabled = false;
            genislikBirDegisen.Enabled = false;
            derinlikBirDegisen.Enabled = false;
            xBirDegisen.Enabled = false;
            yBirDegisen.Enabled = false;


            yaricapIkiDegisen.Enabled = false;
            yukseklikIkiDegisen.Enabled = false;
            genislikIkiDegisen.Enabled = false;
            derinlikIkiDegisen.Enabled = false;
            xIkiDegisen.Enabled = false;
            yIkiDegisen.Enabled = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Koordinat düzlemini çizmek için kullanılacak kalemler oluştur
            Pen kalem = new Pen(Color.FromArgb(100, Color.Gray)); // Gri renkte, %40 saydamlıkta bir kalem

            // Picturebox'ın boyutları
            int pbGenislik = pictureBox1.Width;
            int pbYukseklik = pictureBox1.Height;

            // Yatay ekseni çiz (x ekseni)
            e.Graphics.DrawLine(kalem, 0, pbYukseklik / 2, pbGenislik, pbYukseklik / 2);
            // Dikey ekseni çiz (y ekseni)
            e.Graphics.DrawLine(kalem, pbGenislik / 2, pbYukseklik, pbGenislik / 2, 0);

            // Yatay eksende kılavuz çizgileri
            for (int i = 0; i < pbGenislik; i += 10)
                e.Graphics.DrawLine(kalem, i, pbYukseklik / 2 - 2, i, pbYukseklik / 2 + 2);

            // Dikey eksende kılavuz çizgileri
            for (int i = 0; i < pbYukseklik; i += 10)
                e.Graphics.DrawLine(kalem, pbGenislik / 2 - 2, i, pbGenislik / 2 + 2, i);

            // Koordinat etiketlerini çiz
            Font etiketFont = new Font("Arial", 8);
            Brush etiketBrush = Brushes.Black;

            // X ekseni etiketi
            e.Graphics.DrawString("X", etiketFont, etiketBrush, pbGenislik - 15, pbYukseklik / 2 - 15);
            // Y ekseni etiketi
            e.Graphics.DrawString("Y", etiketFont, etiketBrush, pbGenislik / 2 + 5, 5);

            // Orta noktayı gösteren kare çiz
            e.Graphics.FillRectangle(Brushes.Black, pbGenislik / 2 - 2, pbYukseklik / 2 - 2, 5, 5);

            // Kullanılan kalemleri ve fontu temizle
            kalem.Dispose();
            etiketFont.Dispose();
        
        }
           
       
    }
}
