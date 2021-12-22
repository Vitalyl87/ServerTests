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
            IMasala masala;
            switch (country)
            {
                case Country.Ukraine:
                    factory = new UkrainianRestaurant(cooker);
                    masala = factory.CreateMasala();
                    Console.WriteLine(masala.MasalaInformation());
                    break;
                case Country.India:
                    factory = new IndianRestaurant(cooker);
                    masala = factory.CreateMasala();
                    Console.WriteLine(masala.MasalaInformation());
                    break;
                case Country.England:
                    factory = new EnglishRestaurant(cooker);
                    masala = factory.CreateMasala();
                    Console.WriteLine(masala.MasalaInformation());
                    break;
                default:
                    Console.WriteLine("Sorry, you need use correct County for our cooker.");
                    break;
            }
        }
    }
}
