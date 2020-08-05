using DepthFirstSearch;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingTests
{
    class DepthFirstSearchTests
    {
        public DepthFirstSearchImplementation Graph { get; private set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TraverseRecursively()
        {
            //Arrange
            Graph = new DepthFirstSearchImplementation();

            //Act
            List<string> traverseArrayRecursive = Graph.TraverseDFSRecursively(InitializeTree().First(), new List<string>());

            //Assert
            Assert.AreEqual(traverseArrayRecursive, new List<string> { "A", "B", "F", "I", "J", "E", "C", "D", "G", "K", "H" });
        }

        [Test]
        public void TraverseIteratively()
        {
            //Arrange
            Graph = new DepthFirstSearchImplementation();

            //Act
            List<string> traverseArrayIterative = Graph.TraverseDFSIteratively(InitializeTree());

            //Assert
            Assert.AreEqual(traverseArrayIterative, new List<string> { "A", "D", "H", "G", "K", "C", "B", "E", "F", "J", "I" });
        }

        [Test]
        public void DetectCycles()
        {
            //Arrange
            Graph = new DepthFirstSearchImplementation();

            //Act
            Exception exception = Assert.Throws<Exception>(() => Graph.DetectCyclesDFS(InitializeTree().First()));

            //Assert
            Assert.That(exception.Message, Is.EqualTo("Cycle detected"));
        }
        private static List<Node<string>> InitializeTree()
        {
            Node<string> nodeA = new Node<string>() { Value = "A" };
            Node<string> nodeB = new Node<string>() { Value = "B" };
            Node<string> nodeC = new Node<string>() { Value = "C" };
            Node<string> nodeD = new Node<string>() { Value = "D" };
            Node<string> nodeE = new Node<string>() { Value = "E" };
            Node<string> nodeF = new Node<string>() { Value = "F" };
            Node<string> nodeG = new Node<string>() { Value = "G" };
            Node<string> nodeH = new Node<string>() { Value = "H" };
            Node<string> nodeI = new Node<string>() { Value = "I" };
            Node<string> nodeJ = new Node<string>() { Value = "J" };
            Node<string> nodeK = new Node<string>() { Value = "K" };

            nodeA.AddChild(nodeB);
            nodeA.AddChild(nodeC);
            nodeA.AddChild(nodeD);

            nodeB.AddChild(nodeF);
            nodeB.AddChild(nodeE);
            nodeB.AddChild(nodeB);

            nodeF.AddChild(nodeI);
            nodeF.AddChild(nodeJ);

            nodeD.AddChild(nodeG);
            nodeD.AddChild(nodeH);

            nodeG.AddChild(nodeK);
            List<Node<string>> list = new List<Node<string>>() {
                nodeA, nodeB, nodeC, nodeD, nodeE,
                nodeF, nodeG, nodeH, nodeI, nodeJ, nodeK
            };
            return list;
        }
    }
}
