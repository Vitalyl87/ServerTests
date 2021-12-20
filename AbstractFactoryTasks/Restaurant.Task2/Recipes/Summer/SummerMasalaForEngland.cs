using AbstartFactory;
using System;


namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for England restaurant
    /// </summary>
    class SummerMasalaForEngland : IRecity
    {
        public SummerMasalaForEngland(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(50, Level.Low);
            cooker.FryChicken(50, Level.Low);
        }
        public string GetInformation()
        {
            return "This is summer masala for England.";
        }
    }
}
