using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Universite
    {
        public List<Fakulte> FakulteList = new List<Fakulte>();

        public void FakultEkle(string FakulteAdi)//universiteye fakulte ekleme methodu
        {
            try
            {
                Fakulte fakulte = new Fakulte(FakulteAdi);//parametreyle fakulte olusturuyor
                FakulteList.Add(fakulte);//olusturulan fakulteyi ekliyor
            }
            catch (Exception e)
            {

                Console.WriteLine("Fakulte Eklenemez",e.Message);
            }
        }
        public void FakulteSil(string FakulteAdi)//fakulte silme methodu
        {
            foreach(Fakulte f in FakulteList)//fakulte listesini geziyor
            {
                if(f.FakulteAdi1==FakulteAdi)//eger fakulte adlari aynı ise
                {
                    FakulteList.Remove(f);  //listeden ucuruyor
                }
            }
        }
        public void FakulteListele()//eldeki tüm fakulteleri gormek icin
        {
            foreach(Fakulte f in FakulteList)
            {
                Console.WriteLine(f.FakulteAdi1);
            }
        }
    }
}
