using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace _01._Old_Books
{
    class Program
    {
        static void Main()
        {
            string wantedBook = Console.ReadLine();
            bool bookFounded = false;
            int count = 0;
            string bookName = Console.ReadLine();

            while (bookName != "No More Books")
            {
                if (bookName == wantedBook)
                {
                    bookFounded = true;
                    break;
                }
                count++;
                bookName = Console.ReadLine();
            }
            if (bookFounded)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
   