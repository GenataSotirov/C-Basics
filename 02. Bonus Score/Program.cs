using System;

namespace _02._Bonus_Score
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (number <101)
            {
                bonus += 5;
            }
            else if (number < 1001)
            {
                bonus = bonus + number * 0.2;
            }
            else
            {
                bonus = bonus + number * 0.1;
            }

            if (number%2 == 0)
            {
                bonus++;
            }
            else if (number%10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
