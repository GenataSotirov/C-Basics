using System;

namespace _05._PC_Game_Shop
{
    class Program
    {
        static void Main()
        {
            int countGames = int.Parse(Console.ReadLine());

            double countHeart = 0; ;
            double countFornite = 0;
            double countOver = 0;
            double countOther = 0;

            for (int i = 0; i < countGames; i++)
            {
                string game = Console.ReadLine();
                switch (game)
                {
                    case "Hearthstone":
                        countHeart++;
                        break;
                    case "Fornite":
                        countFornite++; 
                        break;
                    case "Overwatch":
                        countOver++;
                        break;
                    default:
                        countOther++;
                        break;
                }
            }
            Console.WriteLine($"Hearthstone - {(countHeart/countGames)*100:f2}%");
            Console.WriteLine($"Fornite - {(countFornite/countGames)*100:f2}%");
            Console.WriteLine($"Overwatch - {(countOver/countGames)*100:f2}%");
            Console.WriteLine($"Others - {(countOther / countGames) *100:f2}%");
        }
    }
}
