using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs = new Kurs();
            kurs.KursAdi = "aa";
            kurs.Egitmen = "aa";
            kurs.Izlenme = 12;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "bb";
            kurs1.Egitmen = "aa";
            kurs1.Izlenme = 12;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "cc";
            kurs2.Egitmen = "aa";
            kurs2.Izlenme = 12;
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs, kurs1, kurs2 };
            foreach (var kurscuk in kurslar)
            {
                Console.WriteLine(kurscuk.KursAdi + " : " + kurscuk.Egitmen);
            }
            Console.ReadLine();
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int Izlenme { get; set; }
    }
}
