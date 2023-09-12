namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(4, 5);
            Rectangle rec = new Rectangle(4, 6);

            Shape recShape = new Rectangle(4, 6);

            Console.WriteLine(s.PrintShape());
            Console.WriteLine($"Area: {s.Area()}");
            Console.WriteLine();

            Console.WriteLine(recShape.PrintShape());
            Console.WriteLine($"Area: {recShape.Area()}");
            Console.WriteLine();
            
        }
    }
}