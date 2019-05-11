using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OgretimElemanlari
    {
        private string OgretimElemaniAdi;
        private string OgretimElemaniSoyadi;

        public OgretimElemanlari(string ogretimElemaniAdi1, string ogretimElemaniSoyadi1)//ogretmen yaratmak icin kısım
        {
            OgretimElemaniAdi1 = ogretimElemaniAdi1;
            OgretimElemaniSoyadi1 = ogretimElemaniSoyadi1;
        }

        public string OgretimElemaniAdi1 { get => OgretimElemaniAdi; set => OgretimElemaniAdi = value; }
        public string OgretimElemaniSoyadi1 { get => OgretimElemaniSoyadi; set => OgretimElemaniSoyadi = value; }
    }
}
