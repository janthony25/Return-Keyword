using System;

namespace Return
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  return = returns data back to the place where a method is invoked

            double x;
            double y;
            double result;

            Console.WriteLine("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine($"{x} * {y} is: {result}");

            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            /*
            double z = x * y;
            return z;
            */

            return x * y;
        }
    }
}