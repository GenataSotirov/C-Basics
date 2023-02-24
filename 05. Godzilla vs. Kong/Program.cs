using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int walkon  = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if (walkon>150)
            {
                clothes = clothes - clothes * 0.1;
            }
            double cost = walkon * clothes + decor;
            if (cost > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.Write("Wingard needs ");
                Console.Write("{0:f2}", (cost - budget));
                Console.WriteLine(" leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.Write("Wingard starts filming with ");
                Console.Write("{0:f2}", (budget - cost));
                Console.WriteLine(" leva left.");
            }
        }
    }
}
