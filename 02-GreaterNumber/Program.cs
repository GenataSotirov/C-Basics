using System;

namespace _02_GreaterNumber
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else
            {
                Console.WriteLine(numTwo);
            }
        }
    }
}
