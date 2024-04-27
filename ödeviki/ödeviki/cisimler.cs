using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödeviki
{
    public static class Cisimler
    {
       
        public static List<object> CisimlerListesi = new List<object>();   
        

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
        public int Yuksekik {  get; set; }

        public Dortgen (int x, int y, int genislik, int yukseklik)
        {
            SolUstKose = new Nokta( x, y ) ;
            Genislik   = genislik;
            Yuksekik   = yukseklik;
        }
    }


    public class Dikdörtgen
    {
        public Nokta SolUstKose { get; set; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public Dikdörtgen(int x, int y, int genislik, int yukseklik)
        {
            SolUstKose = new Nokta(x, y);
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

    }

    public class Prizma
    {
        public Dikdörtgen Taban { get; set; }
        public int Yukseklik { get; set; }

        public Prizma(Dikdörtgen taban, int yukseklik)
        {
            Taban = taban;
            Yukseklik = yukseklik;
        }
    }


    public class Cember
    {
        public Nokta Merkez { get; set; }
        public int YariCap { get; set; }

        public Cember(Nokta merkez, int yariCap)
        {
            Merkez = merkez;
            YariCap = yariCap;
        }
    }

    public class Kure
    {
        public Nokta Merkez { get; set; }
        public int YariCap { get; set; }

        public Kure(Nokta merkez, int yariCap)
        {
            Merkez = merkez;
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
