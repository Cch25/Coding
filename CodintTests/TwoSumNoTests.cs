using NUnit.Framework;
using TwoNumberSum;

namespace CodingTests
{
    public class TwoSumNoTests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region [ Two numbers sum ]
        [Test]
        [TestCase(new[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10)]
        [TestCase(new[] { 0, 2, -2, 3, 5, 11, 4, -3 }, 8)]
        [TestCase(new[] { -13, -15, 20, 21, 15, 8, 12, 9 }, 41)]

        public void TwoNoSum_RetrievesSumOfTwoNumbers_ShouldBeEqualsToTarget(int[] array, int target)
        {   
            //Arrange
            TwoNoSum twoNoSum = new TwoNoSum();

            //Act
            (int LeftS1, int RightS1) = twoNoSum.SolutionOne(array, target);
            (int LeftS2, int RightS2) = twoNoSum.SolutionTwo(array, target);
            (int LeftS3, int RightS3) = twoNoSum.SolutionThree(array, target);

            //Assert
            Assert.AreEqual(LeftS1 + RightS1, target);
            Assert.AreEqual(LeftS2 + RightS2, target);
            Assert.AreEqual(LeftS3 + RightS3, target);

        }
        #endregion
    }
}