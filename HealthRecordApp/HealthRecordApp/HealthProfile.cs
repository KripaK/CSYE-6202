using System;

namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}

	public class HealthProfile
	{
		private const int UnknownValue = -1;
        int weight, height;
        string firstName, lastName, dateob;
        System.DateTime dob;
        Gender gender;
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int WeightInPounds
        {
            get { return weight; }
            set { weight = (value); }
        }
        public int HeightInInches
        {
            get { return height; }
            set { height = value; }
        }
        public System.DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public HealthProfile()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            weight = 0;
            height = 0;
            gender = Gender.Unspecified;
            dob = System.DateTime.Now;
        }
        public HealthProfile(string firstName, string lastName, System.DateTime dob, int weight, int height, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weight = weight;
            this.height = height;
            this.dob = dob;
            this.gender = gender;
        }
		#region Methods

		public int CalculateAge()
		{

           int age= System.DateTime.Today.Year-dob.Year;
            if (age>=0)
            {
                return age;
            }
            else
            {
                return UnknownValue;
            }
		}

		public int CalculateMaxHeartRate()
		{
            int age = CalculateAge();
            if (age >= 0)
            {
                int heartRate = 220 - age;
                return heartRate;
            }
            else
            {
                return UnknownValue;
            }
		}

		public decimal CalculateBMI()
		{
            decimal wt = System.Convert.ToDecimal(weight);
            decimal ht = System.Convert.ToDecimal(height);
            decimal bmi = (wt * 703) / (ht * ht);
            if (bmi > 0)
            {
                return System.Math.Round(bmi,2);
            }
            else
            {
                return UnknownValue;
            }
		}

		public void DisplayPatientProfile()
		{
            decimal bmi = CalculateBMI();
            System.Console.WriteLine("Displaying Patient's Profile: ");
            System.Console.WriteLine("==============================");
            System.Console.WriteLine("First Name: " + firstName);
            System.Console.WriteLine("Last Name: "+ lastName);
            System.Console.WriteLine("Gender: " + gender);
            //string dummy=
            System.Console.WriteLine("Date of birth: " + dob.ToShortDateString());
            System.Console.WriteLine("Height: " + height + " inches");
            System.Console.WriteLine("Weight: " + weight + " pounds");
            System.Console.WriteLine("Age: " + CalculateAge());
            System.Console.WriteLine("Max Heart Rate: " + CalculateMaxHeartRate());
            System.Console.WriteLine("BMI: " + bmi.ToString("N"));
        }


        #endregion
    }
}
