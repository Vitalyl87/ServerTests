using AbstartFactory;
using Restaurant.Task2.Recipes.Basic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Task2.Factoties
{
    /// <summary>
    /// Concrete fabric for basic recipes
    /// </summary>
    class BasicFactory : IAbstractSeasonRestaurantFactory
    {
        ICooker cooker;
        Country country;
        public BasicFactory(ICooker cooker, Country country)
        {
            this.cooker = cooker;
            this.country = country;
        }
        public IRecity CreateMasala()
        {
            switch (country)
            {
                case Country.Ukraine:
                    return new MasalaForUkraine(cooker);
                case Country.India:
                    return new MasalaForIndia(cooker);
                case Country.England:
                    return new MasalaForEngland(cooker);
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
