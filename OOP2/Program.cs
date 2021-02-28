using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer realCustomer = new RealCustomer();
            realCustomer.Id = 1;
            realCustomer.FirstName = "Yiğit";
            realCustomer.LastName = "Çevik";
            realCustomer.CustomerNo = "12345";
            realCustomer.TcNo = "123456";

            TuzelCustomer tuzelCustomer = new TuzelCustomer();
            tuzelCustomer.Id = 2;
            tuzelCustomer.CompanyName = "CVK SOFT";
            tuzelCustomer.CustomerNo = "54321";
            tuzelCustomer.VergiNo = "1233";

            Customer customer = new RealCustomer();
            Customer customer1 = new TuzelCustomer();
            //Bir yerde new görürsen Bellekteli referans nosu vardır.Yukarıda ki son 2 satır kod da customer 2 sınıfıda tutabiliyor.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(realCustomer);
            customerManager.Add(tuzelCustomer);
            customerManager.Add(customer);
            customerManager.Add(customer1);
                      

        }
    }
}
