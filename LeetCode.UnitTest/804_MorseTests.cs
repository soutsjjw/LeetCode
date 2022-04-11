using NUnit.Framework;

namespace LeetCode.UnitTest
{
    public class _804_SolutionTests
    {
        _804_Solution morse;

        [SetUp]
        public void Setup()
        {
            morse = new _804_Solution();
        }

        [Test]
        public void StringArrayTest()
        {
            // Arrange
            var words = new string[] { "gin", "zen", "gig", "msg" };

            // Act
            var result = morse.UniqueMorseRepresentations(words);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void OneLetterTest()
        {
            // Arrange
            var words = new string[] { "a" };

            // Act
            var result = morse.UniqueMorseRepresentations(words);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Example1Test()
        {
            // Arrange
            var words = new string[] { "noilq", "kzlq", "ydreq", "ybxk", "kzlq" };

            // Act
            var result = morse.UniqueMorseRepresentations(words);

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}