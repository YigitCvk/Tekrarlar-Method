using System;

namespace Tekrarlar_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.urunAdi = "Çilek";
            urun1.fiyati = 13;
            urun1.aciklama = "7 veren çilek";

            Urun urun2 = new Urun();
            urun2.urunAdi ="Karpuz";
            urun2.fiyati = 50;
            urun2.aciklama = "Adana Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine( "****************************" );
                Console.WriteLine("----------------Methodlar--------------");

                SepetManager sepetManager = new SepetManager();//sepet manager classını cağrmak icin sepetmanager nesnesi olustrduk 
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

            }

        }
    }
}