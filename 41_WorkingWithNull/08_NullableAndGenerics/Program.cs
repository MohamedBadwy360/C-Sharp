namespace _08_NullableAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We can use nullable reference types with generics as well

            // --------------------------------------------------------------------------------------

            Console.WriteLine("Hello World!");
        }

        static T? DoSomething<T>(T source)
        {
            return source;
        }
    }
}
