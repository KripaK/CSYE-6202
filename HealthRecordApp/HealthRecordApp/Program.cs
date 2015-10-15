namespace HealthRecordApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Gender gender = Gender.Unspecified;
            int weight, height;
            string firstName, lastName, dob;
            bool status;
            System.DateTime birth = System.DateTime.Today;
        // HealthProfileHelper hph = new HealthProfileHelper();
        FIRSTNAME:
            System.Console.WriteLine("First Name: ");
            firstName = System.Console.ReadLine();
            status = HealthProfileHelper.ValidateFirstName(firstName);
            if (status == false)
            {
                System.Console.WriteLine("Invalid first name");
                goto FIRSTNAME;
            }
        LASTNAME:
            System.Console.WriteLine("Last Name: ");
            lastName = System.Console.ReadLine();
            status = HealthProfileHelper.ValidateLastName(lastName);
            if (status == false)
            {
                System.Console.WriteLine("Invalid last name");
                goto LASTNAME;
            }
        GENDER:
            System.Console.WriteLine("Gender: ");
            string choice = System.Console.ReadLine();
       /*     if (choice == "Male")
                gender = Gender.Male;
            else if (choice == "Female")
                gender = Gender.Female;
            else if (choice == "Unspecified")
                gender = Gender.Unspecified; */
            status = HealthProfileHelper.ValidateGender(choice, ref gender);
            if (status == false)
            {
                System.Console.WriteLine("Invalid gender");
                goto GENDER;
            }
            DOB:
            System.Console.WriteLine("Date of birth: ");
            dob = System.Console.ReadLine();
            //System.DateTime dummy = System.DateTime.Parse(dob);
            status = HealthProfileHelper.ValidateDateOfBirth(dob, ref birth);
            if (status == false)
            {
                System.Console.WriteLine("Invalid Date of Birth");
                goto DOB;
            }
            System.DateTime dummy = System.DateTime.Parse(dob);
        HEIGHT:
            int ht=0;
            System.Console.WriteLine("Height: ");
            string dummy1 = System.Console.ReadLine();
            //height = System.Convert.ToInt32(dummy1);
            status = HealthProfileHelper.ValidateHeight(dummy1, ref ht);
            if (status == false)
            { 
                System.Console.WriteLine("Invalid height");
                goto HEIGHT;
            }
            height = System.Convert.ToInt32(dummy1);
        WEIGHT:
            int wt = 0;
            System.Console.WriteLine("Weight: ");
            string dummy2 = System.Console.ReadLine();
            //weight = System.Convert.ToInt32(dummy2);
            status = HealthProfileHelper.ValidateWeight(dummy2, ref wt);
            if (status == false)
            {
                System.Console.WriteLine("Invalid weight");
                goto WEIGHT;
            }
            weight = System.Convert.ToInt32(dummy2);
            HealthProfile hp = new HealthProfile(firstName, lastName, birth, weight, height, gender);
            hp.DisplayPatientProfile();
        }
	}
}
