using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main()
        {
            string fuel = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double price = 0;

            if (fuel == "Gasoline")
            {
                if (volume > 25)
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.04 - volume * 2.04 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.22 - volume * 2.22 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                }
                else if (volume >= 20)
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.04 - volume * 2.04 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.22 - volume * 2.22 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                }
                else
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.04;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.22;
                        Console.Write("{0:f2}", price);
                    }
                }
            }
            else if (fuel == "Diesel")
            {
                if (volume > 25)
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.21 - volume * 2.21 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.33 - volume * 2.33 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                }
                else if (volume >= 20)
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.21 - volume * 2.21 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.33 - volume * 2.33 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                }
                else
                {
                    if (card == "Yes")
                    {
                        price = volume * 2.21;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 2.33;
                        Console.Write("{0:f2}", price);
                    }
                }
            }
            else if (fuel == "Gas")
            {
                if (volume > 25)
                {
                    if (card == "Yes")
                    {
                        price = volume * 0.85 - volume * 0.85 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 0.93 - volume * 0.93 * 0.1;
                        Console.Write("{0:f2}", price);
                    }
                }
                else if (volume >= 20)
                {
                    if (card == "Yes")
                    {
                        price = volume * 0.85 - volume * 0.85 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 0.93 - volume * 0.93 * 0.08;
                        Console.Write("{0:f2}", price);
                    }
                }
                else
                {
                    if (card == "Yes")
                    {
                        price = volume * 0.85;
                        Console.Write("{0:f2}", price);
                    }
                    else
                    {
                        price = volume * 0.93;
                        Console.Write("{0:f2}", price);
                    }
                }
            }
            Console.WriteLine(" lv.");
        }
    }
}
