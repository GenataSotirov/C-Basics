using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (number != "stop")
            {
                int current = int.Parse(number);
                bool isPrime = true;
                if (current < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    if (current == 1)
                    {
                        sumNonPrime++;
                    }
                    if (current == 2)
                    {
                        isPrime = true;
                    }
                    else if (current % 2 == 0)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (int i = 3; i < current; i += 2)
                        {
                            if (current % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += current;
                    }
                    else
                    {
                        sumNonPrime += current;
                    }
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}