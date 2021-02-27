using System;

namespace InterfacesDemo2
{
    class Program
    {
        //İnterface New lenemez...İnterfaceler Referans tiptir...interfaceler onu implemente eden sınıfları tutabilirler Main methodunda olduğu gibi
        static void Main(string[] args)
        {
            //IPersonManager personManager = new CustomerManager();
            //personManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new InternManager());
        }
    }
   interface IPersonManager
    {
        void Add();
        void Update();
    }
    //Inharits-class--------------implements-interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {

            personManager.Add();
        }
        
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
}
