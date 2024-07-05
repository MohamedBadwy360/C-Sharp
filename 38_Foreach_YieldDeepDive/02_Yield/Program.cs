namespace _02_Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yield is used to return a sequence of values from a method without having to return a collection.
            // The method that contains the yield return statement is called an iterator method.
            // When you use yield return in a method, you indicate that the method, operator, or get accessor in which it appears is an iterator.
            // Using yield to define an iterator removes the need for an explicit extra class to hold the state for the enumeration.
            // The yield keyword signals to the compiler that the method in which it appears is an iterator block.
            // The compiler generates a class to implement the behavior that is expressed in the iterator block.
            // In the iterator block, the yield keyword is used together with return to provide a value to the enumerator object.
            // The yield keyword is used in the block in which the value is produced, and return is used in the block from which the value is consumed.
            // The yield statement can only appear inside an iterator block, which is a method, operator, or get accessor that contains a yield return or yield break statement.
            // The yield statement is used to return each element one at a time.
            // The sequence returned by an iterator method can be consumed by using a foreach statement or LINQ query.
            // The iterator block can contain a try-catch block, but it cannot contain a try-finally block.
            // The iterator block can contain a using statement, but it cannot contain a lock statement.
            // The iterator block can contain a yield break statement, which will end the iteration.
            // The iterator block can contain a yield return statement, which will return the value and continue the iteration.
            // The iterator block can contain a yield return statement that returns a value and then exits the iterator block.


            // yield is used to return a sequence of values from a method without having to return a collection.
            // Yield keyword return values one by one to the caller.
            // The caller can consume the values one by one.

            // yield return: Returns a value and continues the iteration.
            // yield break: Ends the iteration.

            // yield is used very often in LINQ queries and foreach loops.
            // yield is used very often foreach loops because foreach loops call the GetEnumerator() method of the collection and then call the MoveNext() method which in turn calls the Current property to get the value and then the loop continues.

            // -----------------------------------------------------------------------------------------------

            //Console.WriteLine("using GenerateV1()");
            //foreach (var n in GenerateV1())
            //{
            //    Console.Write($" {n}");
            //}

            //Console.WriteLine("\n\nusing GenerateV2()");
            //foreach (var n in GenerateV2())
            //{
            //    Console.Write($" {n}");
            //}

            Console.WriteLine("\n\nusing GenerateV3()");
            foreach (var n in GenerateV3())
            {
                Console.Write($" {n}");
            }


            Console.ReadKey();
        }

        static IEnumerable<int> GenerateV1()
        {
            var result = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                result.Add(i);
            }
            return result;
        }

        static IEnumerable<int> GenerateV2()
        {
            for (int i = 1; i <= 5; i++)
            {
                // Yield return values one by one to the caller.
                yield return i;
            }
        }

        // Method should return IEnumerable<T> or IEnumerable / iterator block
        static IEnumerable<int> GenerateV3()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
        }

        static IEnumerable<int> GenerateV4()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield break;        // End the iteration here and return control to the caller.
            yield return 6;
            yield return 7;
            yield return 8;
        }
    }
}
