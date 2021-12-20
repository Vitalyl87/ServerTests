using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for India restaurant
    /// </summary>
    public class SummerMasalaForIndia : IRecity
    {
        public SummerMasalaForIndia(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in India]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
            cooker.PepperRice(Level.Medium);
            cooker.PepperChicken(Level.Medium);
        }
        public string GetInformation()
        {
            return "This is summer masala for India.";
        }
    }
}
