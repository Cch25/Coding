using NUnit.Framework;
using WaysToMakeChange;

namespace CodingTests.QuestionTests
{
    public class WaysToMakeChangeTests
    {
        [Test]
        public void WaysToMakeChange()
        {
            WaysToMakeAChange wmc = new WaysToMakeAChange();
            int result = wmc.WaysToChange(new int[] { 1, 5, 10, 25 }, 12);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
