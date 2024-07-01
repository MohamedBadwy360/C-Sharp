namespace _01_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lists are similar to arrays, but they can grow and shrink in size dynamically. 
            // They are also more flexible than arrays.
            // Lists are defined in the System.Collections.Generic namespace.
            // You can access the list elements by their index, just like an array. (Random access)
            // The data in a list is stored in a contiguous memory location, just like an array.
            // The data is kept in memory after processing. 
            // List<T> is a generic class. T is the type of elements in the list.
            // List<T> is a dynamic array. It can grow and shrink in size.

            var egypt = new Country { IsoCode = "EG", Name = "Egypt" };
            var iraq = new Country { IsoCode = "IQ", Name = "Iraq" };
            var jordan = new Country { IsoCode = "JO", Name = "Jordan" };

            Country[] countriesArray = { egypt, iraq, jordan };


            // ---------------------------- Constructors ----------------------------
            List<Country> countries = new List<Country>();  // Empty list
            //List<Country> countries2 = new List<Country>(countriesArray);  // List with initial values

            List<Country> countries2 = new List<Country>(3);  // List with initial capacity


            // ---------------------------- Properties ------------------------------

            // Capacity => Gets or sets the total number of elements the internal data structure can hold without resizing.
            // Capacity is always greater than or equal to Count. 
            // Capacity is automatically increased when the number of elements exceeds the Capacity.
            // Capacity is automatically decreased when the number of elements is less than a quarter of the Capacity.
            // Capacity increases by a factor of 2 when it needs to be increased.
            int capacity = countries.Capacity;  // 4

            // Count => Gets the number of elements actually contained in the List<T>.
            int count = countries.Count;        // 0



            // ---------------------------- Methods ---------------------------------

            // Add => Adds an object to the end of the List<T>.
            countries.Add(new Country { IsoCode = "BRA", Name = "Brazil" });                // O(1)
            Print(countries);

            // AddRange => Adds the elements of the specified collection to the end of the List<T>.
            countries.AddRange(countriesArray);                                             // O(1)
            Print(countries);

            // Insert => Inserts an element into the List<T> at the specified index.
            countries.Insert(1, new Country { IsoCode = "SA", Name = "Saudi Arabia" });     // O(n) because it shifts the elements
            Print(countries);

            // InsertRange => Inserts the elements of a collection into the List<T> at the specified index.
            countries.InsertRange(2, countriesArray);                                       // O(n) because it shifts the elements
            Print(countries);

            // Clear => Removes all elements from the List<T>.
            //countries.Clear();                                                              // O(n) because it removes all elements

            // Remove => Removes the first occurrence of a specific object from the List<T>.
            //countries.Remove(egypt);      // passing the reference                    // O(n) because it shifts the elements
            // if you want to remove by value/new object or passing a new object, you need to implement the Equals method and GetHashCode method in the Country class
            countries.Remove(new Country { IsoCode = "EG", Name = "Egypt" });               // O(n) because it shifts the elements
            Print(countries);

            // RemoveAt => Removes the element at the specified index of the List<T>.
            countries.RemoveAt(4);                                                           // O(n) because it shifts the elements
            Print(countries);

            // RemoveRange => Removes a range of elements from the List<T>.
            //countries.RemoveRange(1, 2);                                                     // O(n) because it shifts the elements

            // RemoveAll => Removes all the elements that match the conditions defined by the specified predicate.
            countries.RemoveAll(c => c.IsoCode == "JO");                                     // O(n) because it shifts the elements
            Print(countries);
        }


        static void Print(List<Country> countries)
        {
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            // ---------------------------- Properties ------------------------------
            Console.WriteLine($"Count: {countries.Count}");                 // actual number of elements in the list 
            Console.WriteLine($"Capacity: {countries.Capacity}");           // initial number of elements the list can hold without resizing 
            Console.WriteLine("-----------------------------------------------------------");
        }
    }

    class Country
    {
        public string IsoCode { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null || obj is not Country country)
            {
                return false;
            }

            return IsoCode.Equals(country.IsoCode, StringComparison.OrdinalIgnoreCase) && Name.Equals(country.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            int hash = 7;
            hash = hash * 13 + IsoCode.GetHashCode();
            hash = hash * 13 + Name.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"{Name} ({IsoCode})";   // Egypt (EG)
        }
    }
}
