using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va afisa ultima cifra a unui numar intreg */

            
           Console.WriteLine("Acest program va afisa ultima cifra a unui numar intreg");
           
            Console.WriteLine("Introduceti numarul");
            int x = int.Parse(Console.ReadLine());

            int y = x % 10;
            Console.WriteLine( "Ultima cifra este " + y);
        }
    }
}
