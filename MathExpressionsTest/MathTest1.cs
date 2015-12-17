using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KBMath;

namespace MathExpressionsTest
{
    [TestClass]
    public class MathTest1
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            // Arrange
            var mathParser = new MathParser('.');
            var input = "12 + 12";
            var output = 24d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void AddWithDivision()
        {
            // Arrange
            var mathParser = new MathParser('.');
            var input = "(12 + 12) / 3";
            var output = 8d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }
        [TestMethod]
        public void AddWithMultiply()
        {
            // Arrange
            var mathParser = new MathParser('.');
            var input = "( 5 + 5 ) * (3 + 2 )";
            var output = 50d;

            // Act
            var actual = mathParser.Parse(input);

            // Assert
            Assert.AreEqual(output, actual);
        }

    }
}
