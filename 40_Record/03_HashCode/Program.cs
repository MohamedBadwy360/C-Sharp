namespace _03_HashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hash Function is a function that takes an object and returns an integer value 
            // The integer value is called a hash code 
            // The hash code is used to store and retrieve objects from a collection like a dictionary or a hash table
            // The hash code is used to determine the bucket in which the object is stored in the collection
            // The hash code is used to determine the equality of objects in the collection
            // The hash code is used to determine the uniqueness of objects in the collection

            // For classes if two instances have the same values they will have different hash codes until we override the GetHashCode method
            // For structs if two instances have the same values they will have the same hash codes because structs are value types

            // Number types have the same hash code as their value

            // ---------------------------------------------------------------------------------------------

            var e1 = new Employee { Id = 100, Name = "Issam" };
            var e2 = new Employee { Id = 100, Name = "Issam" };

            // will have different hash codes because we didn't override the GetHashCode method 
            Console.WriteLine($"e1.GetHashCode() = {e1.GetHashCode()}");
            Console.WriteLine($"e2.GetHashCode() = {e2.GetHashCode()}");

            var c1 = new Customer { Id = 100, Name = "Issam" };
            var c2 = new Customer { Id = 100, Name = "Issam" };

            // will have the same hash codes
            Console.WriteLine($"c1.GetHashCode() = {c1.GetHashCode()}");
            Console.WriteLine($"c2.GetHashCode() = {c2.GetHashCode()}");

            // Number types have the same hash code as their value
            Console.WriteLine(100.GetHashCode());

            Console.ReadKey();
        }
    }


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    struct Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
