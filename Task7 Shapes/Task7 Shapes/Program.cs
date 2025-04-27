using ShapeLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareInstance = new Square(10);

            Square squareInstance2 = squareInstance.Clone();

            System.Console.WriteLine(squareInstance.Width);
            System.Console.WriteLine(squareInstance2.Width);
        }
    }
}