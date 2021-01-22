using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi." + urun.Adi);
        }
        public void Ekle2(string adi, string aciklama, double fiyat)
        {
            Console.WriteLine("Urun adi : " + adi);
        }
    }
}
