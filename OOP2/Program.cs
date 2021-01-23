using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1111";
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.TcNo = "51656151";
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "11112";
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.VergiNo = "23242";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            //Gerçek - Tüzel Müşteri
            //SOLID (L) =>
        }
    }
}
