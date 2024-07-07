using System.Collections;

namespace _01_ConceptBehindTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple is a data structure that can hold multiple elements of different types.
            // Tuple is a generic type.
            // Tuple can hold up to 8 elements.
            // We can create a tuple using the Tuple class or using the ValueTuple struct.
            // We can access the elements of a tuple using the Item1, Item2, Item3, ... properties.
            // We can also name the elements of a tuple using the Item1, Item2, Item3, ... properties.


            // array reference type (list with fixed size) 
            int[] array = { 50, 10, 23, 1, 7, -4 };

            // list represents a dynamically-sized list generally contageous
            List<int> list = new List<int> { 50, 10, 23, 1, 7, -4 };

            list.AddRange(list); // { 50, 10, 23, 1, 7, -4, 50, 10, 23, 1, 7, -4 };



            // collection
            ArrayList al = new ArrayList { "50", 10, 23.2m, DateTime.Now };


            // In .NET Framework new Data Structure is introduced System.Tuple
            Tuple<int, int, int, int, int, int> tuples1 =
                new Tuple<int, int, int, int, int, int>(50, 10, 23, 1, 7, -4);

            Tuple<int, int, int, int, int, int> tuples2 = Tuple.Create(50, 10, 23, 1, 7, -4);

            Tuple<string, decimal> distances = Tuple.Create("hospital", 2.5m);
        }
    }
}
