using System;

namespace _04._Grades
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());

            int countTop = 0;
            int countFour = 0;
            int countThree = 0;
            int countFail = 0;
            double averageGrade = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;

                if (grade>=5)
                {
                    countTop++;
                }
                else if (grade >= 4)
                {
                    countFour++;
                }
                else if (grade >= 3)
                {
                    countThree++;
                }
                else
                {
                    countFail++;
                }
            }
            Console.WriteLine($"Top students: {(double)countTop/students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)countFour/students*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)countThree/students*100:f2}%");
            Console.WriteLine($"Fail: {(double)countFail/students*100:f2}%");
            Console.WriteLine($"Average: {averageGrade/students:f2}");
        }
    }
}