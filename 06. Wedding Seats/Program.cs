using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main()
        {
            char sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char firstSector = 'A';
            char []place = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t'};
            int count = 0;

            for (char i = firstSector; i <= sector; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    int temp = 0;
                    if (j%2 == 0)
                    {
                        temp = cols + 2 ;
                    }
                    else
                    {
                        temp = cols;
                    }
                    for (int z = 0; z < temp; z++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.WriteLine($"{i}{j}{place[z]}");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine($"{i}{j}{place[z]}");
                            count++;
                        }
                    }        
                }
                rows++;
            }
            Console.WriteLine(count);
        }
    }
}
