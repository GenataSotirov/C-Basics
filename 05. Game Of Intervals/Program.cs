using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main()
        {
            int round = int.Parse(Console.ReadLine());
            int groupOne = 0;
            int groupTwo = 0;
            int groupThree = 0;
            int groupFour = 0;
            int groupFive = 0;
            int invalid = 0;
            double score = 0;

            for (int i = 0; i < round; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    invalid++;
                    score /= 2;
                }
                else if (number < 10)
                {
                    groupOne++;
                    score += number * 0.2;
                }
                else if (number < 20)
                {
                    groupTwo++;
                    score += number * 0.3;
                }
                else if (number < 30)
                {
                    groupThree++;
                    score += number * 0.4; 
                }
                else if (number < 40)
                {
                    groupFour++;
                    score += 50;
                }
                else 
                {
                    groupFive++;
                    score += 100;
                }
            }
            Console.WriteLine($"{score:f2}");
            Console.WriteLine($"From 0 to 9: {(double)groupOne/round*100:f2}%");
            Console.WriteLine($"From 10 to 19: {(double)groupTwo /round*100:f2}%");
            Console.WriteLine($"From 20 to 29: {(double)groupThree / round * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(double)groupFour / round * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(double)groupFive / round * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(double)invalid / round * 100:f2}%");
        }
    }
}
