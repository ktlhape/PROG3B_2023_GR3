using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) => 
            (this.X, this.Y) = (x, y);
        public override string? ToString() =>
         $"X: {X}\nY: {Y}"; 
        
        //modifier static returnType operator +(operands)
        //public static Point operator + (Point p1, Point p2)
        //{
        //    return new Point(p1.X + p2.X, p1.Y + p2.Y);
        //}
        public static Point operator ++(Point p)
        {
            return new Point(p.X + 1, p.Y + 1);
        }
        public static bool operator > (Point p1, Point p2)
        {
            return (p1.X > p2.X && p1.Y > p2.Y);
        }
        public static bool operator <(Point p1, Point p2)
        {
            return (p1.X < p2.X && p1.Y < p2.Y);
        }
        public static Point operator + (Point p, int n)
        {
            return new(p.X + n, p.Y + n);
        }
        public static int operator + (Point p1, Point p2)
        {
            return (p1.X + p2.X);
        }
    }
}
