using System;

namespace _06.Powerful_Word
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            int sum = 0;
            int score = 0;
            string powerWord = string.Empty;

            while (word != "End of words")
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sum += (int)word[i];
                }
                if (word[0] == 'E' ||
                    word[0] == 'e' ||
                    word[0] == 'A' ||
                    word[0] == 'a' ||
                    word[0] == 'I' ||
                    word[0] == 'i' ||
                    word[0] == 'O' ||
                    word[0] == 'o' ||
                    word[0] == 'U' ||
                    word[0] == 'u' ||
                    word[0] == 'Y' ||
                    word[0] == 'y')
                {
                    sum *= word.Length;
                }
                else
                {
                    sum /= word.Length;
                }
                if (sum > score)
                {
                    score = sum;
                    powerWord = word;
                }
                sum = 0;
                word= Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {powerWord} - {score}");
        }
    }
}
