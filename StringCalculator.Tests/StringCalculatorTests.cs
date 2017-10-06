using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("",0)]
        [TestCase("1",1)]
        [TestCase("1,2",3)]
        [TestCase("1,2,3",6)]
        [TestCase("1\n2,3",6)]
        public void Test(string value, int result)
        {
            StringCalculator calculator = new StringCalculator();
            int test_result = calculator.Add(value);

            Assert.AreEqual(test_result,result);
        }
    }
}
