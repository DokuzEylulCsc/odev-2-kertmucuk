using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fakulte
    {
        private string FakulteAdi;

        public List<Bolum> BolumList = new List<Bolum>();

        public Fakulte(string fakulteAdi1)//fakulte adi ile olusturucu 
        {
            FakulteAdi1 = fakulteAdi1;
        }

        public string FakulteAdi1 { get => FakulteAdi; set => FakulteAdi = value; }

        public void BolumEkle(string BolumAdi)//bolum eklemek icin method
        {
            try
            {
                Bolum bolum = new Bolum(BolumAdi);//parametreden gelen bolumu yaratıyor
                BolumList.Add(bolum);//bolum listesine ekliyor

            }
            catch (Exception e)
            {

                Console.WriteLine("Bu Bolum Eklenemez", e.Message);
            }
        }
        public void BolumSil(string BolumAdi)//bolum silmek icin method
        {
            foreach(Bolum b in BolumList)//bolum listesini geziyor
            {
                if(b.BolumAdi1==BolumAdi)//silinmek istenen bolum adı ile aynı ise
                {
                    BolumList.Remove(b);//listeden bolumu ucuruyor
                }
            }
        }
        public void BolumListele()//mevcut bolumleri listelemek icin method
        {
            foreach(Bolum b in BolumList)
            {
                Console.WriteLine(b.BolumAdi1);
            }
        }
    }
}
