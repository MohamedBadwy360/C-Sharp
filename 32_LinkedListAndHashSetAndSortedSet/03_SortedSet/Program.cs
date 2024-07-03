namespace _03_SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedSet<T> is a collection of unique objects that are maintained in sorted order.
            // The SortedSet<T> class is a generic class that is defined in the System.Collections.Generic namespace.
            // The SortedSet<T> class is a collection of unique objects that are maintained in sorted order.
            // The SortedSet<T> class is a generic class that is defined in the System.Collections.Generic namespace.
            // The SortedSet<T> uses a red-black tree as the underlying data structure to store the elements.
            // The SortedSet<T> class provides the following properties and methods to work with the collection:
            // Add(T) method: Adds an element to the SortedSet<T> collection.
            // Clear() method: Removes all elements from the SortedSet<T> collection.
            // Contains(T) method: Determines whether an element is in the SortedSet<T> collection.
            // Remove(T) method: Removes an element from the SortedSet<T> collection.
            // Count property: Gets the number of elements in the SortedSet<T> collection.
            // Max property: Gets the maximum value in the SortedSet<T> collection.
            // Min property: Gets the minimum value in the SortedSet<T> collection.
            // GetEnumerator() method: Returns an enumerator that iterates through the SortedSet<T> collection.
            // The SortedSet<T> class provides the following constructors to create a SortedSet<T> collection:
            // SortedSet<T>() constructor: Initializes a new instance of the SortedSet<T> class that is empty and uses the default comparer for the element type.
            // SortedSet<T>(IEnumerable<T>) constructor: Initializes a new instance of the SortedSet<T> class that contains elements copied from the specified collection and uses the default comparer for the element type.
            // SortedSet<T>(IComparer<T>) constructor: Initializes a new instance of the SortedSet<T> class that is empty and uses the specified comparer for the element type.
            // SortedSet<T>(IEnumerable<T>, IComparer<T>) constructor: Initializes a new instance of the SortedSet<T> class that contains elements copied from the specified collection and uses the specified comparer for the element type.
            // SortedSet<T>(IComparer<T>, IEqualityComparer<T>) constructor: Initializes a new instance of the SortedSet<T> class that is empty, uses the specified comparer for the element type, and uses the specified equality comparer for the element type.
            // SortedSet<T>(IEnumerable<T>, IComparer<T>, IEqualityComparer<T>) constructor: Initializes a new instance of the SortedSet<T> class that contains elements copied from the specified collection, uses the specified comparer for the element type, and uses the specified equality comparer for the element type.



            List<Customer> customersList = new List<Customer>
            {
                new Customer { Name = "Mark", Telephone = "123456" },
                new Customer { Name = "Mohammed", Telephone = "789654" },
                new Customer { Name = "John", Telephone = "321654" },
                new Customer { Name = "Elsaid", Telephone = "987654" },
                new Customer { Name = "Asmaa", Telephone = "125989" }
            };

            SortedSet<Customer> customersSortedSet = new SortedSet<Customer>(customersList);

            customersSortedSet.Add(new Customer { Name = "Baker", Telephone = "154986" });          // Add a new customer to the SortedSet collection 

            foreach (var customer in customersSortedSet)                    // Sorted by Name
            {
                Console.WriteLine(customer);
            }
        }
    }

    // To Sort a collection of objects, the objects must implement the IComparable interface to define the default sort order. 
    class Customer : IComparable<Customer>
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

        public int CompareTo(Customer other)
        {
            if (other is null)
            {
                return 1;
            }

            if (object.ReferenceEquals(this, other))
            {
                return 0;
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}
