using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            // your implementation here
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

		static void DisplayPatternB()
		{
            // your implementation here
            for (int i = 10; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

		static void DisplayPatternC()
		{
            // your implementation here
            int space = 0;
            for (int i = 10; i >= 1; i--)
            {
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                ++space;
            }
        }

		static void DisplayPatternD()
		{
            // your implementation here
            int space = 9;  
            for (int i = 1; i <= 10; i++)
            {
                for (int k = space; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                --space;
            }
        }
	}
}
