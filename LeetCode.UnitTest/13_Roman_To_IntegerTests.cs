using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _13_SolutionTests
    {
        _13_Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new _13_Solution();
        }

        [Test]
        public void Three_Test()
        {
            // Arrange
            var s = "III";

            // Act
            var result = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Fifty_Eight_Test()
        {
            // Arrange
            var s = "LVIII";

            // Act
            var result = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(58, result);
        }

        [Test]
        public void One_Thousand_Nine_Hundred_Ninety_Four_Test()
        {
            // Arrange
            var s = "MCMXCIV";

            // Act
            var result = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(1994, result);
        }

        [Test]
        public void One_Thousand_Four_Hundred_Seventy_Six_Test()
        {
            // Arrange
            var s = "MCDLXXVI";

            // Act
            var result = solution.RomanToInt(s);

            // Assert
            Assert.AreEqual(1476, result);
        }
    }
}
