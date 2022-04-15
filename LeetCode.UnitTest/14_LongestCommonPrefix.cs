using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _14_SolutionTests
    {
        _14_Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new _14_Solution();
        }

        [Test]
        public void Example1Test()
        {
            // Arrange
            var strs = new string[] { "flower", "flow", "flight" };

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("fl", result);
        }

        [Test]
        public void Example2Test()
        {
            // Arrange
            var strs = new string[] { "dog", "racecar", "car" };

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("", result);
        }

        [Test]
        public void Example3Test()
        {
            // Arrange
            var strs = new string[] { "a" };

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("a", result);
        }

        [Test]
        public void Example4Test()
        {
            // Arrange
            var strs = new string[] { "ab", "a" };

            // Act
            var result = solution.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual("a", result);
        }
    }
}
