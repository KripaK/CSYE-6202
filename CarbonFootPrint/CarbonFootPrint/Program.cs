using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount;
            string name;
            List<WorldClass> wc = new List<WorldClass>();
            List<ICarbonFootPrint> cfp = new List<ICarbonFootPrint>();

            Console.WriteLine("Bicycle :"); 
            Console.WriteLine("Enter Name of Owner: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the number of kilometers ridden: ");
            amount = Convert.ToDouble(Console.ReadLine());
            Bicycle bike = new Bicycle(amount);
            bike.Name = name;
            wc.Add(bike);
            cfp.Add(bike);

            Console.WriteLine("\nBuilding :");
            Console.WriteLine("Enter Name of Owner: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the square footage ");
            amount = Convert.ToDouble(Console.ReadLine());
            Building apt = new Building(amount);
            apt.Name = name;
            wc.Add(apt);
            cfp.Add(apt);

            Console.WriteLine("\nCar :");
            Console.WriteLine("Enter Name of Owner: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the gas amount in gallons ");
            amount = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(amount);
            car.Name = name;
            wc.Add(car);
            cfp.Add(car);

            Console.WriteLine("\nSummary Report: ");
            foreach (var i in wc)
            {
                Console.WriteLine("Name: " + i.Name + " Percentage " + i.Percentage());
            }
            foreach (var j in cfp)
            {
                Console.WriteLine("Carbon FootPrint of : " + j + " is " + j.CalculateCarbonFootPrint());
            }
        }
    }
}
