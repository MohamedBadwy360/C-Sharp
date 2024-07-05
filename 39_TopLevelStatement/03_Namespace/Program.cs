using HR;                   // Using directive to avoid writing the full name of the type.
using static System.Math;                               // Static using directive to avoid writing the full name of the type.   
using CRAC = Continent.Region.Area.Country;             // Alias to avoid writing the full name of the type. Alias on namespace.
using EGY = Continent.Region.Area.Country.Egypt;        // Alias to avoid writing the full name of the type. Alias on type.

namespace _03_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Namespace role is to organize the code and the files and prevent naming conflicts.
            // Look at namespace as a folder and classes as files to simplify the concept but it is not the same.

            // We can have the same name of classes or types in different namespaces.

            // To call a type in namespace we can use the full name of the type or use the using directive to avoid writing the full name of the type.

            // We can use alias to avoid writing the full name of the type.

            // We can use static using directive to avoid writing the full name of the type.

            // global:: is used to access the global namespace.
            // global modifier make the type available in all namespaces in the project.
            // global namespaces are used to avoid naming conflicts.
            // global using should be in the most top of the file.
            // It's prefered to have global usings in seperate file called GlobalUsings.cs.

            // ---------------------------------------------------------------------------------------

            //HR.Employee employee = new HR.Employee();         // HR.Employee is the full name of the type.
            Sales.Employee employee1 = new Sales.Employee();    // Sales.Employee is the full name of the type.
            Employee employee = new Employee();                 // Using directive to avoid writing the full name of the type.

            CRAC.Egypt egy = new CRAC.Egypt();                  // Alias to avoid writing the full name of the type.
            EGY egy1 = new EGY();                               // Alias to avoid writing the full name of the type.

            Console.WriteLine(Cos(45));                         // Static using directive to avoid writing the full name of the type.
        }
    }
}
