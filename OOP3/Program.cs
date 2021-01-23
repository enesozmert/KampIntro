using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //LOGLAMAK=>
            ILoggerService databaseLoggerService = new DatabaseLoggerSevice();
            ILoggerService fileLoggerService = new FileLoggerSevice();
            ILoggerService smsLoggerService = new SmsLoggerService();
            //Log çoklu
            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerService };
            //Birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için interface kullanırız.

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggerServices);
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager,konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
