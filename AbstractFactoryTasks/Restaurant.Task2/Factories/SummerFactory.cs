using AbstartFactory;
using System;

namespace Restaurant.Task2.Factories
{
    /// <summary>
    /// Concrete fabric for summer recipes
    /// </summary>
    class SummerFactory<T> : IAbstractSeasonRestaurantFactory
    {
        ICooker cooker;
        public SummerFactory(ICooker cooker)
        {
            this.cooker = cooker;
        }
        /// <summary>
        /// create masala for summer menu due to Country
        /// </summary>
        public IRecipy CreateMasala()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Let's create our summer masala!");
            Console.WriteLine("*******************************");
            return (IRecipy)Activator.CreateInstance(typeof(T), cooker);
        }
    }
}
