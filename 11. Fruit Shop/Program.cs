using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Calculated(double volume, double[]arr, string fruit)
        {
            double price = 0;
            switch (fruit)
            {
                case "banana":
                    price = volume * arr[0];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "apple":
                    price = volume * arr[1];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "orange":
                    price = volume * arr[2];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "grapefruit":
                    price = volume * arr[3];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "kiwi":
                    price = volume * arr[4];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "pineapple":
                    price = volume * arr[5];
                    Console.WriteLine("{0:f2}", price);
                    break;
                case "grapes":
                    price = volume * arr[6];
                    Console.WriteLine("{0:f2}", price);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());

            double[] weekend = { 2.70, 1.25, 0.90, 1.60, 3, 5.6, 4.2 };
            double[] workDay = { 2.5, 1.2, 0.85, 1.45, 2.7, 5.5, 3.85};

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Calculated(volume, workDay,fruit);
                    break;
                case "Saturday":
                case "Sunday":
                    Calculated(volume, weekend,fruit);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
