namespace _08_RecordRescue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Record is a class that is used to store data in a structured format.
            // It is a reference type, but it behaves like a value type.
            // It implements IEquatable<T> and overrides the Equals() and GetHashCode() methods by default.
            // It overrides the ToString() method to return the string representation of the record.
            // It overrides the == and != operators to compare two records.

            // ------------------------------------------------------------------------------------------------

            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
            Console.WriteLine($"(p1 == p2): {p1 == p2}");

            Console.ReadKey();
        }
    }

    // Mutable record (class)
    // override object equal
    // implement IEquatable <Point>
    // override object GetHashCode
    // override ==, !=
    // override ToString();
    record Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y;
    }
}
