using AbstartFactory;
using System;


namespace Restaurant.Task1.Recipes
{
    /// <summary>
    /// Cook masala for England restaurant
    /// </summary>
    class MasalaForEngland : IMasala
    {
        public MasalaForEngland(ICooker cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
        }
        public string MasalaInformation()
        {
            return "This is masala for England.";
        }
    }
}
