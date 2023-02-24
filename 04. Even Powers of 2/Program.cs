using System;

namespace _04._Even_Powers_of_2
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i+=2)
            {
                Console.WriteLine(Math.Pow(2,i));
            }
        }
    }
}
