namespace _09_StructAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // There are some disadvantages that the compiler can't detect null reference exceptions in structs.
            // When method have a struct parameter, and if we pass null to the method, it will not show any warning or error.

            // Array of reference types when accessing a property of an element in it, the compiler will not show any warning and it may throw a null reference exception.

            // -------------------------------------------------------------------------------------

            //Print(default);                   // will not show any warning

            string[] names = new string[10];
            var firstValue = names[0];
            Console.WriteLine(firstValue.ToUpper());        // will not show any warning
            Console.ReadLine();
        }

        static void Print(Student student)
        {
            Console.WriteLine($"First Name: {student.FirstName.ToUpper()}");
            Console.WriteLine($"Middle Name: {student.FirstName?.ToUpper()}");
            Console.WriteLine($"Last Name: {student.LastName.ToUpper()}");
        }

    }

    // struct contains reference types
    public struct Student
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;
    }
}
