using StrategyPattern.Context;
using StrategyPattern.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static CalculatorContext context;
        static void Main(string[] args)
        {
            while (true)
            {
                context = new CalculatorContext();
                Console.WriteLine("Hello, welcome to the Strategy Pattern PoC.");
                Console.WriteLine("Please, select your Calculation method:");
                Console.WriteLine(Environment.NewLine + "1 - Addition");
                Console.WriteLine(Environment.NewLine + "2 - Subtraction");
                Console.WriteLine(Environment.NewLine + "3 - Multiplication");
                var inputChoice = Convert.ToInt32(Console.ReadLine());
                var strategy = context.GetCorrectStrategy(inputChoice);
                if (strategy == "AdditionStrategy")
                {
                    context.SetStrategy(new AdditionStrategy());
                }
                else if (strategy == "SubtractionStrategy")
                {
                    context.SetStrategy(new SubtractionStrategy());
                }
                else if (strategy == "MultiplicationStrategy")
                {
                    context.SetStrategy(new MultiplicationStrategy());
                }

                Console.WriteLine("Please, enter enter in the first number");
                var firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, enter enter in the second number");
                var secondNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Answer:");
                Console.WriteLine(context.ExecuteStrategy(firstNumber, secondNumber));
            }

        }
    }
}
