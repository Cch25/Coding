using NUnit.Framework;
using ThreeLargestNumbers;

namespace CodingTests
{
    public class ThreeLargestNumbersTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ThreeLargestNumbers_ShouldReturnFirstThreeGreatest()
        {
            //Arrange
            ThreeLargestNo tln = new ThreeLargestNo();

            //Act
            ulong[] result = tln.FindThreeLargestNumbers(new ulong[] { 141, 1, 17, 4, 3, 12, 18, 541, 8, 1, 2 });

            //Assert
            Assert.That(result, Is.EqualTo(new ulong[] { 18, 141, 541 }));
        }
    }
}
