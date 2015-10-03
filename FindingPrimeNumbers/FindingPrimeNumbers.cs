using System;
namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
		public int FindSumOfPrimeNumbers(int num)
		{
            int n = 3, j, sum = 2;
            if (num == 0)
            {
                sum = 0;
            }
            if (num == 1)
            {
                sum = 2;
            }

            for (int i = 2; i <= num;)
            {
                for (j = 2; j <= n - 1; j++)
                {
                    if (n % j == 0)
                        break;
                }
                if (j == n)
                {
                    //Console.WriteLine("\n" + n);
                    i++;
                    sum = sum + n;
                }
                n++;
            }
            return sum;
            // your solution goes in here


        }
	}
}
