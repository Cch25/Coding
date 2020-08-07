using NUnit.Framework;
using Questions.MoveElementToEnd;

namespace CodingTests.QuestionTests
{
    public class MoveToEndTests
    {
        [Test]
        public void MoveToEnd_Test()
        {
            MoveToEnd mte = new MoveToEnd();
            int[] result = mte.MoveElementToEnd(new int[] { 2, 1, 2, 2, 2, 3, 4, 2 }, 2);
            int[] result1 = mte.MoveElementToEndDifferentSolution(new int[] { 2, 1, 2, 2, 2, 3, 4, 2 }, 2);

            Assert.That(result, Is.EqualTo(new int[] { 1, 3, 4, 2, 2, 2, 2, 2 }));
            Assert.That(result1, Is.EqualTo(new int[] { 4, 1, 3, 2, 2, 2, 2, 2 }));
        }
    }
}
