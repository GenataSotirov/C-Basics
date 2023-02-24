using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int age = 17;

            for (int i = 1800; i <= year; i++)
            {
                age++;
                if (i%2==0)
                {
                    amount = amount - 12000;
                }
                else
                {
                    amount = amount - (12000 + 50 * age);
                }
            }
            if (amount >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {amount:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(amount):f2} dollars to survive.");
            }
        }
    }
}
