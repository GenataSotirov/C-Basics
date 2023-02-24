using System;

namespace _04_PasswordGuess
{
    class Program
    {
        static void Main()
        {
            string pass = Console.ReadLine();
            string word = "s3cr3t!P@ssw0rd";

            if (pass == word)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
