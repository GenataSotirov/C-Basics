using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > num)
                    {
                        break;
                    }
                    Console.Write(current + " ");
                    current++; 
                }
                
                Console.WriteLine();
            }
        }
    }
}
