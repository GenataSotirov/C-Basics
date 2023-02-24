using System;

namespace _06_Repainting
{
    class Program
    {
        static void Main()
        {
            int nylon = int.Parse(Console.ReadLine());
            double color = double.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double materials = (nylon + 2) * 1.5 + (color + color / 10) * 14.50 + diluent * 5.00 + 0.40;
            double hourPrice = materials * 30 / 100;
            double total = materials + workHours * hourPrice;

            Console.WriteLine(total);
        }
    }
}
