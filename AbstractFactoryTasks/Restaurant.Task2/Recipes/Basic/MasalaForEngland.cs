using AbstartFactory;
using System;
using System.Collections.Generic;

namespace Restaurant.Task2.Recipes.Basic
{
    /// <summary>
    /// Cook basic masala for english restaurant
    /// </summary>
    class MasalaForEngland : BaseMasala
    {
        public MasalaForEngland(ICooker cooker) : base(cooker)
        {
            Console.WriteLine("Start to cook masala [Restaurant in England]:");
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
        }
    }
}
