using System.Collections;

namespace _21_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generics is a feature of C# that allows you to define classes, interfaces, and methods with placeholders for the data type.
            // The placeholder is replaced by the data type when the class, interface, or method is instantiated.
            // Generics allow you to write reusable code that can work with any data type.
            // Generics are used in many C# collections, such as List<T>, Dictionary<TKey, TValue>, and Queue<T>.
            // Benefits of Generics:
            // 1. Type Safety: Generics provide compile-time type checking, which means that you can catch type errors at compile time.
            // 2. Reusability: Generics allow you to write reusable code that can work with any data type.
            // 3. Performance: Generics improve performance by eliminating the need for boxing and unboxing operations.
            // 4. Code Clarity: Generics make your code more readable and maintainable by removing the need for casting.
            // 5. Reduced Code Duplication: Generics reduce code duplication by allowing you to write a single class, interface, or method that can work with any data type.
            // 6. Flexibility: Generics provide flexibility by allowing you to define classes, interfaces, and methods that can work with any data type.
            // 7. Type Inference: Generics provide type inference, which means that you do not need to specify the data type when instantiating a generic class or method.
            // 8. Constraints: Generics allow you to apply constraints to the data type, such as requiring the data type to implement a specific interface or have a default constructor.
            // 9. Covariance and Contravariance: Generics support covariance and contravariance, which allow you to assign a generic type to a more derived or less derived type.
            // 10. Maintainability: Generics improve the maintainability of your code by reducing the number of classes, interfaces, and methods you need to write.
            // 11. Extensibility: Generics allow you to extend the functionality of your code by defining custom generic classes, interfaces, and methods.
            // 12. Interoperability: Generics improve interoperability by allowing you to work with other .NET languages that support generics.
            // 13. Error Handling: Generics provide better error handling by allowing you to catch type errors at compile time.
            // Generics can be applied to classes, interfaces, and methods.
            // Generic class can have non generic methods and properties and non generic class can have generic methods and properties.


            // The client will provide the data type when using the generic class, interface, or method.
            // The data type is specified in angle brackets (<>) after the class, interface, or method name.

            // Generics Constraints: Generics constraints allow you to apply constraints to the data type in a generic class, interface, or method.
            // You can apply constraints to the data type by using the where keyword followed by the constraint.
            // The constraint specifies the requirements that the data type must meet in order to be used with the generic class, interface, or method.
            // There are several types of constraints that you can apply to the data type, such as:
            // 1. Base Class Constraint: Requires the data type to be a subclass of a specified base class.
            // 2. Interface Constraint: Requires the data type to implement a specified interface.
            // 3. Constructor Constraint: Requires the data type to have a default constructor.
            // 4. Reference Type Constraint: Requires the data type to be a reference type.
            // 5. Value Type Constraint: Requires the data type to be a value type.
            // 6. New Constraint: Requires the data type to have a default constructor.



            Print(1);
            Print("Hello");
            Print('A');

            Console.WriteLine("------------------------");

            //var numbers = new ArrayOfAny<int>();      
            //numbers.Add(10);
            ////numbers.Add("hello");   // This will not compile because the data type is int. => ensures type safety.
            //numbers.Add(20);
            //numbers.Add(30);
            //numbers.Add(40);
            //numbers.Add(50);
            //numbers.DisplayArray();     // [ 10, 20, 30, 40, 50 ]
            //numbers.RemoveAt(2);
            //numbers.DisplayArray();     // [ 10, 20, 40, 50 ]


            var persons = new ArrayOfAny<Person>();     // Person is a class and matches the constraint.
            persons.Add(new Person { Name = "John" });
            persons.Add(new Person { Name = "Jane" });
            persons.DisplayArray();     // [ "John", "Jane" ]
            persons.RemoveAt(1);
            persons.DisplayArray();     // [ "John" ]


            // .Net Framework provides many generic classes, interfaces, and methods.
            // List<T> class is a generic collection that allows you to store a list of items of a specific data type.
            // List<T> class is defined in the System.Collections.Generic namespace.
            // List<T> class provides methods for adding, removing, and searching for items in the list.
            // System.Collections.Generic is Type Safe
            var people = new List<Person>();
            people.Add(new Person { Name = "Mohamed" });
            persons.Add(new Person { Name = "Elsaid" });
            persons.Add(new Person { Name = "Ahmed" });
            Console.WriteLine("--------------------------------");
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

            // ArrayList class is a non-generic collection that allows you to store a list of items of any data type.
            // ArrayList class is defined in the System.Collections namespace.
            // ArrayList class is not type safe because it can store items of any data type.
            // System.Collections is not Type Safe => Boxing and Unboxing operations are required. => Performance issue.
            // You can store items of any data type in an ArrayList, such as integers, strings, characters, and objects.
            var people2 = new ArrayList();
            people2.Add(new Person { Name = "Mohamed" });
            people2.Add("Elsaid");
            people2.Add(123);
            people2.Add('A');
            Console.WriteLine("--------------------------------");
            foreach (var person in people2)
            {
                Console.WriteLine(person);
            }
        }

        // The down code is not reusable because we have to write a separate method for each data type.

        //static void Print(int value)
        //{
        //    Console.WriteLine(value);
        //}

        //static void Print(string value)
        //{
        //    Console.WriteLine(value);
        //}

        //static void Print(char value)
        //{
        //    Console.WriteLine(value);
        //}


        // This method is reusable but it is not type safe because it accepts any data type and does not provide compile-time type checking and there will be boxing and unboxing operations.
        // There will be a performance issue, not type safe, and hard to avoid mistakes.
        //static void Print(object value)
        //{
        //    Console.WriteLine(value);
        //}


        // To make this method type safe, we can use Generics.
        // Generic Method Syntax: To define a generic method, you use angle brackets (<>) to specify a type parameter, followed by the method name and the type parameter.
        // The type parameter can be used as a placeholder for the data type in the method signature.
        // The type parameter is replaced by the actual data type when the method is called.
        static void Print<T>(T value)
        {
            Console.WriteLine($"DataType: {typeof(T).Name}");
            Console.WriteLine(value);
        }
    }


    // Generic Class Syntax: To define a generic class, you use angle brackets (<>) to specify a type parameter, followed by the class name and the type parameter.
    // The type parameter can be used as a placeholder for the data type in the class definition.
    // The type parameter is replaced by the actual data type when the class is instantiated.
    // where T : constraint1, constraint2, ... : The where keyword is used to apply constraints to the data type in a generic class.
    // T must be a class.
    // T must have a default constructor.
    class ArrayOfAny<T> where T : class, new()
    {
        private T[] _items;

        public void Add(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else
            {
                var length = _items.Length;
                var tempArray = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    tempArray[i] = _items[i];
                }

                tempArray[length] = item;
                _items = tempArray;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _items.Length - 1)
            {
                return;
            }

            var tempArray = new T[_items.Length - 1];
            for (int i = 0, j = 0; i < _items.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }

                tempArray[j++] = _items[i];
                //j++;
            }

            _items = tempArray;
        }

        public bool IsEmpty => _items.Length == 0 || _items is null;
        public int Count => (_items is null) ? 0 : _items.Length;

        public void DisplayArray()
        {
            Console.Write("[ ");
            foreach (var item in _items)
            {
                Console.Write(item);
                if (!item.Equals(_items[_items.Length - 1]))
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");
        }
    }

    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"\"{Name}\"";
        }
    }
}
