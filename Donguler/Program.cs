using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazılım geliştirici", "Programlamaya başlangıç", "Java", "Python" };

            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti:");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer:");
            Console.ReadLine();
        }
    }
}
