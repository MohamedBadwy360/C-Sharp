using System.Reflection;

namespace _06_HowToReflectDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Mohamed Badwy\Desktop\MOE.dll";

            // Load the assembly from the path provided above 
            var assembly = Assembly.LoadFrom(path);     // LoadFrom() method is used to load the assembly from the path provided as a parameter

            // Get the types in the assembly
            var types = assembly.GetTypes();            // GetTypes() method is used to get all the types in the assembly
            foreach (var type in types)
            {
                Console.WriteLine(type);
            }
        }
    }
}
