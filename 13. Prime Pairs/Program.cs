using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main()
        {
            int firstStart = int.Parse(Console.ReadLine());
            int secondStart = int.Parse(Console.ReadLine());
            int firstDifference = int.Parse(Console.ReadLine());
            int secondDifference = int.Parse(Console.ReadLine());

            int firstEnd = firstStart + firstDifference;
            int secondEnd = secondStart + secondDifference;
            bool isPrime = false;

            for (int i = firstStart; i <= firstEnd; i++)
            {            
                if (i%2 != 0)
                {
                    for (int j = 3; j < i; j += 2)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                        }
                    }
                    if (isPrime)
                    {
                        int num1 = i;
                        int num2 = 0;

                        for (int k = secondStart; k <= secondEnd; k++)
                        {
                            bool secondPrime = false;
                            if (k%2 !=0)
                            {
                                for (int l = 3; l < k; l+=2)
                                {
                                    if (k%l==0)
                                    {
                                        secondPrime= false;
                                        break;
                                    }
                                    else
                                    {
                                        secondPrime = true;
                                    }
                                }
                                if (secondPrime)
                                {
                                      num2 = k;
                                    Console.WriteLine($"{num1}{num2}");
                                }
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
