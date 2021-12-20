using Restaurant.Task1;
using Restaurant.Task1.Restaurants;
using System;

namespace AbstartFactory
{
    public class MasalaCooker
    {
        private ICooker cooker;

        public MasalaCooker(ICooker cooker)
        {
            this.cooker = cooker;
        }

        /// <summary>
        /// Create masala for restaurant in Country
        /// </summary>
        /// <param name="country"></param>
        public void CookMasala(Country country)
        {
            Console.WriteLine("**********************************");
            IAbstractRestaurantFactory factory;
            switch (country)
            {
                case Country.Ukraine:
                    factory = new UkraineRestaurant(cooker);
                    factory.CreateMasala();
                    break;
                case Country.India:
                    factory = new IndiaRestaurant(cooker);
                    factory.CreateMasala();
                    break;
                case Country.England:
                    factory = new EnglandRestaurant(cooker);
                    factory.CreateMasala();
                    break;
                default:
                    Console.WriteLine("Sorry, you need say County for our cooker.");
                    break;
            }
        }
    }
}
