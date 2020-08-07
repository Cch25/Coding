using NUnit.Framework;
using ProductSum;

namespace CodingTests
{
    public class ProductSumTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ProductSum_RecursiveCall()
        {
            //Arrange
            ProdSum prodSum = new ProdSum();
            
            //Act - [5,2[7,-1],3,[6,[-13,8],4]]
            object[] arr = new object[] { 5, 2, new object[] { 7, -1 }, 3, new object[] { 6, new object[] { -13, 8 }, 4 } };
            int result = prodSum.ProductSum(arr);
           
            //Assert
            Assert.That(result, Is.EqualTo(12));
        }
    }
}
