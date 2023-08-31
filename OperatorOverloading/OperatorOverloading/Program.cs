namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new(5,9);
            Point pointB = new(4, 6);
            //Point pointC = new(pointA.X + pointB.X, pointA.Y + pointB.Y);
            //Point pointC = pointA + pointB;

            //pointC++;
            pointA++;
            bool results = pointA > pointB;
            //Add n value to X and Y values of a point
            //Point pointD = pointC + 5;

            //Add the x values of both points
            int xValues = pointA + pointB;


            Console.WriteLine(pointA.ToString());
            Console.WriteLine(pointB.ToString());
            Console.WriteLine();
            Console.WriteLine(xValues);


        }
    }
}