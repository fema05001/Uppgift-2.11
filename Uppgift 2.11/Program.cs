using System;

namespace Uppgift2_11
{
    class Program
    {
        static void Main(string[]Args)
        {
            Console.WriteLine("Hur långt hoppade du Elin?");
            string x = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade du Alma?");
            string y = Console.ReadLine();
            int a = int.Parse(x);
            int b = int.Parse(y);
            int c = a - b;
            Console.Write(" Elin hoppade " + c);
            Console.Write(" meter längre än Alma.");


        }
    }
}