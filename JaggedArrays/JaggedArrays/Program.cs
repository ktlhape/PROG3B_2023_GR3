using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArray = new string[4][];

            string[] h_Kabelo = new string[] { "Tennis", "Soccer", "Chess" };
            string[] h_Carol = new string[2];
            string[] h_James = new string[] { "Swimming","Tennis","Hockey","Movies"};

            jaggedArray[0] = h_Kabelo;
            jaggedArray[1] = h_James;
            jaggedArray[2] = h_Carol;
            jaggedArray[3] = new string[] { "Boxing","Gym","Swimming","Dance"};

            //Carol likes Swimming and dance

            jaggedArray[2][0] = "Dance";
            jaggedArray[2][1] = "Swimming";

            //Display all the elements of the Jagged Array

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + ", ");
                }

                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
