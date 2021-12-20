using AbstartFactory;
using Restaurant.Task1.Recipes;

namespace Restaurant.Task1.Restaurants
{
    /// <summary>
    /// Concrete fabric for England restaurant
    /// </summary>
    class EnglandRestaurant : IAbstractRestaurantFactory
    {
        ICooker cooker;
        public EnglandRestaurant(ICooker cooker)
        {
            this.cooker = cooker;
        }
        /// <summary>
        /// create masala for restaurant in England
        /// </summary>
        public IMasala CreateMasala()
        {
            return new MasalaForEngland(cooker);
        }
    }
}
