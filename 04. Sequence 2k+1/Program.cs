using System;

namespace _04.Sequence2k1
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int temp = 0;

            for (int i = 1; i <= num; i++)
            {
                temp = temp * 2 + 1;
                if (temp <= num)
                {
                    Console.WriteLine(temp);
                }
            }
        }
    }
}
