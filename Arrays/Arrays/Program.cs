using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firstArray
            int[,] ar = new int[2, 3] { { 2, 4, 6 }, { 8, 10, 12 } };
            DisplayElements(ar);
       
            Console.WriteLine("--------------------");
            Console.WriteLine(ar[0,1]);
            Console.WriteLine(ar[1,0]);
            #endregion

            #region SecondArray
            int[,] ar2 = new int[2,4];
            ar2[0, 0] = 6;
            ar2[0, 1] = 7;
            ar2[0, 2] = 8;
            ar2[0, 3] = 10;
            ar2[1, 0] = 18;
            ar2[1, 1] = 47;
            ar2[1, 2] = 15;
            ar2[1, 3] = 12;

            Console.WriteLine("======Second Array=====");
            DisplayElements(ar2);

            #endregion

            #region ThirdArray
            int[,] ar3 = new int[4, 4];
            int number = 0;

            for (int row = 0; row < ar3.GetLength(0); row++)
            {
                for (int column = 0; column < ar3.GetLength(1); column++)
                {
                    number++;
                    ar3[row, column] = number;
                }
            }
            Console.WriteLine("======Second Array=====");
            DisplayElements(ar3);

            #endregion



            Console.Read();
        }
        /// <summary>
        /// Display elements of a multidimensional array
        /// </summary>
        /// <param name="ar">Multidimensional array</param>
        static void DisplayElements(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
