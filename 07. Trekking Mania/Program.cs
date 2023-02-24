using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());
            int totalCount = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandgaro = 0;
            double kTwo = 0;
            double everest = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalCount+=people;

                if (people <= 5)
                {
                    musala += people;
                }
                else if (people <= 12)
                {
                    monblan += people;
                }
                else if (people <= 25)
                {
                    kilimandgaro += people;
                }
                else if (people <= 40)
                {
                    kTwo += people;
                }
                else
                {
                     everest += people;
                }
            }
            Console.WriteLine($"{((musala/totalCount)*100):f2}%");
            Console.WriteLine($"{((monblan / totalCount) * 100):f2}%");
            Console.WriteLine($"{((kilimandgaro / totalCount) * 100):f2}%");
            Console.WriteLine($"{((kTwo / totalCount) * 100):f2}%");
            Console.WriteLine($"{((everest / totalCount) * 100):f2}%");
        }
    }
}
