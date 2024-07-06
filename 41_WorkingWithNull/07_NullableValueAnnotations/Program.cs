namespace _07_NullableValueAnnotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ! - Null Forgiving Operator (nullable value annotation) - it tells the compiler that the value is not null and it will not be null
            // Or forgive me I know what I am doing and I want ot override your warning / behavior of nullable reference types  

            // ? - Null Conditional Operator (nullable value annotation) - it tells the compiler that the value can be null and if it is null then do not throw an exception and return null



            // --------------------------------------------------------------------------------------

            string fname = null!;
            string lname = null!;

            var person = new Person(fname, lname);

            Console.WriteLine(person.FirstName!.Length);

            Student st1 = new Student();                // non-nullable reference type

            Student? st2 = new Student();               // nullable reference type

            var st3 = new Student();                    // nullable reference type

            Console.ReadKey();
        }
    }

    class Student { }
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            if (firstName is null)
            {
                FirstName = "Annonymous";
            }
            else
            {
                FirstName = firstName;
            }
            if (lastName is null)
            {
                LastName = "Annonymous";
            }
            else
            {
                LastName = lastName;
            }
        }
    }

}
