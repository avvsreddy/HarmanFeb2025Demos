using Moq;

namespace SimpleCalcLib.TestProject
{
    //public class MockResultLogger : IResultLogger
    //{
    //    public void SaveResult(int i1, int i2, int result)
    //    {

    //    }
    //}

    // Moq


    [TestClass]


    public sealed class CalculatorTest
    {
        Calculator target = null;
        Moq.Mock<IResultLogger> mockLogger = new Moq.Mock<IResultLogger>();

        [TestInitialize]
        public void TestInit()
        {
            // will execute before every test case ... 


            mockLogger.Setup(ml => ml.SaveResult(1, 1, 1));

            //target = new Calculator(new MockResultLogger());
            target = new Calculator(mockLogger.Object);
        }

        [TestCleanup]
        public void TestClean()
        {
            // will exe after every test case
            target = null;
        }

        [TestMethod]
        public void SumTest_WithValidInput_ShouldReturnValidResult()  // Test Case - +ve -ve
        {
            // AAA
            // A - Arrange
            //Calculator target = new Calculator();
            int input1 = 10;
            int input2 = 20;
            int expected = 30;
            // A - Act
            int actual = target.Sum(input1, input2);
            // A - Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        [ExpectedException(typeof(NegativeInputException))]
        [DataRow(-1, -1)]
        [DataRow(1, -1)]
        [DataRow(-1, 1)]
        public void SumTest_WithAllNegativeInput_ThrowsExp(int a, int b)
        {
            //AAA
            //Calculator target = new Calculator();
            int actual = target.Sum(a, b);

        }

        [TestMethod]
        [ExpectedException(typeof(ZeroInputException))]
        [DataRow(0, 0)]
        [DataRow(0, 1)]
        [DataRow(1, 0)]
        public void SumTest_WithZeroInput_ThrowsExp(int a, int b)
        {
            //AAA
            //Calculator target = new Calculator();
            int actual = target.Sum(a, b);

        }

        [TestMethod]
        [ExpectedException(typeof(OddInputException))]
        [DataRow(1, 3)]
        [DataRow(1, 2)]
        [DataRow(2, 1)]
        public void SumTest_WithOddInput_ThrowsExp(int a, int b)
        {
            //AAA
            //Calculator target = new Calculator();
            int actual = target.Sum(a, b);

        }

        [TestMethod]
        public void SumTest_WithValidInput_ShouldCallSaveResultMethod()
        {
            target.Sum(2, 4);
            mockLogger.Verify(m => m.SaveResult(2, 4, 6), Times.Once());

        }
    }
}
