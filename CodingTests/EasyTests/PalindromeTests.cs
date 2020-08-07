using NUnit.Framework;
using Palindrome;

namespace CodingTests
{
    public class PalindromeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Palindrome_TestNaive()
        {
            //Arrange
            FindPalindrome fp = new FindPalindrome();

            //Act
            bool result = fp.NaivePalindrome("abcdcba");
            bool result2 = fp.IsPalindromeSolutionTwo("abcdcba");
            bool result3 = fp.IsPalindromeRecursive("abcdcba");
            bool result4 = fp.IsPalindrome("abcdcba");
            //Assert
            Assert.That(result, Is.True);
            Assert.That(result2, Is.True);
            Assert.That(result3, Is.True);
            Assert.That(result4, Is.True);

        }
    }
}
