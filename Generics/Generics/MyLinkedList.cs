using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// Class store Nodes inside a Linked List
    /// </summary>
    /// <typeparam name="T">Type of Nodes to be stored</typeparam>
    public class MyLinkedList<T> where T : Employee
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(T value)
            {
                this.Data = value;
            }
        }

        private Node head;
        /// <summary>
        /// Add a Node ath the top of the List
        /// </summary>
        /// <param name="value">Node to be added</param>
        public void AddToFirst(T value)
        {
            Node newNode = new Node(value);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                newNode.Previous = null;
                head = newNode;
            }
        }
        /// <summary>
        /// Add a Node at the bottom of the List
        /// </summary>
        /// <param name="value">Node to be added</param>
        public void AddToLast(T value)
        {
            Node newNode = new Node(value);
            if (head is null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }
        /// <summary>
        /// Return a string with all the data inside the Node
        /// </summary>
        /// <returns>Data inside of Nodes</returns>
        public override string ToString()
        {
            string str = "";
            Node currentNode = head;
            while (currentNode != null)
            {
                str += $"{currentNode.Data.ID} - {currentNode.Data.Name}\n"; //7
                currentNode = currentNode.Next;
            }

            return str;
        }
    }
}
