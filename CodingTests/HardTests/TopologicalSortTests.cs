using NUnit.Framework;
using System.Collections.Generic;
using TopologicalSort;

namespace CodingTests.HardTests
{
    public class TopologicalSortTests
    {
        [Test]
        public void TopologicalSort_Graph()
        {
            //Arrange
            TopologicalSortAlgorithm<int> tsa = new TopologicalSortAlgorithm<int>();
            List<int> jobs = new List<int> { 1, 2, 3, 4 };
            List<(int, int)> deps = new List<(int, int)> { (1, 2), (1, 3), (3, 2), (4, 2), (4, 3) };

            //Act
            JobGraph<int> jobsGraph = tsa.CreateJobGraph(jobs, deps);
            List<int> orders = tsa.GetOrderedJobs(jobsGraph);

            //Assert
            Assert.That(orders, Is.EqualTo(new List<int> { 1, 4, 3, 2 }));
        }

    }
}
