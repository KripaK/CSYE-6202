namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            // your solution/implementation should go in here
            if (number > 0)
            {

                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0)
                {
                    return "Fizz";
                    //     break;
                }
                else if (number % 5 == 0)
                {
                    return "Buzz";
                    //       break;
                }
                else
                    return result;
            }
            else
                return result;

          //  return result;
		}
	}
}
