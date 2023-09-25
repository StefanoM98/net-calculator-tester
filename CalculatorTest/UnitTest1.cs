using net_calculator_tester;

namespace CalculatorTest
{
    public class Tests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        
        public void TestAddFloat()
        {
            float x = 2.4f;
            float y = 5.4f;

            float realOutput = 7.8f;
            float sum = calculator.Add(x, y);

            Assert.IsTrue(realOutput == sum, $"Il risultato atteso era {realOutput}, mentre invece abbiamo {sum}" );
        }

        [Test]

        public void TestSubtractFloat()
        {
            float x = 6.4f;
            float y = 2.4f;

            float realOutput = 4.0f;
            float subtract = calculator.Subtract(x, y);

            Assert.AreEqual(realOutput, subtract);
        }

        [Test]

        public void TestDivideFloat()
        {
            float x = 10.0f;
            float y = 2.0f;

            float realOutput = 5.0f;
            float divided = calculator.Divide(x, y);

            Assert.AreEqual(realOutput, divided);
        }

        [Test]

        public void TestMultiplyFloat()
        {
            float x = 10.0f;
            float y = 2.0f;

            float realOutput = 20.0f;
            float multiplied = calculator.Multiply(x, y);

            Assert.AreEqual(realOutput, multiplied);
        }


    }
}