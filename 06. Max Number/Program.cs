using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main()
        {
            string input = "-2147483648";
            int maxNumber = int.MinValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
