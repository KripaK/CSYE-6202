using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        static void Main(string[] args)
        {
            // your implementation here
            String choice1, choice2;  
            bool status=false, validGas=false, validAmount;
            double totalCost=0.0;
            GasType gasType = GasType.None;
            do
            {
                Console.WriteLine("Please enter purchased gas type, Q/q to quit: ");
                choice1 = Console.ReadLine();
                status = UserEnteredSentinelValue(choice1);
                validGas = UserEnteredValidGasType(choice1);
                if (validGas==true)
                {
                    gasType = GasTypeMapper(Convert.ToChar(choice1));
                    Console.WriteLine("Please enter purchased gas amount, Q/q to quit: ");
                    choice2 = Console.ReadLine();
                    status = UserEnteredSentinelValue(choice2);
                    validAmount = UserEnteredValidAmount(choice2);
                    if (validAmount==true)
                    {
                        CalculateTotalCost(gasType, Convert.ToInt32(choice2), ref totalCost); 
                    }
                    else
                    {
                        Console.WriteLine("Not valid amount");
                        break;
                    }
                }
           //     else
           //     {
            //        Console.WriteLine("Not Valid Type");
            //        break;
             //   }
            } while (status!=true);
        }

        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            // your implementation here
            if (String.Compare(userInput, "q") == 0 || String.Compare(userInput, "Q") == 0)
            {
                Console.WriteLine("Application Terminated");
                result = true;
            }

                return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;
            if (String.Compare(userInput, "r") == 0 || String.Compare(userInput, "R") == 0 || String.Compare(userInput, "d") == 0||String.Compare(userInput, "D") == 0||String.Compare(userInput, "m") == 0 || String.Compare(userInput, "M") == 0 || String.Compare(userInput, "p") == 0 || String.Compare(userInput, "P") == 0)
            {
                result = true;
            }
                // your implementation here

                return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;
            Double number;
            if (Double.TryParse(userInput, out number))
            {
                result = true;
            }
                // your implementation here

                return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;
            if(c=='r' || c == 'R')
            {
                gasType = GasType.RegularGas;
            }
            else if (c == 'd' || c == 'D')
            {
                gasType = GasType.DieselFuel;
            }
            else if (c == 'p' || c == 'P')
            {
                gasType = GasType.PremiumGas;
            }
            else if (c == 'm' || c == 'M')
            {
                gasType = GasType.MidgradeGas;
            }
            else
            {
                gasType = GasType.None;
            }
            // your implementation here

            return gasType;
		}
    
		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;
            if (gasType == GasType.RegularGas)
            {
                result = 1.94;
            }
            else if (gasType == GasType.PremiumGas)
            {
                result = 2.24;
            }
            else if (gasType == GasType.MidgradeGas)
            {
                result = 2.00;
            }
            else if (gasType == GasType.DieselFuel)
            {
                result = 2.17;
            }
            else
            {
                result = 0.0;
            }
            // your implementation here

            return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            // your implementation here
            double cost = GasPriceMapper(gasType);
            Console.WriteLine("You bought " + gasAmount + " gallons of " + gasType + " at " + cost);
            totalCost = cost * gasAmount;
            Console.WriteLine("Your total cost for this purchase is: " + totalCost);
        }
	}
}
