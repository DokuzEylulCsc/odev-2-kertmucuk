using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Ogrenci
    {
        private int OgrenciNo;
        private string OgrenciAdi;
        private string OgrenciSoyadi;
        private string OgrenciBolumu;

        public string OgrenciBolumu1 { get => OgrenciBolumu; set => OgrenciBolumu = value; }
        public string OgrenciSoyadi1 { get => OgrenciSoyadi; set => OgrenciSoyadi = value; }
        public string OgrenciAdi1 { get => OgrenciAdi; set => OgrenciAdi = value; }
        public int OgrenciNo1 { get => OgrenciNo; set => OgrenciNo = value; }

        protected Ogrenci(string ogrenciAdi1, string ogrenciSoyadi1, int ogrenciNo1, string ogrenciBolumu1)//ogrenci yaratmak icin olusturucu kısmı
        {
            OgrenciAdi1 = ogrenciAdi1;
            OgrenciSoyadi1 = ogrenciSoyadi1;
            OgrenciNo1 = ogrenciNo1;
            OgrenciBolumu1 = ogrenciBolumu1;
        }
    }
}
