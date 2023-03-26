using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_WhenCalled_ReturnsSumOfArguments()
        {
          
            int a = 2;
            int b = 3;

           
            int result = _calculator.Additional(a, b);

           
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtraction_WhenCalled_ReturnsDifferenceOfArguments()
        {
            
            int a = 5;
            int b = 2;

            
            int result = _calculator.Subtraction(a, b);

           
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Miltiplication_WhenCalled_ReturnsProductOfArguments()
        {
           
            int a = 2;
            int b = 3;

           
            int result = _calculator.Miltiplication(a, b);

            
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Division_WhenCalledWithNonZeroDivider_ReturnsQuotientOfArguments()
        {
            
            int a = 6;
            int b = 2;

            
            int result = _calculator.Division(a, b);

            
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Division_WhenCalledWithZeroDivider_ThrowsDivideByZeroException()
        {
            
            int a = 6;
            int b = 0;

            
            Assert.Throws<DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}
