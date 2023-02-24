using System;

namespace _05._Salary
{
    class Program
    {
        static void Main()
        {
            int brauzers = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

                for (int i = 0; i < brauzers; i++)
                {
                    if (salary > 0)
                    {
                        string web = Console.ReadLine();
                        int countFase = 0;
                        int countInst = 0;
                        int countRed = 0;

                        switch (web)
                        {
                            case "Facebook":
                                countFase += 150;
                                break;
                            case "Instagram":
                                countInst += 100;
                                break;
                            case "Reddit":
                                countRed += 50;
                                break;
                            default:
                                break;
                        }
                        int penalty = countFase + countInst + countRed;
                        salary -= penalty;
                    }
                }
            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
