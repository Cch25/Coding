using Fibonacci;
using NUnit.Framework; 

namespace CodingTests
{
    public class FibonacciTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Fibonacci_NaiveTest_ReturnsSixthNumber()
        {
            FibonacciImplementation fibonacci = new FibonacciImplementation();
            int result = fibonacci.FibonacciNaive(6);
            Assert.AreEqual(result, 5);
        }


        [Test]
        public void Fibonacci_MemoizeTest_ReturnsSixthNumber()
        {
            FibonacciImplementation fibonacci = new FibonacciImplementation();
            int result = fibonacci.FibonacciMemoize(6,new System.Collections.Generic.Dictionary<int, int>());
            fibonacci.FibonacciMemoizeV2(6, new System.Collections.Generic.Dictionary<int, int>());
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void Fibonacci_OptimizedTest_ReturnsSixthNumber()
        {
            FibonacciImplementation fibonacci = new FibonacciImplementation();
            int result = fibonacci.FibonacciOptimized(6);
            Assert.AreEqual(result, 5);
        }
    }
}
