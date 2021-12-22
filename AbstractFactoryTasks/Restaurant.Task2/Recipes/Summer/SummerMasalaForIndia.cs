using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for indian restaurant
    /// </summary>
    public class SummerMasalaForIndia : BaseMasala
    {
        public SummerMasalaForIndia(ICooker cooker) : base(cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in India]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
            cooker.PepperRice(Level.Medium);
            cooker.PepperChicken(Level.Medium);
        }
    }
}
