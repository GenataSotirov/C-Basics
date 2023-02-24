using System;
using System.ComponentModel;

namespace _05._Coins
{
    class Program
    {
        static void Main()
        {
            double instead = double.Parse(Console.ReadLine());
            int coins = 0;
            int result = Convert.ToInt32(instead * 100);
            int temp = 0;

            if (result / 200 != 0)
            {
                temp = result / 200;
                coins += temp;
                temp = 0;
                result = result % 200;
            }
            else
            {
                result = result % 200;
            }
            if (result / 100 != 0)
            {
                temp = result / 100;
                coins += temp;
                temp = 0;
                result = result % 100;
            }
            else
            {
                result = result % 100;
            }
            if (result / 50 != 0)
            {
                temp = result / 50;
                coins += temp;
                temp = 0;
                result = result % 50;
            }
            else
            {
                result = result % 50;
            }
            if (result / 20 != 0)
            {
                temp = result / 20;
                coins += temp;
                temp = 0;
                result = result % 20;
            }
            else
            {
                result = result % 20;
            }
            if (result / 10 != 0)
            {
                temp = result / 10;
                coins += temp;
                temp = 0;
                result = result % 10;
            }
            else
            {
                result = result % 10;
            }
            if (result / 5 != 0)
            {
                temp = result / 5;
                coins += temp;
                temp = 0;
                result = result % 5;
            }
            else
            {
                result = result % 5;
            }
            if (result / 2 != 0)
            {
                temp = result / 2;
                coins += temp;
                temp = 0;
                result = result % 2;
                coins += result;
            }
            else
            {
                result = result % 2;
                coins += result;
            }
            Console.WriteLine(coins);
        }
    }
}
