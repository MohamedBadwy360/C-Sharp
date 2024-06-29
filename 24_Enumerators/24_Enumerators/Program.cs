namespace _24_Enumerators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Equality (Equals & GetHashCode) ----------\n");
            Employee e1 = new Employee { Id = 101, Name = "Mark", Salary = 5000, Department = "HR" };
            Employee e2 = new Employee { Id = 101, Name = "Mark", Salary = 5000, Department = "HR" };
            Employee e3 = e1;

            // Basic behavior of == operator and Equals method is to do reference comparison
            //Console.WriteLine(e1 == e2);        // False => Reference comparison
            //Console.WriteLine(e1 == e3);        // True => Reference comparison
            //Console.WriteLine(e1.Equals(e2));   // False => Reference comparison => Equals method is not overridden in Employee class so it will do reference comparison only
            // You can override Equals method in Employee class to do value comparison instead of reference comparison

            Console.WriteLine("-------------------");

            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 == s2);        // True => Value comparison (string is a reference type but it is immutable), special case for string type

            Console.WriteLine("-------------------");

            Console.WriteLine(e1.Equals(e2));   // True => Value comparison
            Console.WriteLine(e1.Equals(null));

            // If you need to use == operator for value comparison then you can overload == operator in Employee class
            Console.WriteLine(e1 == e2);

            // If you override Equals method then you should also override GetHashCode method to maintain the contract between Equals and GetHashCode methods
            // (if two objects are equal then their hash code should be same) 
            // Hash code is a numeric value that is used to store and retrieve objects from hash based collections like Dictionary, HashSet, etc.
            // If you don't override GetHashCode method then hash code will be different for two objects even if they are equal


            // -------------------------------------------------------------

            Console.WriteLine("\n\n---------- Equality (Equals & GetHashCode) ----------\n");

            FiveIntegers ints = new FiveIntegers(1, 2, 3, 4, 5);

            // You can't iterate over FiveIntegers object because it doesn't implement IEnumerable interface and doesn't have GetEnumerator method to return IEnumerator object 
            // You should implement IEnumerable interface and GetEnumerator method in FiveIntegers class to make it iterable 
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            // -------------------------------------------------------------

            Console.WriteLine("\n\n---------- IComparable ----------\n");
            Console.WriteLine("Temperatures: \n");

            Random random = new Random();

            List<Temperature> temperatures = new List<Temperature>();
            for (int i = 0; i < 10; i++)
            {
                temperatures.Add(new Temperature(random.Next(-50, 50)));
            }

            temperatures.Sort();

            foreach (var temp in temperatures)
            {
                Console.WriteLine(temp.Value);
            }
        }
    }

    // You need to implement IComparable interface in Temperature class to use List.Sort method to sort Temperature objects in List
    // IComparable interface has CompareTo method that is used to compare two objects of same type
    // CompareTo method should return -1 if current object is less than other object, 0 if current object is equal to other object, 1 if current object is greater than other object
    // You can implement Generic IComparable<T> interface to compare two objects of type T instead of implementing IComparable interface 
    class Temperature : IComparable<Temperature>
    {
        int _value;

        public Temperature(int value)
        {
            _value = value;
        }

        public int Value { get => _value; }

        public int CompareTo(Temperature other)
        {
            return this._value.CompareTo(other._value);
        }


        // This for non generic implementation
        //public int CompareTo(object obj)
        //{
        //    if (obj is null)
        //    {
        //        return 1;
        //    }

        //    var temp = obj as Temperature;
        //    if (temp is null)
        //    {
        //        throw new ArgumentException("Object is not a Temperature object.");
        //    }

        //    return this._value.CompareTo(temp._value);
        //}
    }
}
