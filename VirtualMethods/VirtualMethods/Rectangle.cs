using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Rectangle : Shape
    {
        public Rectangle(double l, double w) : base(l,w)
        {
            //this.Length = l;
            //this.Width = w;
        }

        public new string PrintShape() =>
            "This is a Rectangle";
        public override double Area() => this.Length * this.Width;


    }
   
}
