using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _20_SolutionTests
    {
        _20_Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new _20_Solution();
        }

        [Test]
        public void Example1Test()
        {
            // Arrange
            var s = "()";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Example2Test()
        {
            // Arrange
            var s = "()[]{}";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Example3Test()
        {
            // Arrange
            var s = "(]";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Example4Test()
        {
            // Arrange
            var s = "([{}])";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Example5Test()
        {
            // Arrange
            var s = "([{)}]";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Example6Test()
        {
            // Arrange
            var s = "]";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Example7Test()
        {
            // Arrange
            var s = "[[[]";

            // Act
            var result = solution.IsValid(s);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
