namespace _03_TupleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuple class is a data structure that can hold up to 8 elements of different types in a single object.
            // It is a reference type and can be used to create a tuple object that can hold multiple elements.
            // It is defined in the System namespace.
            // Tuple class is a generic class, so you can specify the type of elements it can hold.
            // Tuple class is immutable, which means once you create a tuple object, you cannot change its values.
            // You can create a tuple object using the static Create method of the Tuple class.
            // You can access the elements of a tuple object using the Item1, Item2, Item3, and so on properties.
            // You can also use the Deconstruct method to deconstruct a tuple object into its elements.

            // Tuple<T1> class is a generic class that can hold a single element of type T1.
            // Tuple<T1, T2> class is a generic class that can hold two elements of types T1 and T2.
            // Tuple<T1, T2, T3> class is a generic class that can hold three elements of types T1, T2, and T3.
            // Tuple<T1, T2, T3, T4> class is a generic class that can hold four elements of types T1, T2, T3, and T4.
            // Tuple<T1, T2, T3, T4, T5> class is a generic class that can hold five elements of types T1, T2, T3, T4, and T5.
            // Tuple<T1, T2, T3, T4, T5, T6> class is a generic class that can hold six elements of types T1, T2, T3, T4, T5, and T6.
            // Tuple<T1, T2, T3, T4, T5, T6, T7> class is a generic class that can hold seven elements of types T1, T2, T3, T4, T5, T6, and T7.
            // Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> class is a generic class that can hold eight elements of types T1, T2, T3, T4, T5, T6, T7, and TRest.

            // Tuple.Create() method is used to create a tuple object.
            // Tuple.Create() method is a static method that is defined in the Tuple class.
            // Tuple.Create() method is overloaded to create tuple objects with different numbers of elements.
            // Tuple.Create() method is a generic method, so you can specify the type of elements it can hold.

            // I can create tuple object using constructor of Tuple class but Tuple.Create() method is more readable and easy to use.


            // Tuple.Item1 property is used to get the first element of a tuple object.
            // Tuple.Item2 property is used to get the second element of a tuple object.
            // Tuple.Item3 property is used to get the third element of a tuple object.
            // Tuple.Item4 property is used to get the fourth element of a tuple object.
            // ........ and so on.

            // Equality in Tuple class
            // Tuple class overrides the Equals method to compare the values of the elements of the tuple objects.
            // Tuple class does not override the == operator, so you cannot use the == operator to compare two tuple objects.
            // You can use the Equals method to compare two tuple objects.


            // ------------------------------------------------------------------------------------------------

            Console.WriteLine("Get FacilityInfo using Tuple.Create");

            var facilityInfo = FacilityDistanceCalculator.CalculateFacilityDistance("Hospital");

            Console.WriteLine(facilityInfo);

            Console.WriteLine("------------------------");

            Console.WriteLine("Get FacilityInfo using Tuple Constructor");

            var facilityInfoV2 = FacilityDistanceCalculator.CalculateFacilityDistanceV2("Hospital");

            Console.WriteLine(facilityInfoV2);

            Console.WriteLine("------------------------");

            Console.WriteLine("Get FacilityInfo using Tuple.Create / Access Item");

            var facilityInfoV3 = FacilityDistanceCalculator.CalculateFacilityDistanceV3("Hospital");
            Console.WriteLine($"{facilityInfoV3.Item1} ....... {facilityInfoV3.Item2.ToString("F2")} km");

            Console.WriteLine("-------------------");

            var t1 = Tuple.Create("Hospital", 1.5);
            var t2 = Tuple.Create("Hospital", 1.5);

            Console.WriteLine(t1.Equals(t2));       // True => because Tuple class overrides Equals method
            Console.WriteLine(t1 == t2);            // False => because Tuple class does not override == operator

            Console.ReadKey();
        }
    }
}
