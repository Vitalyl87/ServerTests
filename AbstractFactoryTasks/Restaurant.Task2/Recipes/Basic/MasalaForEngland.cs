using AbstartFactory;
using System;


namespace Restaurant.Task2.Recipes.Basic
{
    /// <summary>
    /// Cook basic masala for England restaurant
    /// </summary>
    class MasalaForEngland : IRecity
    {
        public MasalaForEngland(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
        }
        public string GetInformation()
        {
            return "This is basic masala for England.";
        }
    }
}
