using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Universite DEU = new Universite();
            DEU.FakultEkle("Fen-Edebiyat");
            DEU.FakultEkle("Muhendislik");
            DEU.FakultEkle("Hukuk");
            DEU.FakultEkle("Isletme");
            DEU.FakultEkle("Denizcilik");
            DEU.FakultEkle("Mimarlik");
            DEU.FakultEkle("Su-Sanatlari");
            DEU.FakulteListele();

            Console.WriteLine();
            //DEU.FakulteSil("Su-Sanatlari"); Cozemedigim bir hata var
            Fakulte fen = new Fakulte("Fen-Edebiyat");
            fen.BolumEkle("Bilgisayar Bilimleri");
            fen.BolumEkle("Matematik");
            fen.BolumEkle("İstatistik");
            fen.BolumEkle("Mimarlik");
            fen.BolumListele();
            //fen.BolumSil("Mimarlik"); Cozemedigim bir hata var
            Console.WriteLine();


            Bolum BilgisayarBilimleri = new Bolum("Bilgisayar Bilimleri");
            BilgisayarBilimleri.DersKayit(1001);
            BilgisayarBilimleri.DersKayit(1002);
            BilgisayarBilimleri.DersKayit(1003);
            BilgisayarBilimleri.DersKayit(123123);
            BilgisayarBilimleri.DersListele();
            //BilgisayarBilimleri.DersSil(123123);Cozemedigim bir hata var
            Console.WriteLine();


            BilgisayarBilimleri.HocaEkle("Uğur","ELİİYİ");
            BilgisayarBilimleri.HocaEkle("Barış Tekin", "TEZEL");
            BilgisayarBilimleri.HocaEkle("Efendi", "NASİBOĞLU");
            BilgisayarBilimleri.HocaEkle("Mert", "Kucuk");
            BilgisayarBilimleri.HocaListele();
            //BilgisayarBilimleri.HocaSil("Mert", "Kucuk"); Cozemedigim bir hata var
            Console.WriteLine();


            BilgisayarBilimleri.OgrenciEkle(2015280018, "Mert", "Kucuk", "BilgisayarBilimleri", "Lisans");
            BilgisayarBilimleri.OgrenciEkle(2015280026, "Hasan", "Sagiroglu", "BilgisayarBilimleri", "Lisans");
            BilgisayarBilimleri.OgrenciEkle(123123, "Asd", "Dfg", "İlahiyat", "YüksekLisans");
            //BilgisayarBilimleri.OgrenciSil(123123); Cozemedigim bir hata var
            BilgisayarBilimleri.OgrenciListele();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
