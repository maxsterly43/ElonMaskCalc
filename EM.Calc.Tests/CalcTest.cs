using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EM.Calc.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            // arrange
            var calc = new Core.Calc();
            var sum = 10;

            // act
            var result = calc.Sum(new double[] { 5, 3, 2 });

            // assert
            Assert.AreEqual(sum, result);
        }
        [TestMethod]
        public void TestSub()
        {
            // arrange
            var calc = new Core.Calc();
            var sub = -12;

            // act
            var result = calc.Sub(new double[] { 5, 3, 14 });

            // assert
            Assert.AreEqual(sub, result);
        }
        [TestMethod]
        public void TestPow()
        {
            // arrange
            var calc = new Core.Calc();
            var pow = 15625;

            // act
            var result = calc.Pow(new double[] { 5, 3, 2 });

            // assert
            Assert.AreEqual(pow, result);
        }
        [TestMethod]
        public void TestExecuteMul()
        {
            // arrange
            var calc = new Core.Calc();
            var pow = 30;

            // act
            var result = calc.Execute("mul", new double[] { 5, 3, 2 });

            // assert
            Assert.AreEqual(pow, result);
        }
    }
}