using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStacks.DelimiterCheck
{
    internal class DelimiterTester
    {
        static void Main(string[] args)
        {
            string str = "5 + ((3 + 4) * 2) + ((5 - (2 * 2)))";
            Stack<int> pos = new();
            bool results = true;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c == '(')
                {
                    pos.Push(i); //6
                }else if (c == ')')
                {
                    if (pos.Count == 0)
                    {
                        results = false;
                        break;
                    }
                    pos.Pop();
                }
            }
            if (pos.Count != 0)
            {
                results = false;
            }
            Console.WriteLine(str);
            Console.WriteLine($"Correct brackets? {results}");




        }
    }
}
