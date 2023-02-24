using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main()
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double leftHours = double.Parse(Console.ReadLine());

            double fillPipeOne = pipeOne * leftHours;
            double fillPipeTwo = pipeTwo * leftHours;
            double totalWater = fillPipeOne+fillPipeTwo;
            double percentOne = (fillPipeOne/totalWater)*100;
            double percentTwo = (fillPipeTwo/totalWater)*100;
            double poolPercent = (totalWater/poolVolume) * 100;

            if (totalWater <= poolVolume)
            {
                Console.WriteLine($"The pool is {poolPercent:f2}% full. Pipe 1: {percentOne:f2}%. " +
                    $"Pipe 2: {percentTwo:f2}%.");
            }
            else
            {
                double overflow = totalWater - poolVolume;
                Console.WriteLine($"For {leftHours:f2} hours the pool overflows with {overflow:f2} liters.");
            }
        }
    }
}
