using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Basic
{
    /// <summary>
    /// Cook basic masala for India restaurant
    /// </summary>
    public class MasalaForIndia : IRecity
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
        public string GetInformation()
        {
            return "This is basic masala for India.";
        }
    }
}
