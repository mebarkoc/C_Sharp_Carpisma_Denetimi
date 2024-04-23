using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödeviki
{
    public class cisimler<cisim>
    {
        public int koordinatBirX;
        public int koordinatBirY;
        public int koordinatBirZ;
        public int koordinatIkiX;
        public int koordinatIkiY; 
        public int koordinatIkiZ;

        public int yaricapBir;
        public int yaricapIki;
        public int yukseklikBir;
        public int yukseklikIki;

    }

    class Nokta<cisim> : cisimler<cisim>
    {
        public Nokta() 
        {
        }  



    }
}
