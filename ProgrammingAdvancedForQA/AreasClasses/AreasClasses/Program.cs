namespace AreasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Console.WriteLine(square.Area(10));

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area(10, 20));

            Circle circle = new Circle();
            Console.WriteLine(circle.Area(10));

            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.Area(10, 20));


        }
    }
}
