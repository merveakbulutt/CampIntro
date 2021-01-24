﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
           IKrediManager tasitKrediManager = new TasitKrediManager();
           IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService datebaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileloggerservice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),new List<ILoggerService> {new DataBaseLoggerService(),new SmsLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
        }
    }
}
