using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        public void SetUp()
        {
            cal = new Calculator.Calculation(3, 4);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            Assert.AreEqual(cal.Execute("+"), 7);
        }
        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(cal.Execute("-"), -1);
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(cal.Execute("*"), 12);
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(cal.Execute("/"), 0);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
        
    }
}
