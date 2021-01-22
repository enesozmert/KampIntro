using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi" + musteri.Ad);
        }
        public void Ekle1(Musteri musteri,string Ad,string Soyad,int Yas,double Para)
        {
            Console.WriteLine("Musteri Eklendi" + musteri.Ad);
        }
        public void Sil(Musteri musteri)
        {

        }
        public void Guncelle(Musteri musteri)
        {

        }

    }
}
