using System;

namespace HealthRecordApp
{
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                return false;
            } 
            else
            {
                return true;
            }
		}

		public static bool ValidateLastName(string lastName)
		{
            if(string.IsNullOrEmpty(lastName) || string.IsNullOrWhiteSpace(lastName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{   
            if(string.Compare(enteredGender,Enum.GetName(typeof(Gender),0))==0 || string.Compare(enteredGender, Enum.GetName(typeof(Gender), 1))==0 || string.Compare(enteredGender,Enum.GetName(typeof(Gender),2))==0)
            {
                patientGender = (Gender)Enum.Parse(typeof(Gender), enteredGender);
                return true;
            }
            else
            {
                return false;
            }
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
            if (DateTime.TryParse(enteredDOB, out patientDOB))
            {
                if (patientDOB < DateTime.Now)
                {
                    return true;
                }
                else
                {
                    patientDOB = DateTime.MinValue;
                    return false;
                }
            }
            else
                return false;
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
          //  int ht = System.Convert.ToInt32(heightInString);
           // System.Console.WriteLine(ht);
            if (int.TryParse(heightInString, out patientHeight))
            {
                int ht = System.Convert.ToInt32(heightInString);
                if (ht > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
           // int wt = System.Convert.ToInt32(weightInString);
                if (int.TryParse(weightInString, out patientWeight))
                {
                    int wt = System.Convert.ToInt32(weightInString);
                if (wt > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            else
                return false;
        }
	}
}
