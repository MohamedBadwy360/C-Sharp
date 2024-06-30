namespace _28_HowToInstantiateObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate variable
            //var i = new Int32();        // 0
            //var i = new int();          // 0
            //Console.WriteLine(i);
            //i = 3;

            // Instantiate object 
            // Activator class is used to create an instance of a type that is not known at compile time.
            //var obj = Activator.CreateInstance(typeof(Int32));
            //Console.WriteLine(obj);

            // Instantiate object using Activator
            int i = (int)Activator.CreateInstance(typeof(int));         // Create an instance of int type
            int i2 = Activator.CreateInstance<int>();                   // Create an instance of int type
            Console.WriteLine(i);                                       // 0
            Console.WriteLine(i2);                                      // 0

            DateTime dt = (DateTime)Activator.CreateInstance(typeof(DateTime), 2023, 06, 30);   // Create an instance of DateTime type
            //DateTime dt2 = Activator.CreateInstance<DateTime>(); 
            Console.WriteLine(dt);                                       // 6/30/2023 12:00:00 AM
        }
    }
}
