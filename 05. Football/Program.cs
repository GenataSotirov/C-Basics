using System;

namespace _05._Football
{
    class Program
    {
        static void Main()
        {
            string team = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());

            double countW = 0;
            int countD = 0;
            int countL = 0;
            int score = 0;

            for (int i = 0; i < matches; i++)
            {
                char exit = char.Parse(Console.ReadLine());

                switch (exit)
                {
                    case 'W':
                        score += 3;
                        countW++;
                        break;
                    case 'D':
                        score += 1;
                        countD++;
                        break;
                    case 'L':
                        countL++;
                        break;
                }
            }
            if (matches > 0)
            {
                Console.WriteLine($"{team} has won {score} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}");
                Console.WriteLine($"## L: {countL}");
                Console.WriteLine($"Win rate: {(countW/matches)*100:f2}%");
            }
            else
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }
        }
    }
}
