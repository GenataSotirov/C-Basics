using System;
using System.Threading;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magNum = int.Parse(Console.ReadLine());

            int count = 0;
            bool isFound = true;

            while (isFound)
            {
                for (int i = start; i <= end; i++)
                {
                    for (int j = start ; j <= end; j++)
                    {
                        count++;
                        if (i + j == magNum)
                        {
                            Console.WriteLine($"Combination N:{count} ({i} + {j} = {magNum})");
                            magNum = 0;
                            isFound = false;
                        }
                    }
                }
                if (isFound == true)
                {
                    isFound = false;        
                }
            }
            if (magNum != 0 )
            {
                Console.WriteLine($"{count} combinations - neither equals {magNum}");
            }
        }
    }
}
