using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _9_SolutionTests
    {
        _9_Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new _9_Solution();
        }

        [TestCase(121)]
        [TestCase(0)]
        [TestCase(11)]
        [TestCase(1001)]
        public void True_Test(int x)
        {
            // Act & Assert
            Assert.IsTrue(solution.IsPalindrome(x));
        }

        [TestCase(-121)]
        [TestCase(10)]
        [TestCase(100)]
        public void False_Test(int x)
        {
            // Act & Assert
            Assert.IsFalse(solution.IsPalindrome(x));
        }
    }
}
