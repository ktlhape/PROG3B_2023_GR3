using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedList
{
    public class CustomLinkedList
    {
        private Node head;

        //AddFirst
        public void AddToFirst(int value)
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
        //AddToLast

        public void AddToLast(int value)
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
