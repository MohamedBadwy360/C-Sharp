using System.Diagnostics.CodeAnalysis;

namespace _06_CompilerDoesNotTraceMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compiler doesn't trace method calls to determine if a variable can be null or not.
            // It only traces the method signature to determine if a variable can be null or not.

            // So many times, the compiler can't determine if a variable can be null or not so it gives a warning.

            // We can use MemberNotNullAttribute to tell the compiler that a method will set a variable to non-null value.
            // So the warning will be removed.

            // ------------------------------------------------------------------------------------------

            // var person = new Person(null, null);     // warning 

            Console.ReadKey();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Student : Person
    {
        public string Major { get; set; }

        public Student(string firstName, string lastName, string major)
            : base(firstName, lastName)
        {
            SetMajor(major);
        }

        public Student(string firstName, string lastName) :
            base(firstName, lastName)
        {
            SetMajor();
        }

        // This method will set Major to non-null value
        // With this way I'm telling the compiler that this method will set Major to non-null value and I know what I'm doing.
        [MemberNotNull(nameof(Major))]  // This method will set Major to non-null value
        public void SetMajor(string? major = default)
        {
            Major = major ?? "Undeclared";
        }
    }
}
