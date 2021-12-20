using AbstartFactory;
using System;

namespace Restaurant.Task1.Recipes
{
    /// <summary>
    /// Cook masala for India restaurant
    /// </summary>
    public class MasalaForIndia : IMasala
    {
        public MasalaForIndia(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in India]:");
            cooker.FryRice(200, Level.Strong);
            cooker.FryChicken(100, Level.Strong);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Strong);
            cooker.SaltChicken(Level.Strong);
            cooker.PepperChicken(Level.Strong);
        }
        public string MasalaInformation()
        {
            return "This is masala for India.";
        }
    }
}
