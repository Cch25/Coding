using NUnit.Framework;
using SmallestDifference;
using System.Collections.Generic;

namespace CodingTests.EasyTests
{
    public class SmallestDifferenceTests
    {
        [Test]
        public void SmallestDifference_FindSmallestPair()
        {
            SmallestDif sd = new SmallestDif();
            (int, int) result = sd.SmallestDifference(new List<int> { -1, 5, 10, 20, 28, 3 },
                new List<int> { 26, 134, 135, 15, 17 });
            Assert.That(result, Is.EqualTo((28, 26)));
        }
    }
}
