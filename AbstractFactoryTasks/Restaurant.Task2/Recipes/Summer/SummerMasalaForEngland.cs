using AbstartFactory;
using System;


namespace Restaurant.Task2.Recipes.Summer
{
    /// <summary>
    /// Cook summer masala for english restaurant
    /// </summary>
    class SummerMasalaForEngland : BaseMasala
    {
        public SummerMasalaForEngland(ICooker cooker) : base(cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(50, Level.Low);
            cooker.FryChicken(50, Level.Low);
        }
    }
}
