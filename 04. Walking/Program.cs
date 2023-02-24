using System;

namespace _04._Walking
{
    class Program
    {
        static void Main()
        {
            int stepsGoal = 10000;
            bool isGoalReached = true;
            string foot = Console.ReadLine();
            int actualSteps = 0;    

            while (foot != "Going home")
            {
                int steps = int.Parse(foot);
                actualSteps += steps;
                if (actualSteps >= stepsGoal)
                {
                    break;
                }
                foot = Console.ReadLine();
            }
            if (foot == "Going home")
            {
                foot = Console.ReadLine();
                int steps = int.Parse(foot);
                actualSteps += steps;
                if (actualSteps < stepsGoal)
                {
                    isGoalReached = false;
                }
            }
            if (isGoalReached)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{actualSteps - stepsGoal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsGoal - actualSteps} more steps to reach goal.");
            }
        }
    }
}
