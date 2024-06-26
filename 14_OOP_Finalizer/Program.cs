namespace _14_OOP_Finalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Mohamed";


            // Grabage collector is used to manage the memory and to deallocate the memory for the objects that are no longer needed.
            // Garbage collector is a part of CLR (Common Language Runtime). 
            // Garbage collector runs in the background and it is responsible for deallocating the memory for the objects that are no longer needed.
            // Garbage collector uses a technique called "Mark and Sweep" to deallocate the memory for the objects that are no longer needed.
            // Garbage collector is non-deterministic. It runs in the background and it is not possible to predict when the garbage collector will run.
            // Garbage collector is not available in C++ and C. In C++ and C, the programmer is responsible for deallocating the memory for the objects that are no longer needed.
            // Garbage collector is available in C# and Java. In C# and Java, the garbage collector is responsible for deallocating the memory for the objects that are no longer needed.

            MakeSomeGarbage();

            Console.WriteLine($"Memory used before collection: {GC.GetTotalMemory(false):N0}");
            GC.Collect();   // Explicitly calling the garbage collector to deallocate the memory for the objects that are no longer needed.
            Console.WriteLine($"Memory used after collection: {GC.GetTotalMemory(true):N0}");

            Console.ReadKey();
        }

        static void MakeSomeGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                var person = new Person();
            }
        }
    }
}
