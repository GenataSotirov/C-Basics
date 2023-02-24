using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    count++;
                    if (isFound)
                    {
                        break;
                    }
                    else if (i + j == magNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magNum})");
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {magNum}");
            }
        }
    }
}
