using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main()
        {
            string actorName = Console.ReadLine();
            double academyPoint = double.Parse(Console.ReadLine());
            double persons = double.Parse(Console.ReadLine());
            double final = academyPoint;

            for (int i = 0; i < persons; i++)
            {
                if (final < 1250.50)
                {
                    string juriName = Console.ReadLine();
                    double juriPoint = double.Parse(Console.ReadLine());
                    int namePiont = juriName.Length;
                    double total = (juriPoint * namePiont) / 2;
                    final += total;
                }
            }

            if (final > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {final:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.50 - final):f1} more!");
            }
        }
    }
}
