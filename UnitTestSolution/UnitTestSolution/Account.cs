using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSolution
{
    public class Account
    {
        public string Name { get; set; }
        public float Balance { get; set; }

        public Account(string name, float balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public void WithDraw(float withdrawAmount)
        {
            if (Balance >= withdrawAmount)
            {
                Balance -= withdrawAmount;
            }
            else
            {
                throw new ArgumentException("Not enough money");
            }
        }
    }
}
