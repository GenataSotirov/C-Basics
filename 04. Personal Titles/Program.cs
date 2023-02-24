using System;

namespace _04._Personal_Titles
{
    class Program
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            char pol = char.Parse(Console.ReadLine());

            if (pol == 'm')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }

        }
    }
}
