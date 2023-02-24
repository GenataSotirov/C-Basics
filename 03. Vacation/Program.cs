using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double actualWallet = double.Parse(Console.ReadLine());

            int days = 0;
            int spendDays = 0;
            double sum = 0;
            bool isEnough = true;

            string action = Console.ReadLine();
            while (isEnough)
            {
                sum = double.Parse(Console.ReadLine());
                days++;
                if (action == "spend")
                {
                    actualWallet -= sum;
                    if (actualWallet <0)
                    {
                        actualWallet = 0;
                    }
                    spendDays++;
                    //action = Console.ReadLine();
                }
                else if (action == "save")
                {
                    actualWallet += sum;
                    spendDays = 0;
                    //action = Console.ReadLine();
                }
                if (spendDays == 5)
                {
                    isEnough = false;
                    break;
                }
                if (actualWallet >= tripMoney)
                {
                    break;
                }
                action = Console.ReadLine();
            }
            if (isEnough)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            
        }
    }
}
