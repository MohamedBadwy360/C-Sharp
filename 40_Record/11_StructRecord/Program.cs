namespace StructRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Struct record is a C# 10 feature
            // We need to use struct keyword with record keyword to create a struct record
            // It is a value type that is immutable and has value-based equality
            // Posiotional records for struct are mutable by default
            // To make it immutable, use the readonly modifier in the record declaration


            // If struct record has readonly modifier, then the properties must be readonly

            // ------------------------------------------------------------------------------------------------

            Point point = new Point(10, 20);
            point.X = 30;        // No error

            Point2 point2 = new Point2(10, 20);
            //point2.X = 30;    // Error because it is immutable

            Console.WriteLine(point);       // Output: Point { X = 30, Y = 20 }
            Console.WriteLine(point2);      // Output: Point2 { X = 10, Y = 20 }

            Console.ReadKey();
        }
    }

    // Struct record declaration
    // Mutable struct record
    record struct Point(int X, int Y);


    // Immutable struct record
    readonly record struct Point2(int X, int Y);


    // If struct record has readonly modifier, then the properties must be readonly
    readonly record struct Point3(int X, int Y)
    {
        // Must be readonly
        public int X { get; }
        public readonly int Y;
    }
}
