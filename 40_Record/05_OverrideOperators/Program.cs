﻿namespace _05_OverrideOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == operator is not overridden by default in C# so it compares references of objects in memory and not their values.
            // To compare values of objects, we need to override the == operator in the class.
            // We also need to override the Equals method and GetHashCode method to compare values of objects.
            // If we overload the == operator, we should also overload the != operator.

            // two null references are equal



            // -----------------------------------------------------------------------------------------

            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
            Console.WriteLine($"(p1 == p2): {p1 == p2}");


            Console.ReadKey();
        }
    }

    class Point : IEquatable<Point>
    {
        public int X;
        public int Y;

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
