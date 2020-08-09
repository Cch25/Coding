using NUnit.Framework;
using WaysToMakeChange;

namespace CodingTests.QuestionTests
{
    public class WaysToMakeChangeTests
    {
        [Test]
        public void WaysToMakeChange()
        {
            //Arrange
            WaysToMakeAChange wmc = new WaysToMakeAChange();

            //Act
            int result = wmc.WaysToChange(new int[] { 1, 5, 10, 25 }, 12);

            //Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void MinNumsToMakeChange()
        {
            //Arrange
            WaysToMakeAChange wmc = new WaysToMakeAChange();

            //Act
            int result = wmc.MinNumsOfCoinsToChange(new int[] { 1, 2, 4 }, 6);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
