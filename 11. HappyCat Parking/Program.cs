using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            
            double temp = 0;

            for (int i = 1; i <= days; i++)
            {
                double price = 0;
                double totalPrice = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j%2==1)
                    {
                        price = 2.5;
                    }
                    else if (i%2==1 && j%2 ==0)
                    {
                        price = 1.25;
                    }
                    else
                    {
                        price = 1;
                    }
                    totalPrice += price;
                }
                Console.WriteLine($"Day: {i} - {totalPrice:f2} leva");
                temp += totalPrice;
            }
            Console.WriteLine($"Total: {temp:f2} leva");
        }
    }
}
