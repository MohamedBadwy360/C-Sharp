namespace _02_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet is a collection of unique elements (no duplicates) that uses a hash table for storage.
            // HashSet<T> class is defined in the System.Collections.Generic namespace.
            // HashSet<T> class is introduced in .NET Framework 3.5.
            // HashSet<T> class is a generic collection, so you can store elements of any type in it.
            // HashSet<T> uses the default equality comparer to compare elements.
            // HashSet<T> internally uses a Dictionary<T, T> to store elements.
            // HashSet<T> internally stores key and value pairs where key represents the element and value represents a dummy value (null).
            // HashSet<T> does not allow duplicate elements.
            // HashSet<T> is not sorted and does not maintain the order of elements.
            // HashSet<T> is not thread-safe, so you must synchronize access to a HashSet<T> object.
            // HashSet<T> provides high-performance set operations such as UnionWith, IntersectWith, ExceptWith, and SymmetricExceptWith.
            // HashSet<T> provides O(1) search operations.
            // HashSet<T> provides O(1) insertion and deletion operations.
            // HashSet<T> provides O(n) set operations such as UnionWith, IntersectWith, ExceptWith, and SymmetricExceptWith.
            // HashSet<T> provides O(n) set operations such as IsSubsetOf, IsSupersetOf, Overlaps, and SetEquals.

            // HashSet<T> class provides the following constructors:
            // HashSet<T>() - Initializes a new instance of the HashSet<T> class that is empty and uses the default equality comparer for the set type.
            // HashSet<T>(IEnumerable<T>) - Initializes a new instance of the HashSet<T> class that uses the default equality comparer for the set type, contains elements copied from the specified collection, and has sufficient capacity to accommodate the number of elements copied.
            // HashSet<T>(IEnumerable<T>, IEqualityComparer<T>) - Initializes a new instance of the HashSet<T> class that uses the specified equality comparer for the set type, contains elements copied from the specified collection, and has sufficient capacity to accommodate the number of elements copied.
            // HashSet<T>(IEqualityComparer<T>) - Initializes a new instance of the HashSet<T> class that is empty and uses the specified equality comparer for the set type.
            // HashSet<T>(int) - Initializes a new instance of the HashSet<T> class that is empty, has the specified initial capacity, and uses the default equality comparer for the set type.
            // HashSet<T>(int, IEqualityComparer<T>) - Initializes a new instance of the HashSet<T> class that is empty, has the specified initial capacity, and uses the specified equality comparer for the set type.

            // HashSet<T> class provides the following methods:
            // Add(T) - Adds the specified element to a HashSet<T> object.
            // Clear() - Removes all elements from a HashSet<T> object.
            // Contains(T) - Determines whether a HashSet<T> object contains the specified element.
            // CopyTo(T[], int) - Copies the elements of a HashSet<T> object to an array.
            // ExceptWith(IEnumerable<T>) - Removes all elements in the specified collection from the current HashSet<T> object.
            // IntersectWith(IEnumerable<T>) - Modifies the current HashSet<T> object to contain only elements that are present in that object and in the specified collection.
            // IsProperSubsetOf(IEnumerable<T>) - Determines whether a HashSet<T> object is a proper subset of the specified collection.
            // IsProperSupersetOf(IEnumerable<T>) - Determines whether a HashSet<T> object is a proper superset of the specified collection.
            // IsSubsetOf(IEnumerable<T>) - Determines whether a HashSet<T> object is a subset of the specified collection.
            // IsSupersetOf(IEnumerable<T>) - Determines whether a HashSet<T> object is a superset of the specified collection.
            // Overlaps(IEnumerable<T>) - Determines whether a HashSet<T> object overlaps with the specified collection.
            // Remove(T) - Removes the specified element from a HashSet<T> object.
            // SetEquals(IEnumerable<T>) - Determines whether a HashSet<T> object and the specified collection contain the same elements.
            // SymmetricExceptWith(IEnumerable<T>) - Modifies the current HashSet<T> object to contain only elements that are present either in that object or in the specified collection, but not both.
            // UnionWith(IEnumerable<T>) - Modifies the current HashSet<T> object to contain all elements that are present in itself, the specified collection, or both.

            // HashSet<T> class provides the following properties:
            // Count - Gets the number of elements contained in a HashSet<T> object.
            // IsReadOnly - Gets a value indicating whether a HashSet<T> object is read-only.
            // Comparer - Gets the equality comparer that is used to determine equality for the values in the set.




            //var customer1 = new Customer { Name = "Mark", Telephone = "123456" };
            //var customer2 = new Customer { Name = "Mark", Telephone = "123456" };
            //Console.WriteLine(customer1.Name.GetHashCode());                        // will print hash code of Name
            //Console.WriteLine(customer1.Telephone.GetHashCode());                   // will print hash code of Telephone    
            //Console.WriteLine(customer1.Equals(customer2));                         // will print if customer1 is equal to customer2 or not based on Equals method implementation in Customer class (value equality)    => True
            //Console.WriteLine(object.ReferenceEquals(customer1, customer2));        // will print if customer1 is same as customer2 or not based on reference equality implementation in object class (reference equality)  => False

            List<Customer> customersList = new List<Customer>
            {
                new Customer { Name = "Mark", Telephone = "123456" },
                new Customer { Name = "Mohammed", Telephone = "789654" },
                new Customer { Name = "John", Telephone = "321654" },
                new Customer { Name = "Elsaid", Telephone = "987654" },
                new Customer { Name = "Asmaa", Telephone = "125989" }
            };

            Console.WriteLine("HashSet");
            Console.WriteLine("-------------------------");

            HashSet<Customer> customersHashSet = new HashSet<Customer>(customersList);

            customersHashSet.Add(new Customer { Name = "Mark", Telephone = "123456" });    // will not be added because it is already exist in the HashSet (no duplicates) 

            foreach (var customer in customersHashSet)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("-------------------------");

            var customerList2 = new List<Customer>
            {
                new Customer { Name = "Mazen", Telephone = "123896" },
                new Customer { Name = "Hazem", Telephone = "789654" },
                new Customer { Name = "Waad", Telephone = "5562328" }
            };

            HashSet<Customer> customersToUnion = new HashSet<Customer>(customerList2);

            customersHashSet.UnionWith(customersToUnion);

            foreach (var customer in customersHashSet)
            {
                Console.WriteLine(customer);
            }
        }
    }


    // To use the Customer class in a HashSet, you need to override the GetHashCode and Equals methods to provide a custom implementation for value equality.
    class Customer
    {
        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Name.GetHashCode();
            hash = (hash * 7) + Telephone.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            if (customer is null)
            {
                return false;
            }

            return Name == customer.Name && Telephone == customer.Telephone;
        }

        public override string ToString()
        {
            return $"{Name} ({Telephone})";
        }
    }
}
