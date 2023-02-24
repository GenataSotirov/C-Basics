using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int places = row * col;

            if (type == "Premiere")
            {
                Console.WriteLine($"{(places * 12.00):f2} leva");
            }
            else if (type =="Normal")
            {
                Console.WriteLine($"{(places * 7.50):f2} leva");
            }
            else if (type == "Discount")
            {
                Console.WriteLine($"{(places * 5.00):f2} leva");
            }
        }
    }
}
