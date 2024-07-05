namespace _01_Main
{
    internal class Program
    {
        static void Main()
        {
            // The shape of main method is not fixed. Depend on the requirement we can use any of the below method signature.

            // It must be only one main method in the application. You can't have multiple main methods in the application or overloaded main methods.



            // -----------------------------------------------------------------------------------------

            Console.WriteLine("Metigator");
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Metigator");
        //}


        //static int Main()
        //{
        //    Console.WriteLine("Metigator");
        //    return 0;
        //}

        //static int Main(string[] args)
        //{
        //    Console.WriteLine("Metigator");
        //    return 0;
        //}

        //static async Task Main(string[] args)
        //{
        //    await Task.Run(() => Console.WriteLine("Metigator"));
        //}

        //static async Task<int> Main(string[] args)
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Metigator");
        //    });
        //    return 0;
        //}
    }
}
