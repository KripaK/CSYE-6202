using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Bicycle : WorldClass, ICarbonFootPrint
    {
        private double Amount { get; set; }
        private const int CO2 = 0;
        private double calc;
        public Bicycle(double Amount)
        {
            this.Amount = Amount;
        }
        public double CalculateCarbonFootPrint()
        {
            calc = CO2 * Amount;
            return calc;
            //throw new NotImplementedException();
        }
        public override double Percentage()
        {
            double calc = CalculateCarbonFootPrint();
            double percent = calc/100;
            return percent;
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Bicycle";
        }
    }
}
