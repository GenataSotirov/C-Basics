using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            int count = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            bool isFound = true;

            for (int a = 1; a < 9; a++)
            {
                for (int b = 2; b <= 9; b++)
                {
                    for (int c = 2; c <= 9; c++)
                    {
                        for (int d = 1; d < 9; d++)
                        {
                            if ((a*b +c*d)==key && b>a && c>d)
                            {           
                                Console.Write($"{a}{b}{c}{d} ");

                                count++;
                                if (count == 4)                            
                                {
                                    one = a;
                                    two = b;
                                    three = c;
                                    four = d;
                                }
                                
                            }
                        }

                    }
                }
            }
            Console.WriteLine();
            if (count < 4)
            {
                Console.WriteLine("No!");
                isFound = false;
            }
            if (isFound)
            {
                Console.WriteLine($"Password: {one}{two}{three}{four}");
            }
        }
    }
}
