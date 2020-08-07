using System.Collections.Generic;

namespace EasyQuestions.DepthFirstSearch
{
    public class Node<T>
    {
        public T Value { get; set; }
        public bool Visited { get; set; }
        public bool BeingVisited { get; set; }
        public List<Node<T>> Children { get; set; }
        public Node()
        {
            Children = new List<Node<T>>();
        }
        public void AddChild(Node<T> node)
        {
            Children.Add(node);
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }


}
