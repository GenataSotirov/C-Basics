using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main()
        {
            int page = int.Parse(Console.ReadLine());
            int pagePerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int neededHours = page / pagePerHour;
            Console.WriteLine(neededHours / days);
        }
    }
}
