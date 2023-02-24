using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int start = 1111;
            int end = 9999;

         
            for (int i = start; i <= end; i++)
            {
                string current = i.ToString();
                int count = 0;

                for (int j = 0; j < current.Length; j++)
                {
                    int digit = int.Parse(current[j].ToString());
                    if (digit == 0)
                    {
                        break;
                    }
                    else if (num % digit == 0)
                    {
                        count++;
                    }
                }
                if (count == 4)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
