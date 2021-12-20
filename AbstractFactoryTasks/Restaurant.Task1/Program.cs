using Restaurant.Task1;
using System;

namespace AbstartFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var masalaCooker = new MasalaCooker(new Cooker());
            masalaCooker.CookMasala(Country.India);
            masalaCooker.CookMasala(Country.England);
            masalaCooker.CookMasala(Country.Ukraine);
            Console.ReadLine();
        }
    }
}
