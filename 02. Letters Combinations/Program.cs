using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main()
        {
            char firstLeter = char.Parse(Console.ReadLine());
            char secondLeter = char.Parse(Console.ReadLine());
            char thirdLeter = char.Parse(Console.ReadLine());

            int count = 0;

            for (char i = firstLeter; i <= secondLeter; i++)
            {
                if (i != thirdLeter)
                {
                    for (char j = firstLeter; j <= secondLeter; j++)
                    {
                        if (j != thirdLeter)
                        {
                            for (char z = firstLeter; z <= secondLeter; z++)
                            {
                                if (z != thirdLeter)
                                {
                                    count++;
                                    Console.Write($"{i}{j}{z} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
