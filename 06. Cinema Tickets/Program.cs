using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            double freePlaces = double.Parse(Console.ReadLine());
            int countKid = 0;
            int countStudent = 0;
            int countStandart = 0;

            while (name != "Finish")
            {
                int kid = 0;
                int student = 0;
                int standart = 0;
                double total = kid + student + standart;
                string ticketType = Console.ReadLine();
                bool isFinish = true;
                while (ticketType != "End")
                {
                    if (ticketType == "Finish")
                    {
                        isFinish = false;
                        break;
                    }
                    switch (ticketType)
                    {
                        case "kid":
                            kid++;
                            break;
                        case "student":
                            student++;
                            break;
                        case "standard":
                            standart++;
                            break;
                        default:
                            break;
                    }
                    total = kid + student + standart;
                    if (total < freePlaces)
                    {
                        ticketType = Console.ReadLine();
                    }
                    else
                    {
                        ticketType = "End";
                    }
                }
                countKid += kid;
                countStudent += student;
                countStandart += standart;
                Console.WriteLine($"{name} - {((kid + student + standart)/freePlaces)*100:f2}% full.");
                if (isFinish)
                {
                    name = Console.ReadLine();
                    if (name == "Finish")
                    {
                        break;
                    }
                    else
                    {
                        freePlaces = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    name = "Finish";
                }
            }
            double totalTickets = countKid + countStudent + countStandart;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{countStudent/totalTickets *100:f2}% student tickets.");
            Console.WriteLine($"{countStandart / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{countKid / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
