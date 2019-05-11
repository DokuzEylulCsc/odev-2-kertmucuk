using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ders
    {
        private int DersKodu;

        public Ders(int dersKodu1)//ders kodu ile olusturucu method
        {
            DersKodu1 = dersKodu1;
        }

        public int DersKodu1 { get => DersKodu; set => DersKodu = value; }

    }
}
