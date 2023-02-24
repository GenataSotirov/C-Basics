using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main()
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            double result = 0;

            switch (sign)
            {
                case '+':
                    result = numOne + numTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} + {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} + {numTwo} = {result} - odd");
                    }
                    break;
                case '-':
                    //if (numTwo > numOne)
                    //{
                        //double temp = numOne;
                        //numOne = numTwo;
                        //numTwo = temp;
                    //}
                    result = numOne - numTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} - {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} - {numTwo} = {result} - odd");
                    }
                    break;
                case '*':
                    result = numOne * numTwo;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} * {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} * {numTwo} = {result} - odd");
                    }
                    break;
                case '/':
                    if (numTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numOne} by zero");
                    }
                    else
                    {
                        result = numOne / numTwo;
                        Console.WriteLine($"{numOne} / {numTwo} = {result:f2}");
                    }
                    break;
                case '%':
                    if (numTwo == 0)
                    {
                        Console.WriteLine($"Cannot divide {numOne} by zero");
                    }
                    else
                    {
                        result = numOne % numTwo;
                        Console.WriteLine($"{numOne} % {numTwo} = {result}");
                    }
                    break;       
                default:
                    break;
            }
        }
    }
}
