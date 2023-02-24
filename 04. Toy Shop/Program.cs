using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main()
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toys = puzzles + dolls + bears + minions + trucks;
            double total = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
            double rent = 0;
            double discount = 0;

            if (toys>49)
            {
                discount = total*0.25;
            }
            rent = (total - discount) * 0.1;
            double final = total - rent - discount;

            if (final >= tripPrice)
            {
                Console.Write("Yes! ");
                Console.Write("{0:f2}",(final - tripPrice));
                Console.WriteLine(" lv left.");
            }
            else
            {
                Console.Write("Not enough money! ");
                Console.Write("{0:f2}", (tripPrice - final));
                Console.WriteLine(" lv needed.");
            }
        }
    }
}
