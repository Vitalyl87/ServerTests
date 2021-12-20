using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for Ukraine restaurant
    /// </summary>
    class SummerMasalaForUkraine : IRecity
    {
        public SummerMasalaForUkraine(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in Ukraine]:");
            cooker.FryRice(150, Level.Medium);
            cooker.FryChicken(200, Level.Medium);
            cooker.SaltRice(Level.Low);
            cooker.SaltChicken(Level.Low);
        }
        public string GetInformation()
        {
            return "This is summer masala for Ukraine.";
        }
    }
}
