using Restaurant.Task2;
using System;

namespace AbstartFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var masalaCooker = new MasalaCooker(new Cooker());
            masalaCooker.CookMasala(DateTime.Now, Country.India);
            //summer menu
            masalaCooker.CookMasala(new DateTime(2020, 7, 18), Country.India);
            Console.ReadLine();
        }
    }
}
