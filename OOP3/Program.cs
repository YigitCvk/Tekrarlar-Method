﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan sınıflar için kullanırız...
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           
            IKrediManager tasitKrediManager = new TasitKrediManager();
           
            IKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers);//aşağıdakiyle kodun farklı yazımı

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager ,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
