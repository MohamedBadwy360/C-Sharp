using System.Reflection;

namespace DemoLib
{
    public class Demo
    {
        public static void Trace()
        {
            Console.WriteLine("Tracing....");
            Console.WriteLine($"Excecuting Assmbly: {Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"Entry Assmbly: {Assembly.GetEntryAssembly()}");
            Console.WriteLine($"Calling Assemly: {Assembly.GetCallingAssembly()}");
        }
    }
}
