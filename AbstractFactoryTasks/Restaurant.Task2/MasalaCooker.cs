using Restaurant.Task2;
using Restaurant.Task2.Factories;
using Restaurant.Task2.Recipes.Basic;
using Restaurant.Task2.Recipes.Summer;
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
        /// <param name="currentDate">DateTime</param>
        /// <param name="country">Country</param>
        public void CookMasala(DateTime currentDate, Country country)
        {
            IAbstractSeasonRestaurantFactory factory;
            try
            {
                if (IsSummerDate(currentDate))
                {
                    switch (country)
                    {
                        case Country.Ukraine:
                            factory = new SummerFactory<SummerMasalaForUkraine>(cooker);
                            break;
                        case Country.India:
                            factory = new SummerFactory<SummerMasalaForIndia>(cooker);
                            break;
                        case Country.England:
                            factory = new SummerFactory<SummerMasalaForEngland>(cooker);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    switch (country)
                    {
                        case Country.Ukraine:
                            factory = new BasicFactory<MasalaForUkraine>(cooker);

                            break;
                        case Country.India:
                            factory = new BasicFactory<MasalaForIndia>(cooker);
                            break;
                        case Country.England:
                            factory = new BasicFactory<MasalaForEngland>(cooker);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
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
