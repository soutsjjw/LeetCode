using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _1_SolutionTests
    {
        _1_Solution solution;

        [SetUp]
        public void Setup()
        {
            solution = new _1_Solution();
        }

        [Test]
        public void Example1Test()
        {
            // Arrange
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            // Act
            var result = solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(target, nums[result[0]] + nums[result[1]]);
        }

        [Test]
        public void Example2Test()
        {
            // Arrange
            var nums = new int[] { 3, 2, 4 };
            var target = 6;

            // Act
            var result = solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(target, nums[result[0]] + nums[result[1]]);
        }

        [Test]
        public void Example3Test()
        {
            // Arrange
            var nums = new int[] { 3, 3 };
            var target = 6;

            // Act
            var result = solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(target, nums[result[0]] + nums[result[1]]);
        }

        [Test]
        public void Example4Test()
        {
            // Arrange
            var nums = new int[] { 2, 5, 5, 11 };
            var target = 10;

            // Act
            var result = solution.TwoSum(nums, target);

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(target, nums[result[0]] + nums[result[1]]);
        }
    }
}
