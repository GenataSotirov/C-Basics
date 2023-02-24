using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int pair = 0;
            int maxDiff = 0;
            int nextPair = 0;
            bool weHave = false;

            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int temp = num1 + num2;
                if (i ==  1)
                {
                    pair = temp;
                    temp = 0;
                    if (n==1)
                    {
                        weHave = true;
                    }
                }
                else
                {
                    nextPair = temp;
                    if (nextPair != pair)
                    {
                        int diff = Math.Abs(pair - nextPair);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                        pair = nextPair;
                    }
                    else
                    {
                        if (maxDiff != 0)
                        {
                            continue;
                        }
                        else
                        {
                            weHave = true;
                        }
                    }
                    temp = 0;
                }
            }
            if (weHave)
            {
                Console.WriteLine($"Yes, value={pair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
