using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;


            kurs kurs1 = new kurs();
            kurs1.KursAdi = "c#";
            kurs1.Eğitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "kerem varış";
            kurs2.IzlenmeOrani = 68;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "c++";
            kurs3.Eğitmen = "berkay ";
            kurs3.IzlenmeOrani = 68;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Eğitmen);
            }

        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
    }
}
