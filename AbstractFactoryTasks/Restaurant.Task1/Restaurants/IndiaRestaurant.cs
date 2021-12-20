using AbstartFactory;
using Restaurant.Task1.Recipes;

namespace Restaurant.Task1.Restaurants
{
    /// <summary>
    /// Concrete fabric for India restaurant
    /// </summary>
    class IndiaRestaurant : IAbstractRestaurantFactory
    {
        ICooker cooker;
        public IndiaRestaurant(ICooker cooker)
        {
            this.cooker = cooker;
        }
        public IMasala CreateMasala()
        {
            return new MasalaForIndia(cooker);
        }
    }
}
