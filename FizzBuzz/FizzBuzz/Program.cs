using System;
namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
            FizzBuzz f = new FizzBuzz();
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            String value = f.RunFizzBuzz(number);
            Console.WriteLine(value);
        }
	}
}
