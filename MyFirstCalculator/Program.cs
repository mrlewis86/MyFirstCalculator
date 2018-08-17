using System;

namespace MyFirstCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2;

            do
            {
                num1 = UI.GetIntegerFromUser("Give me a number!");

                num2 = UI.GetIntegerFromUser("Time for a SECOND number!!");
                if (num2 == 0)
                {
                    Console.WriteLine("Cant divide by 0 chump!!!");
                    Console.WriteLine("Start Over!!!");
                }
            } while (num2 == 0);

            Console.WriteLine("Thanks buddy, your results are listed below");

            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            float div = num1 / num2;
            int rem = num1 % num2;

            Console.WriteLine("Addition\t\t" + add);
            Console.WriteLine("Subtraction\t\t" + sub);
            Console.WriteLine("Multiplication\t\t" + mul);
            Console.WriteLine("Division\t\t" + div);
            Console.WriteLine("Remainder\t\t" + rem);

            Console.ReadLine();




        }
    }
}
