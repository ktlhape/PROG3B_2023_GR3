using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.Backtracking
{
    internal class MazeTester
    {
        static int[,] maze = {
        { 1,0,0,1},
        { 1,1,1,0},
        { 0,1,1,0},
        { 1,1,1,1}};
        static int size = 4;
        static int[,] path = new int[size, size];
        static void Main(string[] args)
        {
            DisplayPath();
            Console.Read();
        }

        static void DisplayPath()
        {
            if (GetPath(0,0) == false)
            {
                Console.WriteLine("No Path");
            }
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (path[row,col] == 1)
                    {
                        Console.WriteLine($"({row},{col})");
                    }
                   
                }
            }
           
        }

        static bool IsValidPath(int r, int c)
        {
            return (r >= 0 && r < size && c >= 0 && c < size
                && maze[r, c] == 1);

        }

        static bool GetPath(int r, int c)
        {
            if (r == size - 1 && c == size - 1)
            {
                path[r, c] = 1;
                return true;
            }

            if (IsValidPath(r,c) == true)
            {
                path[r, c] = 1;
                //Shift the column
                if (GetPath(r, c + 1) == true)
                {
                    return true;
                }
                //Shift the row
                if (GetPath(r + 1, c) == true)
                {
                    return true;
                }
                path[r, c] = 0;
                return false;

            }
            return false;
        }

    }
}
