namespace _10_PositionalRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Positional Records are immutable by default for classes only
            // and are defined using the record keyword
            // They are used to store data in a structured way 
            // and are similar to classes but with less boilerplate code 
            // and more concise syntax

            // Under the hood:
            // 1. A constructor is generated with positional parameters 
            // 2. Init only setters are generated for the properties 
            // 2. A Deconstructor is generated to deconstruct the record into its properties
            // 3. Equals and GetHashCode methods are generated to compare records
            // 4. ToString method is generated to display the record
            // 5. Overloads for == and != operators are generated to compare records

            // To use object initializer syntax with records you can edit the record implementation and create constructor without parameters and pass default values to this() constructor.

            // _______________________________________________________________________________________

            Point point = new Point(10, 20);
            //point.X = 10;           // position record are immutable by default

            Console.WriteLine(point);
            Console.WriteLine($"X: {point.X}, Y: {point.Y}");

            // using deconstructor to deconstruct the record into its properties
            var (x, y) = point;
            Console.WriteLine($"x = {x}, y = {y}");

            // using object initializer syntax with records
            Point point2 = new Point { X = 30, Y = 40 };
            Console.WriteLine(point2);

            Console.ReadKey();
        }
    }

    // Positional Records for classes are defined using the record keyword and are immutable by default
    //record Point(int X, int Y);


    // To use object initializer syntax with records you can edit the record implementation and create constructor without parameters and pass default values to this() constructor.
    // still immutable by default
    record Point(int X, int Y)
    {
        public Point() : this(0, 0)
        {

        }
    }
}
