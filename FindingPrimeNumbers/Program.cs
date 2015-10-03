using System;
namespace FindingPrimeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
            int num;
            int sum;
            FindingPrimeNumbers f = new FindingPrimeNumbers();
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = f.FindSumOfPrimeNumbers(num);
            Console.WriteLine(sum);
        }
	}
}
																																																		