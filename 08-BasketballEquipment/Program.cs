using System;

namespace _08_BasketballEquipment
{
    class Program
    {
        static void Main()
        {
            int yearTax = int.Parse(Console.ReadLine());

            double jordan = yearTax - yearTax * 40 / 100;
            double clotes = jordan - jordan * 20 / 100;
            double ball = clotes / 4;
            double accessories = ball / 5;

            double totalTax = yearTax + jordan + clotes + ball + accessories;

            Console.WriteLine(totalTax);
        }
    }
}
