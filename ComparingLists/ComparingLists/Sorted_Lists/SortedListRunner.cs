using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingLists.Sorted_Lists
{
    public class SortedListRunner
    {
        static void Main(string[] args)
        {
            /*SortedList<keyType,valueType> name = 
             * new SortedList<keyType, valueType>();*/

            SortedList<int, string> numbers =
                new SortedList<int, string>();
            //Add data
            numbers.Add(7, "Seven");
            numbers.Add(3, "Three");
            numbers.Add(12, "Twelve");
            numbers.Add(1, "One");
            numbers.Add(47, "Fourty Seven");
            numbers.Add(4, "Four");

            //Display all the elements
            DisplayElements(numbers);
            //Remove one
            numbers.Remove(1);
            //Remove element at index 2
            numbers.RemoveAt(2);
          
            Console.WriteLine("\nAfter Changes\n");
            DisplayElements(numbers);
        }

        private static void DisplayElements(SortedList<int, string> numbers)
        {
            foreach (KeyValuePair<int, string> item in numbers)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
