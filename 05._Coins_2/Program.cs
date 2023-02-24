using System;

namespace _05._Coins_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double instead = double.Parse(Console.ReadLine());
            int coins = 0;
            int result = Convert.ToInt32(instead * 100);
            int temp = 0;
            int[] arr = { 200, 100, 50, 20, 10, 5, 2 };

            while (result > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    temp = result / arr[i];
                    coins += temp;
                    temp = 0;
                    result = result % arr[i];
                }
                if (result == 1)
                {
                    coins++;
                    result = 0;
                }
            }
           Console.WriteLine(coins);
        }
  }
}
