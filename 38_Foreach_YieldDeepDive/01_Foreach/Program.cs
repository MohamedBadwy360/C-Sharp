namespace _01_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Any collection in C# should implement IEnumerable interface to be able to use foreach loop on it.
            // IEnumerable interface has only one method called GetEnumerator() which returns an IEnumerator object.
            // IEnumerator interface has three methods: MoveNext(), Reset() and Current.
            // MoveNext() method moves the cursor to the next element in the collection.
            // Reset() method resets the cursor to the beginning of the collection.
            // Current property returns the current element in the collection.

            // The foreach loop is a shorthand for the following code:
            // var enumerator = collection.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            //     var item = enumerator.Current;
            //     // Do something with item
            // }

            // The foreach loop is a read-only loop. You can't modify the collection while iterating over it.
            // If you want to modify the collection while iterating over it, you should use for loop instead.

            // The foreach loop is slower than for loop because it creates an enumerator object and calls its methods for each iteration.
            // If you need to iterate over a collection with high performance, you should use for loop instead.

            // The foreach loop is more readable and less error-prone than for loop.
            // If you need to iterate over a collection with less code and less error, you should use foreach loop.

            // The foreach loop is a syntactic sugar for the enumerator pattern.
            // The enumerator pattern is a design pattern that allows iterating over a collection without exposing its internal structure.

            // The foreach loop is a language feature that allows iterating over any collection that implements IEnumerable interface.
            // IEnumerable interface is a part of System.Collections namespace in .NET Framework.

            // Under the hood, the foreach loop uses the enumerator pattern to iterate over a collection.
            // ClR (Common Language Runtime) calls the GetEnumerator() method on the collection to get an enumerator object.
            // Then, it calls the MoveNext() method on the enumerator object to move the cursor to the next element in the collection.
            // Finally, it reads the Current property of the enumerator object to get the current element in the collection.

            // The foreach loop is a high-level loop that abstracts the low-level details of the enumerator pattern.
            // It makes the code more readable and less error-prone.

            // CLR doesn't understand foreach loop. It wait ntil the compiler translate the foreach loop to the enumerator pattern.
            // The compiler translates the foreach loop to the enumerator pattern by calling the GetEnumerator() method on the collection.
            // Then, it calls the MoveNext() method on the enumerator object to move the cursor to the next element in the collection.
            // Finally, it reads the Current property of the enumerator object to get the current element in the collection.

            // CLR understands for loop. It doesn't need the compiler to translate the for loop to the enumerator pattern.

            // Recommendation: 
            // Use foreach loop when you need to iterate over a collection with less code and less error.
            // Use for loop when you need to iterate over a collection with high performance.
            // Use for loop with arrays but use foreach loop with collections.


            // ------------------------------------------------------------------------------------------- 

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("\n\n Using For");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]}");
            }


            Console.WriteLine("\n\n Using Foreach");
            foreach (var n in numbers)
            {
                Console.Write($" {n}");
            }

            Console.WriteLine("\n\n Using Foreach under the hood");
            Foreach(numbers);


            Console.ReadKey();
        }



        // CLR do the code below for foreach loop under the hood.
        static void Foreach<T>(IEnumerable<T> source)
        {
            IEnumerator<T> enumerator = source.GetEnumerator();
            IDisposable disposable;

            try
            {
                while (enumerator.MoveNext())
                {
                    var item = enumerator.Current;

                    Console.Write($" {item}");
                }
            }
            finally
            {
                disposable = (IDisposable)enumerator;
                disposable.Dispose();
            }
        }
    }
}
