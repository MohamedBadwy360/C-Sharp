namespace _04_ValueTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ValueTuple is a new feature in C# 7.0
            // It is a value type that can be used to create a tuple with a specific number of elements and access the elements by name or by index.
            // ValueTuple is a struct type that provides the same functionality as Tuple class.
            // ValueTuple is a value type, so it is more efficient than Tuple class.
            // ValueTuple is a generic type, so you can create a tuple with a specific number of elements.
            // ValueTuple is a mutable type, so you can change the value of its elements.
            // ValueTuple is a lightweight type, so it is more efficient than Tuple class.
            // ValueTuple is a struct type, so it is a value type.
            // ValueTuple is a generic type, so you can create a tuple with a specific number of elements.
            // ValueTuple is stored in stack memory, so it is more efficient than Tuple class except when the tuple is stored in a collection or it has a reference type element.
            // ValueTuple are more readable and easier to use than Tuple class.

            // Implicitly named tuple elements
            // ValueTuple allows you to create a tuple with implicitly named elements.
            // You can access the elements by name or by index.
            // You can use the Item1, Item2, Item3, and Item4 properties to access the elements by index.
            // You can use the Deconstruct method to deconstruct a tuple into individual variables.
            // You can use the ToString method to get the string representation of a tuple.
            // (string, double) is a tuple type with two elements of string and double types.
            // (string, double) t1 = ("Hospital", 2.5); creates a tuple with two elements.
            // You can access the elements by name or by index.

            // Explicitly named tuple elements
            // ValueTuple allows you to create a tuple with explicitly named elements.
            // You can access the elements by name or by index.
            // You can use names to access the elements.
            // (string Name, double Distance) is a tuple type with two elements of string and double types.
            // (string Name, double Distance) t1 = ("Hospital, 2.5); creates a tuple with two elements.
            // You can access the elements by name or by index.

            // Deconstructing a tuple
            // You can use the Deconstruct method to deconstruct a tuple into individual variables.
            // You can deconstruct a tuple into individual variables.
            // (string Name, double Distance) = t1; deconstructs the tuple t1 into individual variables.
            // You can access the elements by name or by index.



            // --------------------------------------------------------------------------------------------

            Tuple<string, double> t1 = new Tuple<string, double>("Hsopital", 2.5);
            Console.WriteLine($"t1: {t1}");
            Console.WriteLine("-------------------------------");

            ValueTuple<string, double> t2 = new ValueTuple<string, double>("Hsopital", 2.5);
            Console.WriteLine($"t2: {t2}");
            Console.WriteLine("-------------------------------");

            var t3 = FacilityDistanceCalculator.CalculateFacilityDistance("Hospital");
            Console.WriteLine($"t3: {t3}");
            Console.WriteLine("-------------------------------");

            var t4 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");
            Console.WriteLine($"t4: {t4}");
            Console.WriteLine($"FacilityName: {t4.Item1}");
            Console.WriteLine("-------------------------------");

            var t5 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
            Console.WriteLine($"t5: {t5}");
            Console.WriteLine($"FacilityName: {t5.Name}");
            Console.WriteLine($"Distance: {t5.DistanceInKm}");
            Console.WriteLine("-------------------------------");

            // deconstructing a tuple
            (string name, string distance) = t5;
            Console.WriteLine($"FacilityName: {name}");
            Console.WriteLine($"Distance: {distance}");

            Console.ReadKey();
        }
    }
}
