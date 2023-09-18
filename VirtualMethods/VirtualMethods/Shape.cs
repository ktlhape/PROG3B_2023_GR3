using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Shape
    {
        protected double Length { get; set; }
        protected double Width { get; set; }
        public Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public virtual string PrintShape() =>
            "This is just a shape";
        public virtual double Area() => Length * Width;
    }

 
}
