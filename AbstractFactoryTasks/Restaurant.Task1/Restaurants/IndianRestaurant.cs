using AbstartFactory;
using Restaurant.Task1.Recipes;

namespace Restaurant.Task1.Restaurants
{
    /// <summary>
    /// Concrete fabric for indian restaurant
    /// </summary>
    class IndianRestaurant : IAbstractRestaurantFactory
    {
        ICooker cooker;
        public IndianRestaurant(ICooker cooker)
        {
            this.cooker = cooker;
        }
        /// <summary>
        /// create masala for restaurant in India
        /// </summary>
        public IMasala CreateMasala()
        {
            return new MasalaForIndia(cooker);
        }
    }
}
