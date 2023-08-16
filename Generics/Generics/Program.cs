using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Create a generic array that will store 5 elements

            //Generic constraints

            //Console.WriteLine(AreEqual<int>(5,4));
            //Console.WriteLine(AreEqual<double>(6.0,6));
            //Console.WriteLine(AreEqual<string>("Bob","boB"));

            //CustomLinkedList<int> numbers = new CustomLinkedList<int>();
            //numbers.AddToLast(3);
            //numbers.AddToLast(10);
            //numbers.AddToLast(5);
            //numbers.AddToFirst(14);
            //numbers.AddToLast(8);
            //numbers.Display();

            //Console.WriteLine("==========================");

            //CustomLinkedList<string> names = new CustomLinkedList<string>();
            //names.AddToFirst("Kabelo");
            //names.AddToFirst("James");
            //names.AddToLast("Roger");
            //names.AddToFirst("Djokovic");
            //names.AddToLast("Michael");
            //names.AddToFirst("Jordan");
            //names.Display();

            MyLinkedList<Employee> employees = new MyLinkedList<Employee>();
            employees.AddToFirst(new Employee(12, "Kabelo"));
            employees.AddToFirst(new Employee(13, "Lerato"));
            employees.AddToFirst(new Employee(14, "Jordan"));
            employees.AddToFirst(new Employee(122, "James"));
            employees.AddToFirst(new Employee(18, "Mike"));

            employees.Display();
            Console.WriteLine(employees.ToString());

        }
        static bool AreEqual<T>(T x, T y)
        {
            if (x.GetType() == typeof(string))
            {
               //return x.ToString().ToLower().Equals(y.ToString().ToLower());
                //or
                return string.Compare(x.ToString(), y.ToString(), true) == 0;
            }
            return x.Equals(y);
        }


    }
}
