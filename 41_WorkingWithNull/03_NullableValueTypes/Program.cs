namespace _03_NullableValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable value types are value types that can be assigned a value or null.
            // Nullable value types are instances of the System.Nullable<T> struct.
            // Nullable value types are useful when you need to represent an optional value.
            // Nullable value types are useful when you need to represent a value that is not yet defined.
            // Nullable value types are useful when you need to represent a value that is unknown.
            // Nullable value types are useful when you need to represent a value that is not present.
            // Nullable value types are useful when you need to represent a value that is not set.
            // Nullable value types are useful when you need to represent a value that is not available.

            // We can efine a nullable value type by adding a question mark (?) after the data type.
            // For example, int? is a nullable integer.
            // Or we can use the System.Nullable<T> struct.

            // Nullable value types have two properties:
            // HasValue: A boolean property that returns true if the nullable value type has a value.
            // Value: A property that returns the value of the nullable value type.

            // Null value types are stored in memory as follows:
            // A nullable value type with a value is stored in memory as the value itself.
            // A nullable value type with a null value is stored in memory as a null reference.


            // -------------------------------------------------------------------------------------------

            int mark1 = 15;
            int mark2 = default; // 0

            Nullable<int> mark3 = default; // null

            if (mark3 is null)
            {
                Console.WriteLine("not available!!");
            }
            else
            {
                Console.WriteLine($"mark3 = {mark3}");
            }


            int? mark4 = default; // null

            if (!mark4.HasValue)
            {
                Console.WriteLine("not available!!");
            }
            else
            {
                Console.WriteLine($"mark4 = {mark4}");
            }

            Nullable<int> mark5 = default; // null
            Console.WriteLine($"mark5 = {(mark5.HasValue ? mark5 : "null")}");

            Nullable<int> mark6 = new Nullable<int>(); // null
            Console.WriteLine($"mark6 = {(mark6.HasValue ? mark6 : "null")}");

            int? mark7 = default(int?); // null
            Console.WriteLine($"mark7 = {(mark7.HasValue ? mark7 : "null")}");

            // call the default constructor and the value is set to 0
            Nullable<int> mark8 = new(); // 0
            Console.WriteLine($"mark8 = {(mark8.HasValue ? mark8 : "null")}");

            Console.ReadKey();
        }
    }
}
