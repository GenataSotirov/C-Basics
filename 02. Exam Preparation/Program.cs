using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main()
        {
            int countBadGrade = int.Parse(Console.ReadLine());
            int countFailed = 0;
            int countTotal = 0;
            double sumPoints = 0;
            string lastProblem = string.Empty;
            bool isGood = true;
            string taskName = Console.ReadLine();

            while (taskName != "Enough")
            {
                int actualPoint = int.Parse(Console.ReadLine());
                if (actualPoint <= 4.00)
                {
                    countFailed++;
                    if (countFailed == countBadGrade)
                    {
                        Console.WriteLine($"You need a break, {countFailed} poor grades.");
                        isGood = false;
                        break;
                    }
                    else
                    {
                        countTotal++;
                        sumPoints += actualPoint;
                        lastProblem = taskName;
                    }
                }
                else
                {
                    countTotal++;
                    sumPoints += actualPoint;
                    lastProblem = taskName;
                }
                taskName = Console.ReadLine();
            }
            if (isGood)
            {
                Console.WriteLine($"Average score: {sumPoints / countTotal:f2}");
                Console.WriteLine($"Number of problems: {countTotal}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            
        }
    }
}
