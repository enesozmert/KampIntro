using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun() { Adi = "Elma", Fiyati = 15, Aciklama = "Elma gibi elma" };
            Urun urun2 = new Urun() { Adi = "Karpuz", Fiyati = 80, Aciklama = "Diayarbakir karpuzu" };
            Urun urun3 = new Urun() { Adi = "Elma", Fiyati = 15, Aciklama = "Elma gibi elma" };

            Urun[] uruns = new Urun[] { urun1, urun2 };
            foreach (var urun in uruns)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------Metotlar-----------");
            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("aa","aa",15);
            sepetManager.Ekle2("bb","bb",14);
            sepetManager.Ekle2("cc","cc",13);

        }
    }
}
//tekrar takrar kullanmak;- Clean Code - Best Practice