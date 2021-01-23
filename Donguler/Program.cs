using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "proglamlamya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //array-dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı","proglamlamya başlangıç için temel kurs",
                "java","python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("..........");

            //dizileri kolay dolaşmak için foreach kullanılır.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
