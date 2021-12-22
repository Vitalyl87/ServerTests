using AbstartFactory;
using System;

namespace Restaurant.Task1.Recipes
{
    /// <summary>
    /// Cook masala for restaurant in Ukraine
    /// </summary>
    class MasalaForUkraine : BaseMasala
    {
        public MasalaForUkraine(ICooker cooker) : base(cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in Ukraine]:");
            cooker.FryRice(500, Level.Strong);
            cooker.FryChicken(300, Level.Medium);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Low);
            cooker.SaltChicken(Level.Medium);
            cooker.PepperChicken(Level.Low);
        }
    }
}
