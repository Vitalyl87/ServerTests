using AbstartFactory;
using System;

namespace Restaurant.Task2.Recipes.Basic
{
    /// <summary>
    /// Cook basic masala for ukrainian restaurant
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
