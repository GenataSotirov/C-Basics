using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main()
        {
            string student = Console.ReadLine();
            int count = 0;
            int countPositive = 0;
            double sum = 0;

            for (int i = 1; i <= 12; i++)
            {
                while (count < 2)
                {
                    double grade = double.Parse(Console.ReadLine());
                    if (grade < 4.00)
                    {
                        count++;
                    }
                    countPositive++;
                    sum += grade;
                    if (count > 1)
                    {
                        Console.WriteLine($"{student} has been excluded at {countPositive-1} grade");
                    }
                    if (countPositive == 12)
                    {
                            Console.WriteLine($"{student} graduated. Average grade: {sum / countPositive:f2}");
                            count = 2;
                    }
                }
            }
        }
    }
}
