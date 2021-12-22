using AbstartFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Task1.Recipes
{
    public class BaseMasala : IMasala
    {
        ICooker _cooker;
        public BaseMasala(ICooker cooker)
        {
            _cooker = cooker;
        }

        public string MasalaInformation()
        {
            Console.WriteLine("Get history for this masala:");
            if (_cooker is Cooker cooker)
            {
                return string.Join(" => ", cooker.SecretHistory);
            }
            else
            {
                return "Sorry, information about history for this masala is not availible";
            }
        }
    }
}
