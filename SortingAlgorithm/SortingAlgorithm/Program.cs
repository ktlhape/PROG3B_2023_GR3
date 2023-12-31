﻿using System.Diagnostics;

namespace SortingAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region RandonArray
            //List<int> numbers = new List<int>();

            ////1 - 500
            //Random rnd = new Random();
            //for (int i = 1; i <= 999999; i++)
            //{
            //    numbers.Add(rnd.Next(1, 10000)); 
            //}

            //Console.WriteLine("+++++Before Sort+++++");
            ////DisplayElements(numbers);
            //BubbleSort(numbers);
            //SelectionSort(numbers);
            //InsertionSort(numbers);

            //Console.WriteLine("\n+++++After Sort+++++");
            ////DisplayElements(numbers);

            #endregion

            #region studentList
            List<Student> stList = new List<Student>()
            {
                new Student("Kabelo", "Smith",21),
                new Student("Caroline", "Smith",20),
                new Student("Matthew", "Jones",22),
                new Student("Jason", "Specter",17),
                new Student("Rogger", "Federer",18)
            };

            Console.WriteLine("Student data\n");
            foreach (Student st in stList)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("\nAfter the sort");
            BubbleSort(stList);
            foreach (Student st in stList)
            {
                Console.WriteLine(st.ToString());
            }

            #endregion
            Console.WriteLine("\n===========================\n");
            List<string> names = new List<string>()
            {"Kabelo","Jason","Anthony","Carol","Bennet"
            };
            /*Using any sorting algorithm, create a method
            * that will sort the list of names in 
            * ascending order*/
            Console.WriteLine("=====Before the Sort");
            DisplayElements(names);
            BubbleSort(names);
            Console.WriteLine("\n=====After the Sort");
            DisplayElements(names);
           

            Console.Read();
        }

        private static void BubbleSort(List<string> names)
        {
            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int x = (i + 1); x < names.Count; x++)
                {
                    if (string.Compare(names[x], names[i]) < 0)
                    {
                        string temp = names[x];
                        names[x] = names[i];
                        names[i] = temp;
                    }
                }
            }
        }

        private static void InsertionSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = (i + 1); j > 0; j--)
                {
                    if (ar[j-1] > ar[j])
                    {
                        int temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            stw.Stop();
            Console.WriteLine("Insertion Sort: " + stw.ElapsedMilliseconds.ToString());
        }

        private static void SelectionSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            int min;

            for (int i = 0; i < ar.Count - 1; i++)
            {
                min = i; // set position with min value
                for (int j = (i + 1); j < ar.Count; j++)
                {
                    if (ar[j] < ar[min]) // 
                    {min = j;}
                }
                //Swap value at min position with the current position of i
                int temp = ar[i];
                ar[i] = ar[min];
                ar[min] = temp;
            }
            stw.Stop();
            Console.WriteLine("Selection Sort: " + stw.ElapsedMilliseconds.ToString());
        }

        private static void BubbleSort(List<Student> stList)
        {
            for (int i = 0; i < stList.Count - 1; i++)
            {
                for (int x = (i + 1); x < stList.Count; x++)
                {
                    if (string.Compare(stList[i].Lastname, stList[x].Lastname) > 0)
                    {
                        Student temp = stList[i];
                        stList[i] = stList[x];
                        stList[x] = temp;
                    }else if (string.Compare(stList[i].Lastname, stList[x].Lastname) == 0)
                    {
                        if (string.Compare(stList[i].Firstname, stList[x].Firstname) > 0)
                        {
                            Student temp = stList[i];
                            stList[i] = stList[x];
                            stList[x] = temp;
                        }
                    }
                }
            }
        }

        private static void BubbleSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = (i + 1); j < ar.Count; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            stw.Stop();
            Console.WriteLine("Bubble Sort: " + stw.ElapsedMilliseconds.ToString());
        }
        /// <summary>
        /// Display all the elements in the array
        /// </summary>
        /// <param name="numbers">Array of integers</param>
        private static void DisplayElements(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

        }
        private static void DisplayElements(List<string> names)
        {
            foreach (string str in names)
            {
                Console.Write(str + " ");
            }

        }
    }
}