using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.Linked_Lists
{
    public class LinkedListRunner
    {
        static void Main(string[] args)
        {
            LinkedList<string> cities = new LinkedList<string>();
            cities.AddLast("Pretoria");
            cities.AddLast("Benoni");
            cities.AddLast("Sandton");
            cities.AddLast("Brooklyn");

            //Add Midrand at the first position
            cities.AddFirst("Midrand");

            //Add Cape Town after Benoni
            LinkedListNode<string> nodeBenoni = cities.Find("Benoni");
            cities.AddAfter(nodeBenoni, "Cape Town");

            //Display a city before Brooklyn

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            LinkedListNode<string> nodeBrooklyn = cities.Find("Brooklyn");
            Console.WriteLine($"\nCity before {nodeBrooklyn.Value} is: {nodeBrooklyn.Previous.Value}");



        }
    }
}
