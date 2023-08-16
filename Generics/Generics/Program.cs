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

            Console.WriteLine(AreEqual<int>(5,4));
            Console.WriteLine(AreEqual<double>(6.0,6));
            Console.WriteLine(AreEqual<string>("Bob","boB"));
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
