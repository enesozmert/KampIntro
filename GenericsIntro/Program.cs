using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Engin");
            Console.WriteLine(myList.Length);
            myList.Add("Kerem");
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
