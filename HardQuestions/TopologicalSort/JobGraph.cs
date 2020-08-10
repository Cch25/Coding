using System.Collections.Generic;

namespace TopologicalSort
{
    public class JobGraph<T>
    {
        public Stack<T> Nodes { get; set; }
        public Dictionary<T, JobNode<T>> Graph { get; set; }
        public JobGraph(List<T> jobs)
        {
            Nodes = new Stack<T>();
            Graph = new Dictionary<T, JobNode<T>>();
            foreach (T job in jobs)
            {
                AddNode(job);
            }
        }
        public void AddPrerequisites(T job, T prerequisite)
        {
            JobNode<T> jobNode = GetNode(job);
            JobNode<T> prereqNode = GetNode(prerequisite);
            jobNode.PreRequisites.Add(prereqNode);
        }

        private JobNode<T> GetNode(T job)
        {
            if (!Graph.ContainsKey(job))
            {
                Graph.Add(job, new JobNode<T>(job));
            }
            return Graph[job];
        }

        public void AddNode(T node)
        {
            Graph[node] = new JobNode<T>(node);
            Nodes.Push(node);
        }
    }
}
