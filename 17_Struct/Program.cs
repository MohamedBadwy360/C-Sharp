namespace _17_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            // new() wasn't mandatory with struct if you don't have parameterized constructor or fields in struct
            //Student student2;
            // If you have fields in struct, you should use new() to initialize fields in struct or initialize fields after declaration 
            Student student2 = new Student();

            Console.WriteLine(student1);
            student2.Show();


            Console.WriteLine("----------------------------------------------");
            DigitalSize digitalSize = new DigitalSize(60000);
            Console.WriteLine(digitalSize.Bit);
            Console.WriteLine(digitalSize.Byte);
            Console.WriteLine(digitalSize.KiloByte);
            Console.WriteLine(digitalSize.MegaByte);
            Console.WriteLine(digitalSize.GigaByte);
            Console.WriteLine(digitalSize.TeraByte);

            // New object that doesn't change the original object because struct is value type and it's immutable 
            // digitalSize references the new object
            // Beacause struct is value type, it's copied to new object when you change it 
            // Any changes to the new object don't affect the original object
            // Any changes to the original object don't affect the new object
            DigitalSize digitalSize2 = digitalSize.AddBit(1000);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(digitalSize2.Bit);

            // ----------------------------------------

            // DateTime is a readonly struct so it's immutable
            DateTime dt = new DateTime(2024, 6, 27);

            dt.AddDays(10);             // not changed because it's immutable
            Console.WriteLine(dt);      // 6/27/2024

            dt = dt.AddDays(10);        // this returns new struct/variable in memory with added days and old struct is ended
            Console.WriteLine(dt);      // 7/7/2024

            // -----------------------------------------

            // datatypes like int, long, decimal, short.... are readonly structs
            int x = 4;
            x = x + 1;

            // string is reference type but is immutable 
        }
    }
}
