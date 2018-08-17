using System;

namespace MyFirstCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2;

            int add; int sub; int mul;

            float div; int rem;

            do
            {
                Console.WriteLine("Give me a number!");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Time for a SECOND number!!");

                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Cant divide by 0 chump!!!");
                    Console.WriteLine("Start Over!!!");
                }
            } while (num2 == 0);

            Console.WriteLine("Thanks buddy, your results are listed below");

            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            rem = num1 % num2;

            Console.WriteLine("Addition\t\t" + add);
            Console.WriteLine("Subtraction\t\t" + sub);
            Console.WriteLine("Multiplication\t\t" + mul);
            Console.WriteLine("Division\t\t" + div);
            Console.WriteLine("Remainder\t\t" + rem);

            Console.ReadLine();




        }
    }
}
