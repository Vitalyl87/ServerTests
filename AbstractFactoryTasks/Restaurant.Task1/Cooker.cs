using AbstartFactory;
using System;

namespace Restaurant.Task1
{
    public class Cooker : ICooker
    {
        public void FryChicken(int amount, Level level)
        {
            Console.WriteLine($"Cook gets {amount} gram of chicken and fries it to {level} level");
        }

        public void FryRice(int amount, Level level)
        {
            Console.WriteLine($"Cook gets {amount} gram of rice and fries it to {level} level");
        }

        public void PepperChicken(Level level)
        {
            Console.WriteLine($"Cook pepper chicken to {level} level");
        }

        public void PepperRice(Level level)
        {
            Console.WriteLine($"Cook pepper rice to {level} level");
        }

        public void SaltChicken(Level level)
        {
            Console.WriteLine($"Cook salt chicken to {level} level");
        }

        public void SaltRice(Level level)
        {
            Console.WriteLine($"Cook salt rice to {level} level");
        }
    }
}
