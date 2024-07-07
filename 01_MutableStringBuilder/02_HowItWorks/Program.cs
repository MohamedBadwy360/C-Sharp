using System.Text;

namespace _02_HowItWorks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Inner data structure of StringBuilder is char[] array (character array).
            // StringBuilder is mutable, it can be changed after it is created.
            // When you initialize a StringBuilder object, it creates a char[] array with a default size of 16.
            // If you add more characters than the capacity of the array, it will create a new array with double the size of the original array and copy the original array to the new array.
            // StringBuilder is more efficient than string when you need to concatenate multiple strings.
            // StringBuilder is not thread-safe, so it is not recommended to use it in a multi-threaded environment.
            // MaxCapacity is the maximum number of characters that can be contained in the current instance. It is 2,147,483,647 by default.

            // When adding or appending a string to a StringBuilder object, it create a new StringBuilder object with the new string and the new StringBuilder object is referencing the old StringBuilder object.
            // It makes parent child relationship between StringBuilder objects. The parent StringBuilder object is the original StringBuilder object and the child StringBuilder object is the new StringBuilder object.

            // -------------------------------------------------------------------------------------------

            // RunArrayOfCharacterConcept();
            // RunStringBuilderProperties();
            RunStringBuilderHowItWorks();

            Console.ReadKey();
        }

        static void RunArrayOfCharacterConcept()
        {
            // char[] characters = new char[9];
            char[] characters;
            // Console.WriteLine(characters.Length);  // use of unassigned error

            characters = new char[9];

            characters[0] = 'M';
            characters[1] = 'e';
            characters[2] = 't';
            characters[3] = 'i';
            characters[4] = 'g';
            characters[5] = 'a';
            characters[6] = 't';
            characters[7] = 'o';
            characters[8] = 'r';



            // or
            characters = new char[9] { 'M', 'e', 't', 'i', 'g', 'a', 't', 'o', 'r' };

            // or
            characters = new char[] { 'M', 'e', 't', 'i', 'g', 'a', 't', 'o', 'r' };

            characters[0] = 'm'; // mutate

            Console.WriteLine(characters);
        }

        static void RunStringBuilderProperties()
        {

            var sb = new StringBuilder("Metigator");

            Console.WriteLine(sb.ToString());              // Metigator

            //the characters the object currently contains
            Console.WriteLine($"Length: {sb.Length}");     // 9  

            //  the number of characters that the object can contain.
            Console.WriteLine($"Capacity: {sb.Capacity}"); // 16 (default)

            // the maximum capacity, if it's reached,  OutOfMemoryException
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); // 2,147,483,647  (default)

            Console.WriteLine($"First Letter: {sb[0]}");     // M  Index out of range exception 

        }

        static void RunStringBuilderHowItWorks()
        {

            var sb = new StringBuilder();
            // sb is a StringBuilder object
            // string value is empty, length 0, capacity 16, maxcapacity is 2,147,483,647

            sb.Append("I Love Metigator"); // add 16 character

            Console.WriteLine($"Length: {sb.Length}");           // 16
            Console.WriteLine($"Capacity: {sb.Capacity}");       // 16  (default)
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); // 2,147,483,647 (default)

            sb.Append("Youtube Channel"); // add 15 character

            Console.WriteLine($"Length: {sb.Length}");           // 31
            Console.WriteLine($"Capacity: {sb.Capacity}");       // 32 (size doubled)
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); // 2,147,483,647 (default)
        }
    }
}
