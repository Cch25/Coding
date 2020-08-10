using System.Collections.Generic;

namespace TopologicalSort
{
    /// <summary>
    /// Given an array of jobs that have to wait for other jobs to complete first
    /// in order to run themseves, arrange the order in graph so that the jobs will run after
    /// the prerequisites are finished.
    /// Eg. [1 ,2, 3, 4] where [[1,2],[1,3],[3,2],[4,2],[4,3]]
    /// the result should be 1, 4, 3, 2 
    /// Complexity: O(V+E) time | O(V+E) space
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TopologicalSortAlgorithm<T>
    {
        public JobGraph<T> CreateJobGraph(List<T> jobs, List<(T job, T preq)> deps)
        {
            JobGraph<T> graph = new JobGraph<T>(jobs);
            foreach ((T, T) dep in deps)
            {
                graph.AddPrerequisites(dep.Item1, dep.Item2);
            }
            return graph;
        }
        public List<T> GetOrderedJobs(JobGraph<T> jobGraph)
        {
            List<T> orderedGraph = new List<T>();
            Stack<T> nodes = jobGraph.Nodes;
            while (nodes.Count > 0)
            {
                T currNode = nodes.Pop();
                bool cycleDetected = DepthFirstTraverse(jobGraph.Graph[currNode], orderedGraph);
                if (cycleDetected)
                {
                    return new List<T>();
                }
            }
            return orderedGraph;
        }

        private bool DepthFirstTraverse(JobNode<T> currNode, List<T> orderedGraph)
        {
            if (currNode.Visited)
            {
                return false;
            }
            if (currNode.BeingVisited)
            {
                return true;
            }
            currNode.BeingVisited = true;
            foreach (JobNode<T> preq in currNode.PreRequisites)
            {
                bool containsCycle = DepthFirstTraverse(preq, orderedGraph);
                if (containsCycle)
                {
                    return true;
                }
            }
            currNode.Visited = true;
            currNode.BeingVisited = false;
            orderedGraph.Insert(0, currNode.Job);
            return false;
        }
    }
}
