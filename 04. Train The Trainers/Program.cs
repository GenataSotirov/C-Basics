using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main()
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int count = 0;
            double averageTotal = 0;

            while (presentation != "Finish")
            {
                double sumGrade = 0;
                count++;
                for (int i = 1; i <= jury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                }
                double averageGrade = sumGrade / jury;
                averageTotal += averageGrade;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averageTotal/count:f2}.");
        }
    }
}
