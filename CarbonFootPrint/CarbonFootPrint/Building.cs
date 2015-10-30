using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Building : WorldClass , ICarbonFootPrint
    {
        private double Amount { get; set; }
        private const int CO2 = 50;
        private double calc;
        public Building(double Amount)
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
            double percent = calc/(100*Amount);
                return percent;
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Building";
        }
    }
}
