using AbstartFactory;
using System;

namespace Restaurant.Task2.Factories
{
    /// <summary>
    /// Concrete fabric for basic recipes
    /// </summary>
    class BasicFactory<T> : IAbstractSeasonRestaurantFactory
    {
        ICooker cooker;

        public BasicFactory(ICooker cooker)
        {
            this.cooker = cooker;
        }
        /// <summary>
        /// create masala for Basic menu due to Country
        /// </summary>
        public IRecipy CreateMasala()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Let's create our basic masala!");
            Console.WriteLine("******************************");
            return (IRecipy)Activator.CreateInstance(typeof(T), cooker);
        }
    }
}
