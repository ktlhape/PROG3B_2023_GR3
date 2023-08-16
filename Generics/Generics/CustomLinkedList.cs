using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CustomLinkedList<T>
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
        public void Display()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data); //7
                currentNode = currentNode.Next;
            }
        }
    }
}
