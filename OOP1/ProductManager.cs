using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Ekelendi");
            //product.Id = 1;
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }
        //VOID NEDİR?
        //Git yap emir kipi ile çalışan metot türüdür.
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1 , int sayi2)
        {
            Console.WriteLine(sayi1 +sayi2);
            //return sayi1+sayi2;
        }
    }
}
