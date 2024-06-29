namespace _22_GenericDelegateType
{
    // This is not a generic delegate. It is a delegate that takes an integer as a parameter and returns a boolean.
    //public delegate bool FilterDelegate(int number);

    // We can use a generic delegate to pass the condition as a parameter to the method.
    // This way, we can reuse the same method for different conditions.
    public delegate bool FilterDelegate<in T>(T number);        // This is a generic delegate.
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // The difference between the following methods is the condition that is checked.
            // We can use a generic delegate to pass the condition as a parameter to the method.
            // This way, we can reuse the same method for different conditions. 
            Console.WriteLine("Numbers Less Than 6:");
            PrintNumberLessThanSix(numbers);

            Console.WriteLine("\nNumbers Greater Than 6:");
            PrintNumberGreaterThanSix(numbers);

            Console.WriteLine("\nNumbers Less Than 6:");
            PrintNumberLessThan(numbers, 6);

            Console.WriteLine("\nEven Numbers:");
            PrintEvenNumbers(numbers);

            // ----------------------------------------------------------

            Console.WriteLine("\nUsing Generic Delegate\n");

            // We can use a generic delegate to pass the condition as a parameter to the method.
            // This way, we can reuse the same method for different conditions.

            Console.WriteLine("\nNumbers Less Than 6:");
            PrintNumbers(numbers, n => n < 6);

            Console.WriteLine("\nNumbers Greater Than 6:");
            PrintNumbers(numbers, n => n > 6);

            Console.WriteLine("\nNumbers Less Than 6:");
            PrintNumbers(numbers, n => n < 6);

            Console.WriteLine("\nEven Numbers:");
            PrintNumbers(numbers, n => n % 2 == 0);

            IEnumerable<decimal> decimalNumbers = new List<decimal> { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m, 6.6m, 7.7m, 8.8m, 9.9m, 10.10m };

            Console.WriteLine("\nNumbers Less Than 3.2:");
            PrintNumbers(decimalNumbers, n => n < 3.2m);


            // ----------------------------------------------------------

            // Generic .NET Delegates (Func, Action, Predicate) can be used instead of custom delegates. 
            // Func, Action, Predicate are generic delegates that are defined in the System namespace.
            // Func is a generic delegate that can take up to 16 input parameters and returns a value.
            // Action is a generic delegate that can take up to 16 input parameters and does not return a value.
            // Predicate is a generic delegate that takes one input parameter and returns a boolean value.

            // Action has 16 overloads.
            // Func has 17 overloads.
            // Predicate has 1 overload.


            Console.WriteLine("\nUsing .NET Delegates(Func, Action, Predicate)\n");

            // Action
            Action<string> action = Print;
            action("Mohamed");      // Using the Action delegate to call the Print method. 

            // Func 
            Func<int, int, int> func = Sum;
            Console.WriteLine(func(10, 20));          // Using the Func delegate to call the Sum method.  

            // Predicate
            Predicate<int> predicate = IsEven;
            Console.WriteLine(predicate(10));

            PrintNumbers(numbers, n => n < 6, () => Console.WriteLine("Numbers Less Than 6:"));

            Console.ReadKey();
        }


        // The difference between the following methods is the condition that is checked.
        // We can use a generic delegate to pass the condition as a parameter to the method.
        // This way, we can reuse the same method for different conditions. 
        static void PrintNumberLessThanSix(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number < 6)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }

        static void PrintNumberGreaterThanSix(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 6)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }

        static void PrintNumberLessThan(IEnumerable<int> numbers, int pivotNumber)
        {
            foreach (var number in numbers)
            {
                if (number < pivotNumber)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }

        static void PrintEvenNumbers(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }

        // ----------------------------------------------------------

        // We can use a generic delegate to pass the condition as a parameter to the method.
        // This way, we can reuse the same method for different conditions.
        // The condition is passed as a parameter to the method.
        //static void PrintNumbers<T>(IEnumerable<T> numbers, FilterDelegate<T> filter)
        //{
        //    foreach (var number in numbers)
        //    {
        //        if (filter(number))
        //        {
        //            Console.WriteLine(number);
        //        }
        //    }

        //    Console.WriteLine("---------------------");
        //}

        static void PrintNumbers<T>(IEnumerable<T> numbers, Predicate<T> filter)
        {
            foreach (var number in numbers)
            {
                if (filter(number))
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }

        static void PrintNumbers<T>(IEnumerable<T> numbers, Predicate<T> filter, Action action)
        {
            action();

            foreach (var number in numbers)
            {
                if (filter(number))
                {
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("---------------------");
        }


        // Other Methods
        static void Print(string name) => Console.WriteLine(name);
        static int Sum(int n1, int n2) => n1 + n2;
        static bool IsEven(int number) => number % 2 == 0;
    }
}
