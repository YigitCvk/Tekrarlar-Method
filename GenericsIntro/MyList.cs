using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Generic class  çalışağınız özel bir tip olacağını belirtmek demek
    class MyList<T>//T yerine herhangi bir değer atayabilirsin(T type den geliyor)
    {
        T[] items ;
        //Constructor-class ile aynı isimle olmalı sen oluşturmasanda default olarak da arkada oluşur.
        //Array lerin new lenme zorunluluğu var.Bir class new lendiğinde çalışan bloğa constructor denir...
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];//dizinin eleman sayısını bir arttırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//tempArrays atadığımız gecici değerleri items a atıyorz
            }
            items[items.Length - 1] = item;
        }
    }
}
