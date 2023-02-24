using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double start = 0.70;
            
            double bus = distance * 0.09;
            double train = distance * 0.06;

            if (distance < 20)
            {
                double taxi = 0;
                if (day == "day")
                {
                    taxi = start + distance * 0.79;
                }
                else
                {
                    taxi = start + distance * 0.9;
                }
                Console.WriteLine("{0:f2}", taxi);
            }
            else if (distance < 100)
            {
                Console.WriteLine("{0:f2}", bus);
            }
            else
            {
                Console.WriteLine("{0:f2}", train);
            }
        }

    }
}
