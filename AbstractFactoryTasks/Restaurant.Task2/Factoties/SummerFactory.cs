using AbstartFactory;
using Restaurant.Task2.Recipes.Summer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Task2.Factoties
{
    /// <summary>
    /// Concrete fabric for summer recipes
    /// </summary>
    class SummerFactory : IAbstractSeasonRestaurantFactory
    {
        ICooker cooker;
        Country country;
        public SummerFactory(ICooker cooker, Country country)
        {
            this.cooker = cooker;
            this.country = country;
        }
        /// <summary>
        /// create masala for summer menu due to Country
        /// </summary>
        public IRecity CreateMasala()
        {
            switch (country)
            {
                case Country.Ukraine:
                    return new SummerMasalaForUkraine(cooker);
                case Country.India:
                    return new SummerMasalaForIndia(cooker);
                case Country.England:
                    return new SummerMasalaForEngland(cooker);
                default: 
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
