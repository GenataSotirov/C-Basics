using System;

namespace _06._Name_Game
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();

            string winner = string.Empty;
            int score = 0;
            int previous = 0;

             while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    //int code = ;

                    if (num == (int)name[i])
                    {
                        score += 10;
                    }
                    else
                    {
                        score += 2;
                    }
                }
                if (score >= previous)
                {
                    winner = name;
                    previous = score;
                }
                score = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"The winner is {winner} with {previous} points!");
        }
    }
}
