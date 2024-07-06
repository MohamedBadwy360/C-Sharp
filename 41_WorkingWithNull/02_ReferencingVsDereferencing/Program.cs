namespace _02_ReferencingVsDereferencing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Referencing is the process of accessing the value of a variable. / accessing the memory address of a variable. / accessing the reference of a variable.
            // Referencing is a variable that points to an object.
            // Dereferencing is the process of accessing the value of a variable through a reference.

            // There is referencing & dereferencing in reference types because object is stored in heap so may occur null reference exception when dereferencing a null reference.
            // There is no referencing & dereferencing in value types so cannot occur null reference exception when dereferencing a value type beacuse the object is stored in the stack.

            // default keyword is used to initialize the value of a variable to its default value.
            // Reference types default value is null.
            // Value types default depends on the type of the variable.

            // null is a keyword in C# that is used to represent a null reference.
            // A null reference does not refer to any object.
            // A null reference is the default value of a reference type.

            // A reference type is a type that is not stored in the stack.
            // A reference type is stored in the heap.
            // A reference type is stored in the heap and a reference to the object is stored in the stack.

            // A value type is a type that is stored in the stack.
            // A value type is stored in the stack.
            // A value type is stored in the stack and the value is stored in the stack.

            // ----------------------------------------------------------------------------------------


            // string is reference type
            string str1 = default; // default is null string str1 = null;
            string str2 = "Issam";

            // dereferencing follow tge reference pointed to access the underlying object
            Console.WriteLine(str2.Length); // 5
            Console.WriteLine(str1.Length); // Null reference exception

            // value type
            DateTime datetime = default; // default is '0001/01/01 00:00 AM'
            Console.WriteLine(datetime.Month);

            Console.ReadKey();
        }
    }
}
