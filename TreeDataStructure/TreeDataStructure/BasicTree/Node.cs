using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    public class Node<T>
    {
        public T Data { get; }
        public Node<T> Parent { get; }
        public List<Node<T>> Children { get; } 
        public Node(T _data, Node<T>? _parent)
        {
            Data = _data;
            Parent = _parent;
            Children = new List<Node<T>>();
        }
        public Node<T> AddChild(T _data)
        {                             //5       //7   
            Node<T> childNode = new Node<T>(_data, this);
            this.Children.Add(childNode);
            return childNode;
        }
        public override string? ToString() =>
            $"{Data}";
        
       
    }
}
