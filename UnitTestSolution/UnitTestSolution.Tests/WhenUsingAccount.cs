using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSolution.Tests
{
    [TestFixture]
    public class WhenUsingAccount
    {
        [Test]
        public void WithDraw_ValidAmount_ShouldPass()
        {
            //arrange
            float currentBalance = 10f;
            float withdrawalAmount = 1f;
            float expected = 9f;
            var Account = new Account("Bruce Wayne", currentBalance);

            //act
            Account.WithDraw(withdrawalAmount);

            float actual = Account.Balance;
            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
