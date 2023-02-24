using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main()
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string[] outfit = { "Shirt", "Sweatshirt", "T-Shirt", "Swim Suit" };
            string[] shoes = { "Sneakers", "Moccasins", "Sandals", "Barefoot" };

            if (degrees <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[1]} and {shoes[0]}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[0]} and {shoes[1]}.");
                }
                else
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[0]} and {shoes[1]}.");
                }
            }
            else if (degrees < 25)
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[0]} and {shoes[1]}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[2]} and {shoes[2]}.");
                }
                else
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[0]} and {shoes[1]}.");
                }
            }
            else
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[2]} and {shoes[2]}.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[3]} and {shoes[3]}.");
                }
                else
                {
                    Console.WriteLine($"It's {degrees} degrees, get your {outfit[0]} and {shoes[1]}.");
                }
            }
        }
    }
}
