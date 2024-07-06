namespace _09_ImmutableRecordsUsingInit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can make record immutable using init keyword in C# 9.0 or read-only properties
            // You can't change the value of the property after initialization


            // --------------------------------------------------------------------------------------

            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);
            var p3 = new Point
            {
                X = 2,
                Y = 3
            };

            //p3.X = 30;  // Compile time error

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
            Console.WriteLine($"(p1 == p2): {p1 == p2}");

            Console.ReadKey();
        }
    }

    record Point
    {
        // override object equal
        // implement IEquatable <Point>
        // override object GetHashCode
        // override ==, !=
        // override ToString();
        public Point()
        {

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; init; }
        public int Y { get; init; }

    }
}
