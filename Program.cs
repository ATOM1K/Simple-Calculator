using System;

namespace StupidCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Enter first value: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second value: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("It's not a number!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Choose operation of calculate: ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine("Result of + :" + (firstValue + secondValue));
                        break;
                    case "-":
                        Console.WriteLine("Result of - :" + (firstValue - secondValue));
                        break;
                    case "*":
                        Console.WriteLine("Result of * :" + (firstValue * secondValue));
                        break;
                    case "/":
                        Console.WriteLine("Result of / :" + (firstValue / secondValue));
                        break;
                    default:
                        Console.WriteLine("This is not operation");

                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
