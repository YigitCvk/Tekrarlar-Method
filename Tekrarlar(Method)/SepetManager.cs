using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrarlar_Method_
{
    class SepetManager//manager olan class lar bir operasyon tutuyor demek...
        //ortak kodları classlarin icine yazarız
        //ornegin sepete ekleme sistemini method olarak gruplandırırız classlar ile
    {
        //naming convention -isimlendirme
        public void Ekle(Urun urun ) //nerede parantez() görürsen orada method calisiyor demek
        {
            Console.WriteLine("Sepete Eklendi : "+urun.urunAdi);

        }


    }
}
