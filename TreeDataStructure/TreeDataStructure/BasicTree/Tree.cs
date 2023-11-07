using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TreeDataStructure.BasicTree
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }
        public List<Node<T>> Nodes { get;} = new List<Node<T>>();
        private Stack<Node<T>> temp_stack = new Stack<Node<T>>();
        public Tree(T value)
        {
            Root = new Node<T>(value, null);
            Nodes.Add(Root);
            temp_stack.Push(Root);
        }
        public Tree<T> CreateBranch(T data)
        {
            if (temp_stack.Count == 0)
            {
                Node<T> rootNode = new Node<T>(data, null);
                Nodes.Add(rootNode);
                temp_stack.Push(rootNode);
            }
            else
            {
                                            //7
                Node<T> parentNode = temp_stack.Peek().AddChild(data);
                temp_stack.Push(parentNode);
            }

            return this;
        }
        public Tree<T> CloseBranch()
        {
            temp_stack.Pop();
            return this;
        }
        public Tree<T> Add(T data)
        {
            temp_stack.Peek().AddChild(data);
            return this;
        }
        public Node<Employee> Find(Node<Employee> node, Employee data)
        {
            if (node.Data.EmpNo.Equals(data)) return node;
            foreach (Node<Employee> n in node.Children)
            {
                Node<Employee> found = Find(n, data);
                if (found != null) return found;
            }
            return null;
        }

    }
}
