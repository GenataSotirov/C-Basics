using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main()
        {
            int tours = int.Parse(Console.ReadLine());
            int startPoint = int.Parse(Console.ReadLine());
            int tourPoint = 0;
            double countWin = 0;

            for (int i = 0; i < tours; i++)
            {
                string tourEtap = Console.ReadLine();
                if (tourEtap == "W")
                {
                    countWin++;
                    tourPoint += 2000;
                }
                else if (tourEtap == "F")
                {
                    tourPoint += 1200;
                }
                else if (tourEtap == "SF")
                {
                    tourPoint += 720;
                }
            }
            double totalPoint = startPoint + tourPoint;
            double averagePoints = tourPoint / tours;
            Console.WriteLine($"Final points: {totalPoint}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{((countWin / tours)*100):f2}%");
        }
    }
}
