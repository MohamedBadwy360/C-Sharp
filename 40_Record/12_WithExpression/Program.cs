namespace _12_WithExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // With expression is a new feature in C# 9.0
            // It is used to create a new object with the same properties as the original object, but with some properties changed.

            var point = new Point(10, 20);

            var point2 = point with { X = 30 };     // Create a new object with the same properties as the original object, but with X property changed to 30

            Console.WriteLine(point);               // Output: Point { X = 10, Y = 20 }
            Console.WriteLine(point2);              // Output: Point { X = 30, Y = 20 }

            Console.ReadKey();
        }
    }

    record Point(int X, int Y);
}
