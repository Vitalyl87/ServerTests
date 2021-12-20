using AbstartFactory;
using Restaurant.Task1.Recipes;

namespace Restaurant.Task1.Restaurants
{
    /// <summary>
    /// Concrete fabric for Ukraine restaurant
    /// </summary>
    class UkraineRestaurant : IAbstractRestaurantFactory
    {
        ICooker cooker;
        public UkraineRestaurant(ICooker cooker)
        {
            this.cooker = cooker;
        }
        public IMasala CreateMasala()
        {
            return new MasalaForUkraine(cooker);
        }
    }
}
