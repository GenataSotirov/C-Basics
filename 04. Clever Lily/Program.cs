using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());
            int countToys = 0;
            int money = 0;
            int countDayMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i%2 == 1)
                {
                    countToys++;
                }
                else
                {
                    countDayMoney++;
                    money = money + 10 * (i / 2);
                }
            }
            int toysMoney = countToys * toy;
            money = money - countDayMoney;

            if ((money + toysMoney) >= washer)
            {
                Console.WriteLine($"Yes! {((money + toysMoney) - washer):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs((money + toysMoney) - washer):f2}");
            }
        }
    }
}
