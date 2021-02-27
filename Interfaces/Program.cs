using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo();
            // InterfacesIntro();

            ICustomerDal[] customerDals = new ICustomerDal[2]
                {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Yiğit", LastName = "Çevik", Adress = "İstanbul" });

            Console.WriteLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
    }
    interface IPerson
    {
        //interface; bir temel nesne oluşturup diğer oluşturacağımız nesneleri ondan implemente etmektir.
        int Id  { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Studen:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}
