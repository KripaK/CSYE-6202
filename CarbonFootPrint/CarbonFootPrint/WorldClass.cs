using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    abstract public class WorldClass
    {
        public string Name { get; set; }
        public abstract double Percentage();
    }
}
