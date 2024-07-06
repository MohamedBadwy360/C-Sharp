namespace _06_PropertyInitSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mutability & Immutability in C#

            // Immutability is a goal that programmers strive to achieve in their code.
            // Immutability is a goal that can be achieved by using the readonly keyword or the init keyword.

            // In C#, a class is mutable by default. This means that the properties of the class can be changed after the object is created.
            // To make a class immutable, we can use the readonly keyword to make the properties read-only.
            // We can also use the init keyword to make the properties read-only but only during the object initialization.
            // We can also use the init keyword to make the properties read-only but only can be assigned during the object initialization or constructor.
            // The init keyword is available in C# 9.0 and later versions.
            // The init keyword can be used with properties, indexers, and events.
            // The init keyword can be used with auto-implemented properties and properties with backing fields.
            // The init keyword can be used with properties in classes, structs, and records.


            // ----------------------------------------------------------------------------------------

            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);
            var p3 = new Point
            {
                X = 2,                  // No compile time error because X and Y are not readonly properties using the init keyword.
                Y = 3
            };

            //p1.X = 10; // compile time error access readonly property


            Console.ReadKey();
        }
    }

    class Point : IEquatable<Point>
    {
        // init keyword is used to make the properties read-only but only can be assigned during the object initialization or constructor.
        public int X { get; init; }
        public int Y { get; init; }

        public Point()
        {

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;

            return this.Equals(p);
        }

        public bool Equals(Point point)
        {
            if (point is null)
                return false;

            return point.X == X && point.Y == Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point lhs, Point rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }
                return false;
            }
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Point lhs, Point rhs)
        {
            return !(lhs == rhs);
        }
    }
}
