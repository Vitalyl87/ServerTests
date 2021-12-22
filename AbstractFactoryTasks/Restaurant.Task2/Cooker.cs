using AbstartFactory;
using System;
using System.Collections.Generic;

namespace Restaurant.Task2
{
    public class Cooker : ICooker
    {
        public List<string> SecretHistory = new List<string>();
        string information;
        public void FryChicken(int amount, Level level)
        {
            information = $"Cook gets {amount} gram of chicken and fries it to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }

        public void FryRice(int amount, Level level)
        {
            SecretHistory.Clear();
            information = $"Cook gets {amount} gram of rice and fries it to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }

        public void PepperChicken(Level level)
        {
            information = $"Cook pepper chicken to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }

        public void PepperRice(Level level)
        {
            information = $"Cook pepper rice to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }

        public void SaltChicken(Level level)
        {
            information = $"Cook salt chicken to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }

        public void SaltRice(Level level)
        {
            information = $"Cook salt rice to {level} level";
            Console.WriteLine(information);
            SecretHistory.Add(information);
        }
    }
}
