using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main()
        {
            int period = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && untreated>treated)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients > doctors)
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
                else
                {
                    treated += patients;
                }
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
