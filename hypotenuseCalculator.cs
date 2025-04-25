using System;

namespace HypotenuseCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hypotenuse calculator\n");

            Console.WriteLine("Type the A side: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the B side: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Your hypotenuse is: {c}");
        }
    }
}
