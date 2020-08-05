using System;
using System.Collections.Generic;
using System.Linq;

namespace DepthFirstSearch
{
    public class DepthFirstSearchImplementation
    {
        /// <summary>
        /// Recursive manner
        /// </summary>
        /// <param name="root">root starting point</param>
        /// <param name="graph">array to be returned from recursion</param>
        /// <returns></returns>
        public List<string> TraverseDFSRecursively(Node<string> root, List<string> graph)
        {
            graph.Add(root.Value);
            root.Visited = true;
            foreach (Node<string> node in root.Children)
            {
                if (!node.Visited)
                {
                    node.Visited = true;
                    TraverseDFSRecursively(node, graph);
                }
            }
            return graph;
        }

        public List<string> TraverseDFSIteratively(List<Node<string>> graph)
        {
            List<string> traversedGraph = new List<string>();
            Stack<Node<string>> stack = new Stack<Node<string>>();
            stack.Push(graph.First());
            graph.First().Visited = true;
            while (stack.Count > 0)
            {
                Node<string> node = stack.Pop();
                traversedGraph.Add(node.Value);
                foreach (Node<string> n in node.Children)
                {
                    if (!n.Visited)
                    {
                        n.Visited = true;
                        stack.Push(n);
                    }
                }
            }
            return traversedGraph;
        }
        /// <summary>
        /// Detect cycles in a graph
        /// </summary>
        /// <param name="node">Starting node</param>
        /// <returns>Returns false if no cycles detected or throws Exception if cycle is detected.</returns>
        public bool DetectCyclesDFS(Node<string> node)
        {
            node.BeingVisited = true;
            foreach (Node<string> n in node.Children)
            {
                if (n.BeingVisited)
                {
                    throw new Exception("Cycle detected");
                }
                if (!n.Visited)
                {
                    n.Visited = true;
                    DetectCyclesDFS(n);
                }
            }
            node.BeingVisited = false;
            node.Visited = true;
            return false;
        }
    }
}
