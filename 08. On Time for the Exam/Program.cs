using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int exam = hourExam * 60 + minuteExam;
            int arrive = hourArrive * 60 + minuteArrive;
            int hour = 0;
            int minute = 0;
            int differance = Math.Abs(arrive - exam);
             
            if (arrive < exam - 30)
            {
                Console.WriteLine("Early");
                if (differance > 59)
                {
                    hour = differance / 60;
                    minute = differance % 60;
                    Console.WriteLine($"{hour}:{minute:d2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{differance} minutes before the start");
                }
            }
            else if (arrive > exam)
            {
                Console.WriteLine("Late");
                if (differance > 59)
                {
                    hour = differance / 60;
                    minute = differance % 60;
                    Console.WriteLine($"{hour}:{minute:d2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{differance} minutes after the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (differance != 0)
                {
                    Console.WriteLine($"{differance} minutes before the start");
                }
            }
        }
    }
}
