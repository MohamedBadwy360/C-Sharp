namespace _05_StringInternPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLR deal with strings in a special way.
            // CLR maintains a pool of strings called the intern pool.
            // When you create a string, the CLR checks the intern pool to see if a string with the same value already exists.
            // If it does, the CLR returns a reference to the existing string.
            // If it doesn't, the CLR adds the string to the intern pool.
            // This is why the following code prints True:
            //string s1 = "hello";
            //string s2 = "hello";
            //System.Console.WriteLine(s1 == s2); // True
            // The two strings are the same object in memory.
            // Benefits:
            // 1. Memory efficiency: If you have many strings with the same value, they will all refer to the same object in memory.
            // 2. Performance: Comparing strings for equality is faster because you can compare the references instead of the values.
            // 3. Security: If you have a password in a string, you can call the intern method to store it in the intern pool.
            //    This way, the password will be stored in memory only once and will be harder to access.
            // 4. Interoperability: When you use interop to call unmanaged code, you can use the intern method to ensure that the strings are the same object in memory.
            //    This way, you can compare strings for equality by comparing the references.
            // 5. String interning is used in the .NET Framework to optimize memory usage.
            // 6. The intern method returns a reference to the interned string.
            // 7. The intern method is a static method of the string class.
            // 8. The intern method is used to ensure that all strings with the same value refer to the same object in memory.
            // 9. The intern method is used to optimize memory usage and improve performance.
            // 10. The intern method is used to ensure that strings are the same object in memory when you compare them for equality.

            // -------------------------------------------------------------------------------------

            // RunStringLiteralVsObject();
            // RunStringLiteralKey();
            // RunStringLiteralWithStringObjectComparison();
            RunStringIntern();

            Console.ReadKey();

        }


        // Difference between string literal and string object
        // String literal: A string literal is a sequence of characters enclosed in double quotes.
        // String object: A string object is an instance of the string class.
        // When you create a string literal, the CLR checks the intern pool to see if a string with the same value already exists.
        // If it does, the CLR returns a reference to the existing string.
        // If it doesn't, the CLR adds the string to the intern pool.
        // When you create a string object, the CLR creates a new instance of the string class.
        // If you create a string object with the same value as a string literal, the two strings will not be the same object in memory.
        // If string literal and string object have the same value, they are equal but not the same object in memory. They reference to different memory locations.
        public static void RunStringLiteralVsObject()
        {
            string s1 = "metigator"; // string literal
            string s2 = new string("metigator"); // string object


            Console.WriteLine(s1 == s2);                   // true same content (string override equality value based)
            Console.WriteLine(s1.Equals(s2));              // true same content

            Console.WriteLine((Object)s1 == (Object)s2);   // false two different reference
            Console.WriteLine(ReferenceEquals(s1, s2));    // false two different reference

        }

        public static void RunStringLiteralKey()
        {
            string s1 = "metigator"; // string literal
            string s2 = "aspnet"; // string literal 
            string s3 = "meti" + "gator"; // string literal



            Console.WriteLine(s1 == s2);                   // false  different content
            Console.WriteLine(ReferenceEquals(s1, s2));    // false two different reference


            Console.WriteLine(s1 == s3);   // true same content
            Console.WriteLine(ReferenceEquals(s1, s3));   // true same reference
        }

        // If you declare a string object that has the same value as a strign literal exist in the ontern pool, the string object will not be added to the intern pool. It will be a separate object in memory.
        public static void RunStringLiteralWithStringObjectComparison()
        {
            string s1 = "metigator"; // string literal
                                     //string s11 = "metigator";
            string s2 = new string("metigator");                  // string object

            Console.WriteLine(s1 == s2);                   // true, same content

            Console.WriteLine(ReferenceEquals(s1, s2));   // false different reference

        }

        public static void RunStringIntern()
        {
            string s1 = "metigator";                       // string literal

            string s2 = new string("metigator");   // string object

            string s3 = String.Intern(s2);                  // string literal

            Console.WriteLine(s1 == s2);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s1, s2));   // false different reference

            Console.WriteLine(s2 == s3);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s2, s3));   // false different reference

            Console.WriteLine(s1 == s3);                   // true, same content 
            Console.WriteLine(ReferenceEquals(s1, s3));   // true, same reference


            string str = "xyz";

            Console.WriteLine(str);

        }
    }
}
