using Restaurant.Task2;
using Restaurant.Task2.Factoties;
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
        /// Cook basic/summer masala due to country and time
        /// </summary>
        /// <param name="currentDate"></param>
        /// <param name="country"></param>
        public void CookMasala(DateTime currentDate, Country country)
        {
            IAbstractSeasonRestaurantFactory factory;
            try
            {
                if (IsSummerDate(currentDate))
                {
                    factory = new SummerFactory(cooker, country);
                }
                else
                {
                    factory = new BasicFactory(cooker, country);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Sorry, you need use correct County for our cooker.");
                return;
            }
            
            var masala = factory.CreateMasala();
            Console.WriteLine(masala.GetInformation());
        }

        private bool IsSummerDate(DateTime currentDate)
        {
            return currentDate.Month >= 6 && currentDate.Month <= 8;
        }
    }
}
