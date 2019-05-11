using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bolum
    {
        private string BolumAdi;

        public List<OgretimElemanlari> HocaList = new List<OgretimElemanlari>();
        public List<Ogrenci> OgrenciList = new List<Ogrenci>();
        public List<Ders> DersList = new List<Ders>();
        public List<Sube> SubeList = new List<Sube>();

        public Bolum(string bolumAdi1)//olusturucu kısmına bolum adi giriliyor
        {
            BolumAdi1 = bolumAdi1;
        }

        public string BolumAdi1 { get => BolumAdi; set => BolumAdi = value; }//bolumadi degiskeni private tutuluyor

        public void OgrenciEkle(int No, string Adi, string Soyadi, string Bolum, string NeOla)//Ogrenci eklemek icin gereken method
        {
            try
            {
                Ogrenci ogr;
                if (NeOla=="Lisans")//ogrenci tipi kontrol ediliyor
                {
                    ogr = new Lisans(Adi, Soyadi, No, Bolum);//eger lisanssa sanal degiskeni lisans yapiyor
                    OgrenciList.Add(ogr);//ogrenci listesine ekliyor
                }
                else if(NeOla=="YüksekLisans")//ogrenci tipi kontrol ediliyor
                {
                    ogr = new YüksekLisans(Adi, Soyadi, No, Bolum);//eger yüseklisanssa sanal degiskeni yükseklisans yapiyor
                    OgrenciList.Add(ogr);//ogrenci listesine ekliyor
                }
                else if(NeOla=="Doktora")//ogrenci tipi kontrol ediliyor
                {
                    ogr = new Doktora(Adi, Soyadi, No, Bolum);//eger doktorasa sanal degiskeni doktora yapiyor
                    OgrenciList.Add(ogr);//ogrenci listesine ekliyor
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Hatali Giris" + e.Message);
            }
        }
        public void OgrenciSil(int no)//ogrenci silme methodu
        {
            foreach(Ogrenci o in OgrenciList)//ogrenci listesini geziyor
            {
               if(o.OgrenciNo1==no)//eger numarası aynı ise 
                {
                    OgrenciList.Remove(o);//listeden atiyor o ogrenciyi tipine bakmadan
                }
            }
        }
        public void DersKayit(int Kodu)//ders kayit icin
        {
            try
            {
                Ders Ders = new Ders(Kodu);//aldıgı parametre ile dersi olusturup
                DersList.Add(Ders);//o dersi listeye ekliyor
            }
            catch (Exception e)
            {

                Console.WriteLine("Ders Kodu Ekle" + e.Message);
            }
        }
        public void DersSil(int Kodu)//ders silme methodu
        {
            foreach(Ders d in DersList)//ders listesini geziyor
            {
                if(d.DersKodu1==Kodu)//dersin kodları ayni ise
                {
                    DersList.Remove(d);//listeden o dersi ucuruyor
                }
            }
        }
        public void HocaEkle(string Ad, string Soyad)//ogretmen eklemek icin method
        {
            try
            {
                OgretimElemanlari hoca = new OgretimElemanlari(Ad, Soyad);//parametre olarak aldıgı adı soyadı ile yaratıyor
                HocaList.Add(hoca);//listeye ekliyor
            }
            catch (Exception e)
            {

                Console.WriteLine("Boyle Hoca Olmaz" + e.Message);
            }
        }
        public void HocaSil(string Ad, string Soyad)//ogretmen silmek icin method
        {
            foreach(OgretimElemanlari h in HocaList)//hoca listesini geziyor
            {
                if(h.OgretimElemaniAdi1==Ad && h.OgretimElemaniSoyadi1==Soyad)//adi ve soyadi aynı ise yani listede var ise
                {
                    HocaList.Remove(h);//listeden o objeyi ucuruyor
                }
            }
        }
        public void DersListele()//mevcut dersleri goruntulemek icin
        {
            foreach(Ders d in DersList)
            {
                Console.WriteLine(d.DersKodu1);
            }
        }
        public void OgrenciListele()//mevcut ogrencileri goruntulemek icin
        {
            foreach(Ogrenci o in OgrenciList)
            {
                Console.WriteLine(o.OgrenciAdi1 + o.OgrenciSoyadi1 + o.OgrenciNo1 + o.OgrenciBolumu1);
            }
        }
        public void HocaListele()//mecvut hocalari listelemek icin
        {
            foreach(OgretimElemanlari h in HocaList)
            {
                Console.WriteLine(h.OgretimElemaniAdi1 + h.OgretimElemaniSoyadi1);
            }
        }
    }
}
