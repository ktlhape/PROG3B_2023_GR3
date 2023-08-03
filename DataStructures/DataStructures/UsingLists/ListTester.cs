using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.UsingLists
{
    public class ListTester
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() 
            { 6,7,21};

            DisplayElements(numbers);
            numbers.Add(2);
            numbers.Add(7);

            numbers.Insert(3,3);
            DisplayElements(numbers);
            numbers.Remove(7);
            numbers.Add(100);
            numbers.RemoveAt(numbers.Count - 2);
            DisplayElements(numbers);

            Console.WriteLine(CheckNumber(5,numbers));
            Console.WriteLine($"Sum of Evens: {SumOfEven(numbers)}");
            AverageOfOdd(numbers);
            MultiplesOf3And7(numbers);
            Console.WriteLine(CheckForNumber(8));
            //Display all elements
            Console.Read();

        }

        static void DisplayElements(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n==============================\n");
        }

        static bool CheckNumber(int x, List<int> ls)
        {
            return ls.Contains(x);
        }

        static int SumOfEven(List<int> ls)
        {
            int sum = 0;
            foreach (int n in ls)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }

            return sum;

        }

        static void AverageOfOdd(List<int> ls)
        {
            int sum = 0;
            int count = 0;
            double average = 0;
            foreach (int n in ls)
            {
                if (n % 2 !=0)
                {
                    sum += n;
                    count++;
                }
            }
            average = sum / count;
            Console.WriteLine($"Average : {average.ToString("N2")}");
        }

        static void MultiplesOf3And7(List<int> ls)
        {
            foreach (int n in ls)
            {
                if (n % 3 == 0 && n % 7 == 0)
                {
                    Console.WriteLine(n);
                }
            }
        }

        static string CheckForNumber(int x)
        {

            return x % 2 == 0 ? "Even" :
                x % 3 == 0 ? "Multiple of 3" : "Odd";
        }

        //Ternary

        static bool CheckForNumber2(int x)
        {
            return x % 2 == 0;
        }
    }
}
