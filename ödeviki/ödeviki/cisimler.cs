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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödeviki
{
    public class Cisimler
    {
       
    }
 

    public class Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }

    public class Dortgen
    {
        public Nokta SolUstKose { get; set; }   
        public int Genislik {  get; set; }
        public int Yukseklik {  get; set; }

        public Dortgen (int x, int y, int genislik, int yukseklik)
        {
            SolUstKose = new Nokta( x, y ) ;
            Genislik   = genislik;
            Yukseklik   = yukseklik;
        }
    }


    public class DıkdortgenPrizma 
    {
        public Dortgen Taban { get; set; }
        public int Yukseklik { get; set; }

        public DıkdortgenPrizma(Dortgen taban, int yukseklik)
        {
            Taban = taban;
            Yukseklik = yukseklik;
        }
    }


    public class Cember
    {
        public Nokta SolUstNokta { get; set; }
        public int YariCap { get; set; }

        public Cember(int x, int y, int yariCap)
        {
            SolUstNokta = new Nokta( x, y);
            YariCap = yariCap;
        }
    }

    public class Kure
    {
        public Nokta SolUstNokta { get; set; }
        public int YariCap { get; set; }

        public Kure(int x, int y, int yariCap)
        {
            SolUstNokta = new Nokta(x , y);
            YariCap = yariCap;
        }
    }

    public class Silindir
    {
        public Cember Taban { get; set; }
        public int Yukseklik { get; set; }

        public Silindir(Cember taban, int yukseklik)
        {
            Taban = taban;
            Yukseklik = yukseklik;
        }
    }

    public class Yuzey
    {
        public Nokta[] Noktalar { get; set; }

        public Yuzey(params Nokta[] noktalar)
        {
            Noktalar = noktalar;
        }
    }
}
