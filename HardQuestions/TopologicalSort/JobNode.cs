using System.Collections.Generic;

namespace TopologicalSort
{
    public class JobNode<T>
    {
        public T Job { get; set; }
        public List<JobNode<T>> PreRequisites { get; set; }
        public bool Visited { get; set; }
        public bool BeingVisited { get; set; }
        public JobNode(T job)
        {
            Job = job;
            PreRequisites = new List<JobNode<T>>();
            Visited = false;
            BeingVisited = false;
        }
    }
}
