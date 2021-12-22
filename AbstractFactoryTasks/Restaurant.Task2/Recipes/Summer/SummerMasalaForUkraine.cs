using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for ukrainian restaurant
    /// </summary>
    class SummerMasalaForUkraine : BaseMasala
    {
        public SummerMasalaForUkraine(ICooker cooker) : base(cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in Ukraine]:");
            cooker.FryRice(150, Level.Medium);
            cooker.FryChicken(200, Level.Medium);
            cooker.SaltRice(Level.Low);
            cooker.SaltChicken(Level.Low);
        }
    }
}
