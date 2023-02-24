using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main()
        {
            int hudreds = int.Parse(Console.ReadLine());
            int dozens = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for (int i = 2; i <= hudreds; i+=2)
            {
                for (int j = 2; j <= dozens; j++)
                {
                    for (int k = 2; k <= units; k+=2)
                    {
                        if (j==2 || j==3 || j==5 || j==7)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
