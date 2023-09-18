using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            list.AddToLast(7);
            list.AddToLast(8);
            list.AddToFirst(3);
            list.AddToLast(10);
            list.Display();
        }
    }
}
