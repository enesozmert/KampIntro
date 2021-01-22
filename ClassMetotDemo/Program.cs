using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad="Enes";
            musteri.Soyad = "Abc";
            musteri.Yas = 15;
            musteri.Para = 25;
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Enes1";
            musteri1.Soyad = "Abc1";
            musteri1.Yas = 15;
            musteri1.Para = 25;
            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Ad = "Enes2";
            musteri2.Soyad = "Abc2";
            musteri2.Yas = 15;
            musteri2.Para = 25;
            Musteri[] musteriler = new Musteri[] {musteri,musteri1,musteri2 };

        }
    }
}
