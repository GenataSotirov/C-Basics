using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());   

            for (int i = numOne; i <= numTwo; i++)
            {
                string currentNum = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int digit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        sumEven+= digit;
                    }
                    else
                    {
                        sumOdd+= digit;
                    }
                }
                if (sumOdd == sumEven)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
