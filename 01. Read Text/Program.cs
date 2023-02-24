using System;

namespace _01._Read_Text
{
    class Program
    {
        static void Main()
        {
            bool stop = true;

            while (stop)
            {
                string name = Console.ReadLine();
                if (name != "Stop")
                {
                    Console.WriteLine(name);
                }
                else
                {
                    stop = false;
                }
            }
        }
    }
}
