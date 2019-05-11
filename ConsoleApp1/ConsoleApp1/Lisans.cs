using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lisans : Ogrenci
    {
        public Lisans(string ogrenciAdi1, string ogrenciSoyadi1, int ogrenciNo1, string ogrenciBolumu1) : base(ogrenciAdi1, ogrenciSoyadi1, ogrenciNo1, ogrenciBolumu1)
        {
            //ogrenci classından miras gelen kısım
        }
    }
}
