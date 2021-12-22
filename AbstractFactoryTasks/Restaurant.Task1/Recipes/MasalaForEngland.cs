using AbstartFactory;
using System;

namespace Restaurant.Task1.Recipes
{
    /// <summary>
    /// Cook masala for restaurant in England
    /// </summary>
    public class MasalaForEngland : BaseMasala
    {
        public MasalaForEngland(ICooker cooker) : base (cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
        }
    }
}
