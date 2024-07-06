namespace _04_OverrideEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If we need to compare two objects for equality, we can use the Equals method of the Object class 
            // The Equals method compares two objects for equality and returns a boolean value
            // The default implementation of the Equals method in the Object class compares the references of the two objects
            // We should also override the GetHashCode method when we override the Equals method to ensure that the hash code of the object is consistent with the equality comparison of the object
            // The GetHashCode method returns a hash code for the object
            // The hash code is used by hash-based collections such as Dictionary, HashSet, and Hashtable to store and retrieve objects
            // The hash code is used to determine the bucket in which the object is stored in the hash-based collection
            // If we override the Equals method, we should also override the GetHashCode method to ensure that the hash code of the object is consistent with the equality comparison of the object

            // HashCode.Combine() method is used to generate a hash code for an object based on the hash codes of its fields
            // The HashCode.Combine() method takes one or more hash codes of the fields of the object and combines them to generate a new hash code

            // Always things or fields that are used in the Equals method should be used in the GetHashCode method to generate a unique hash code for each object

            // There is another way to implement equality comparison in C# using the IEquatable<T> interface 
            // The IEquatable<T> interface is a generic interface that defines a method to compare two objects of the same type for equality
            // The IEquatable<T> interface has a single method Equals that compares two objects of the same type for equality and returns a boolean value
            // The IEquatable<T> interface is used to implement value equality for a type 
            // The IEquatable<T> interface has a better performance than the Equals method of the Object class because it avoids boxing and unboxing of value types
            // We should always override the Equals method when we implement the IEquatable<T> interface to compare two objects for equality 
            // We should use IEquatable<T> interface when we need to implement value equality for a type 

            // -----------------------------------------------------------------------------------------

            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");

            var points = new Dictionary<Point, string>();

            Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
            Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");
            points.Add(p1, "2D Point X: 2, Y: 3");
            points.Add(p2, "2D Point X: 2, Y: 3");

            Console.ReadKey();
        }
    }

    // 
    class Point : IEquatable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override Equals method to compare two Point objects for equality 
        public override bool Equals(object obj)
        {
            Point p = obj as Point;

            return this.Equals(p);
        }

        // Equals method to compare two Point objects for equality
        // The Equals method compares the X and Y values of the two Point objects and returns a boolean value
        // It has better performance than the Equals method of the Object class because it avoids boxing and unboxing of value types
        public bool Equals(Point point)
        {
            if (point is null)
                return false;

            return point.X == X && point.Y == Y;
        }

        // Override GetHashCode method to return a unique hash code for each Point object
        // We are using the HashCode.Combine method to generate a hash code for the Point object based on its X and Y values
        // We should always override GetHashCode when we override Equals
        public override int GetHashCode()
        {
            //int hash = 13;
            //hash = hash * 7 + X.GetHashCode();
            //hash = hash * 7 + Y.GetHashCode();
            //return hash;


            // better way to generate hash code using HashCode.Combine method 
            return HashCode.Combine(X, Y);                      // Combines the hash codes of the two integers and returns a new hash code 
        }
    }
}
