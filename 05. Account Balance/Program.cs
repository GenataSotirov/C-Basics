using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main()
        {
            string input = "0";
            double account = 0;

            while (input != "NoMoreMoney")
            {
                double start = Double.Parse(input);
                if (start < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    input = "NoMoreMoney";
                }
                else if (start >= 0)
                {
                    if (start == 0)
                    {
                        input = Console.ReadLine();
                    }
                    else
                    {
                        account += start;
                        Console.WriteLine($"Increase: {start:f2}");
                        input = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
