using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestPractice;


namespace UnitTestPractice2
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Testsuma()
        {
            // Arrange
            var sum = new Operations();
            int [] arrayNum = { 5, 1 };
            string[] arrayStr = { "+" };
            var expectedResult = 6;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void Testres()
        {
            // Arrange
            var sum = new Operations();
            int[] arrayNum = { 5, 1 };
            string[] arrayStr = { "-" };
            var expectedResult = 4;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void Testmul()
        {
            // Arrange
            var sum = new Operations();
            int[] arrayNum = { 5, 1 };
            string[] arrayStr = { "*" };
            var expectedResult = 5;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void Testdiv()
        {
            // Arrange
            var sum = new Operations();
            int[] arrayNum = { 6, 2 };
            string[] arrayStr = { "/" };
            var expectedResult = 3;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void Testmultiple()
        {
            // Arrange
            var sum = new Operations();
            int[] arrayNum = { 5, 1, 4,8 };
            string[] arrayStr = { "+","*","/" };
            var expectedResult = 3;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TesttoMuch()
        {
            // Arrange
            var sum = new Operations();
            int[] arrayNum = { 5, 1, 4, };
            string[] arrayStr = { "+"};
            var expectedResult = 0;

            // Act
            var result = sum.DoOperation(arrayNum, arrayStr);

            // Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
