using System;

namespace RectangleMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char symbol;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rectangle Maker\n");

                Console.Write("Type the A side: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Type the B side: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Choose your symbol: ");
                symbol = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                if (a == b)
                {
                    Console.WriteLine("\nTHAT'S A SQUARE!");
                    Console.WriteLine("Press Enter to try again...");
                    Console.ReadLine();
                }

            } while (a == b);

            Console.WriteLine(); 

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
