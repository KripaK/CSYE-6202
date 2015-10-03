using System;
namespace BoxingWeights
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Enter Weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            BoxingWeightClassifier c = new BoxingWeightClassifier();
            string type = c.ClassifyBoxingWeight(weight);    
            Console.WriteLine(type);
        }
	}
}
