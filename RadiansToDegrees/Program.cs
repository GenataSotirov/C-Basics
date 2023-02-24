using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main()
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
