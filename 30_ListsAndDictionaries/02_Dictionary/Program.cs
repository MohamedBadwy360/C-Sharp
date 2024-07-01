namespace _02_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<TKey, TValue> is a collection of key-value pairs. 
            // It is a generic collection. TKey is the type of the key, and TValue is the type of the value.
            // Dictionary<TKey, TValue> is a hash table implementation.
            // Dictionary<TKey, TValue> is defined in the System.Collections.Generic namespace.
            // Dictionary<TKey, TValue> is a generic class.



            var article =
                "Dot NET is a free cross-platform and open source developer platform" +
                "for building many different types of applications" +
                "With Dot NET you can use multiple languages and libraries" +
                "to build for web and IoT";

            // key: 'd', value: "Dot" "Developer"

            Dictionary<char, List<string>> letterDictionary = new Dictionary<char, List<string>>();
            foreach (var word in article.Split())
            {
                foreach (var ch in word)
                {
                    var c = char.ToLower(ch);

                    // ContainsKey => Determines whether the Dictionary<TKey,TValue> contains the specified key. 
                    if (!letterDictionary.ContainsKey(c))
                    {
                        // Add => Adds the specified key and value to the dictionary.
                        letterDictionary.Add(c, new List<string> { word.ToLower() });
                    }

                    // Add => Adds an element with the specified key and value into the Dictionary<TKey,TValue>.
                    letterDictionary[c].Add(word.ToLower());
                }
            }

            //foreach (var (key, value) in letterDictionary)
            //{
            //    Console.WriteLine($"key: '{key}', value: {string.Join(" ", value)}");
            //}

            foreach (var entry in letterDictionary)
            {
                // entry.Key is the key of the dictionary
                Console.WriteLine($"{entry.Key}: ");

                // entry.Value is the value of the dictionary
                foreach (var value in entry.Value)
                {
                    Console.WriteLine($"  {value}");
                }
            }

            Console.WriteLine("--------------------------------");

            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe", ReportTo = null },
                new Employee { Id = 2, Name = "Jane Doe", ReportTo = 1 },
                new Employee { Id = 3, Name = "Sam Doe", ReportTo = 1 },
                new Employee { Id = 4, Name = "Don Doe", ReportTo = 2 },
                new Employee { Id = 5, Name = "Ron Doe", ReportTo = 2 },
                new Employee { Id = 6, Name = "Tom Doe", ReportTo = 3 },
                new Employee { Id = 7, Name = "Tim Doe", ReportTo = 3 },
                new Employee { Id = 8, Name = "Kim Doe", ReportTo = 3 },
            };

            //var managers = employees.GroupBy(e => e.ReportTo);
            var managers = employees.ToLookup(e => e.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());

            foreach (var (key, value) in managers)
            {
                if (key == -1)
                    continue;

                var manager = employees.FirstOrDefault(e => e.Id == key);

                Console.WriteLine($"{manager}: ");
                foreach (var employee in value)
                {
                    Console.WriteLine($"  {employee}");
                }
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ReportTo { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Name}";
        }
    }
}
