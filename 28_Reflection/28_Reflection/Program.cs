namespace _28_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reflection is a powerful feature in C# that allows us to inspect types, methods, properties, fields, and constructors at runtime.
            // It is used to find all the information about the type at runtime.
            // It is used to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties.
            // It is used to get the metadata of the type at runtime.
            // It is used to inspect the assemblies and modules at runtime.
            // It is used to create dynamic types, and more.

            // -------------------------------------------------------------------------------

            // Type class 
            // The Type class is the main class in the System.Reflection namespace. It is used to get the metadata of a type at runtime.
            // The Type class is used to get the type information of a class. It is used to get the metadata of a type at runtime.


            Type t1 = DateTime.Now.GetType();       // Get the type of the object at runtime using GetType() method
            Type t3 = Type.GetType("System.DateTime"); // Get the type of the class at runtime using Type.GetType() method
            Console.WriteLine(t1);
            Console.WriteLine(t3);

            Type t2 = typeof(DateTime);              // Get the type of the class at compile-time using typeof() operator
            Console.WriteLine(t2);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"FullName: {t1.FullName}");      // Get the full name of the type using FullName property of the Type class 
            Console.WriteLine($"Name: {t1.Name}");              // Get the name of the type using Name property of the Type class
            Console.WriteLine($"Namespace: {t1.Namespace}");    // Get the namespace of the type using Namespace property of the Type class
            Console.WriteLine($"BaseType: {t1.BaseType}");      // Get the base type of the type using BaseType property of the Type class
            Console.WriteLine($"IsPublic: {t1.IsPublic}");      // Get if the type is public or not using IsPublic property of the Type class
            Console.WriteLine($"IsClass: {t1.IsClass}");        // Get if the type is class or not using IsClass property of the Type class
            Console.WriteLine($"IsAbstract: {t1.IsAbstract}");  // Get if the type is abstract or not using IsAbstract property of the Type class
            Console.WriteLine($"IsSealed: {t1.IsSealed}");      // Get if the type is sealed or not using IsSealed property of the Type class
            Console.WriteLine($"IsValueType: {t1.IsValueType}");// Get if the type is value type or not using IsValueType property of the Type class
            //Console.WriteLine($"IsArray: {t1.IsArray}");        // Get if the type is array or not using IsArray property of the Type class
            //Console.WriteLine($"IsEnum: {t1.IsEnum}");          // Get if the type is enum or not using IsEnum property of the Type class
            //Console.WriteLine($"IsInterface: {t1.IsInterface}");// Get if the type is interface or not using IsInterface property of the Type class
            //Console.WriteLine($"IsGenericType: {t1.IsGenericType}"); // Get if the type is generic type or not using IsGenericType property of the Type class
            //Console.WriteLine($"IsGenericTypeDefinition: {t1.IsGenericTypeDefinition}"); // Get if the type is generic type definition or not using IsGenericTypeDefinition property of the Type class
            //Console.WriteLine($"IsConstructedGenericType: {t1.IsConstructedGenericType}"); // Get if the type is constructed generic type or not using IsConstructedGenericType property of the Type class
            //Console.WriteLine($"IsNested: {t1.IsNested}");      // Get if the type is nested or not using IsNested property of the Type class
            //Console.WriteLine($"IsNestedPublic: {t1.IsNestedPublic}"); // Get if the type is nested public or not using IsNestedPublic property of the Type class
            //Console.WriteLine($"IsNestedPrivate: {t1.IsNestedPrivate}"); // Get if the type is nested private or not using IsNestedPrivate property of the Type class
            //Console.WriteLine($"IsNestedFamily: {t1.IsNestedFamily}"); // Get if the type is nested family or not using IsNestedFamily property of the Type class
            //Console.WriteLine($"IsNestedAssembly: {t1.IsNestedAssembly}"); // Get if the type is nested assembly or not using IsNestedAssembly property of the Type class
            Console.WriteLine($"Assembly: {t1.Assembly}");     // Get the assembly of the type using Assembly property of the Type class

            Type t4 = typeof(int[,]);
            Console.WriteLine($"t4 Type: {t4.Name}");

            Console.WriteLine("------------------------------------------");

            Type[] nestedTypes = typeof(Employee).GetNestedTypes();    // Get the nested types of the class using GetNestedTypes() method of the Type class 
            for (int i = 0; i < nestedTypes.Length; i++)
            {
                Console.WriteLine($"Employee Nested Type: {nestedTypes[i]}");
            }

            Console.WriteLine("------------------------------------------");

            Type[] interfaces = typeof(int).GetInterfaces();
            for (int i = 0; i < interfaces.Length; i++)
            {
                Console.WriteLine($"Interface implemented in int: {interfaces[i].Name}");
            }

            Console.WriteLine("------------------------------------------");


        }
    }

    public class Employee
    {
        public class FullTimeEmployee
        {

        }

        public class PartTimeEmployee
        {

        }
    }



}
