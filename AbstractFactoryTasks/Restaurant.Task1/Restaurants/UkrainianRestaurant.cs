using AbstartFactory;
using Restaurant.Task1.Recipes;

namespace Restaurant.Task1.Restaurants
{
    /// <summary>
    /// Concrete fabric for ukrainian restaurant
    /// </summary>
    class UkrainianRestaurant : IAbstractRestaurantFactory
    {
        ICooker cooker;
        public UkrainianRestaurant(ICooker cooker)
        {
            this.cooker = cooker;
        }
        /// <summary>
        /// create masala for restaurant in Ukraine
        /// </summary>
        public IMasala CreateMasala()
        {
            return new MasalaForUkraine(cooker);
        }
    }
}
