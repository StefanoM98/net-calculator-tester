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

        
    }
}