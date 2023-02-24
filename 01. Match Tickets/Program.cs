using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (people < 5)
            {
                budget = budget - budget * 0.75;
                if (type == "VIP")
                {
                    ticketPrice = people * 499.99;
                }
                else if (type == "Normal")
                {
                    ticketPrice = people * 249.99;
                }
            }
            else if (people < 10)
            {
                budget = budget - budget * 0.6;
                if (type == "VIP")
                {
                    ticketPrice = people * 499.99;
                }
                else if (type == "Normal")
                {
                    ticketPrice = people * 249.99;
                }
            }
            else if (people < 25)
            {
                budget = budget - budget * 0.5;
                if (type == "VIP")
                {
                    ticketPrice = people * 499.99;
                }
                else if (type == "Normal")
                {
                    ticketPrice = people * 249.99;
                }
            }
            else if (people < 50)
            {
                budget = budget - budget * 0.4;
                if (type == "VIP")
                {
                    ticketPrice = people * 499.99;
                }
                else if (type == "Normal")
                {
                    ticketPrice = people * 249.99;
                }
            }
            else
            {
                budget = budget - budget * 0.25;
                if (type == "VIP")
                {
                    ticketPrice = people * 499.99;
                }
                else if (type == "Normal")
                {
                    ticketPrice = people * 249.99;
                }
            }
            if (budget >= ticketPrice)
            {
                Console.WriteLine($"Yes! You have {budget-ticketPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticketPrice - budget:f2} leva.");
            }
        }
    }
}
