using DemoLib;
using System.Reflection;

namespace _27_Assemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assemblies are the building blocks of .NET applications;
            // they form the fundamental unit of deployment, version control, reuse, activation scoping, and security permissions.
            // An assembly is a collection of types and resources that are built to work together and form a logical unit of functionality.
            // An assembly provides the common language runtime with the information it needs to be aware of type implementations.
            // To the runtime, a type does not exist outside the context of an assembly.

            // Assemlies are of two types:
            // 1. Private Assembly - It is used by a single application.
            // 2. Shared Assembly - It is used by multiple applications.

            // Assemblies are stored in .dll or .exe files.
            // .dll - Dynamic Link Library
            // .exe - Executable File

            // There are steps to generate an assembly from a source code:
            // 1. Create a source code file.
            // 2. Compile the source code file to IL (Intermediate Language) code.
            // 3. Generate a PE (Portable Executable) file from the IL code using the IL assembler. The PE file contains the IL code and metadata that describes the types in the assembly.
            // 4. Generate an assembly from the PE file.
            // The assembly contains the metadata that describes the types in the assembly.
            // The metadata includes the assembly's name, version, culture, and strong name information.
            // The assembly also contains the IL code that the common language runtime executes.
            // The assembly is the unit at which the runtime performs security checks.
            // The runtime uses the assembly's metadata to locate and load types.
            // The runtime locates and loads types when the code that uses the types is executed.

            // JIT (Just-In-Time) compiler compiles the IL code to machine code when the code is executed.
            // The JIT compiler compiles the IL code to machine code that is specific to the hardware and operating system on which the code is running.

            // ILDASM (IL Disassembler) is a tool that takes a PE file that contains IL code and creates a text file that contains the IL code.
            // The ILDASM tool is useful for examining the IL code in an assembly.

            // ILASM (IL Assembler) is a tool that takes a text file that contains IL code and creates a PE file that contains the IL code.
            // The ILASM tool is useful for creating an assembly from IL code.

            // To know the assembly information, we can use the AssemblyInfo class.
            // Or we can use the Assembly class to get the assembly information.
            // Or Assembly.GetExecutingAssembly() method to get the assembly information of the current executing assembly.
            // Or Assembly property in typeof() operator to get the assembly information of the type.

            // typeof() operator returns the Type object of the specified type.
            // The Type object contains the metadata that describes the type.
            // The Type object is used to get the information about the type, such as the type's name, namespace, base type, and members.
            // The Type object is used to create an instance of the type, invoke the type's methods, and get or set the type's fields and properties.
            var type = typeof(Employee);

            // Get the assembly information of the type.
            // The Assembly property in the Type object returns the assembly that contains the type.
            // The Assembly object contains the metadata that describes the assembly.
            // The Assembly object is used to get the information about the assembly, such as the assembly's name, version, culture, and strong name information.
            var assembly = type.Assembly;

            // Display the assembly information.
            Console.WriteLine(assembly.FullName);


            // Get the assembly information of the current executing assembly.
            // The GetExecutingAssembly() method in the Assembly class returns the assembly that contains the code that is currently executing.
            var assembly2 = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly2.FullName);


            // The GetEntryAssembly() method in the Assembly class returns the assembly that contains the entry point of the application.
            // The entry point is the method that is called when the application starts.

            // The GetCallingAssembly() method in the Assembly class returns the assembly that contains the code that called the current method.
            // The calling assembly is the assembly that contains the code that called the current method.

            // The GetAssembly() method in the Assembly class returns the assembly that has the specified name.
            // The name of the assembly is the full name of the assembly, which includes the assembly's name, version, culture, and public key token.
            // The full name of the assembly is the value of the FullName property in the Assembly object.

            Demo.Trace();

            // -----------------------------------------------------

            Console.WriteLine("----------------------------------");

            var programType = typeof(Program);
            var programAssembly = programType.Assembly;
            Console.WriteLine($"Assembly Full Name: {programAssembly.FullName}");
            Console.WriteLine($"Location: {programAssembly.Location}");

            // AssemblyName class is used to get the information about the assembly.
            // The AssemblyName object contains the metadata that describes the assembly.
            // The AssemblyName object is used to get the information about the assembly, such as the assembly's name, version, culture, and public key token.
            AssemblyName programAssemblyName = programAssembly.GetName();
            Console.WriteLine($"Name: {programAssemblyName.Name}");
            Console.WriteLine($"Version: {programAssemblyName.Version}");
            Console.WriteLine($"Total Key Token Length: {programAssemblyName.GetPublicKeyToken().Length}");
            Console.WriteLine($"Culture: {programAssemblyName.CultureName}");
            Console.WriteLine($"Code Base: {programAssemblyName.CodeBase}");
            Console.WriteLine($"DateTime Assembly Name: {typeof(DateTime).Assembly.GetName().Name}");


            // -----------------------------------------------------

            // Accessing resources in an assembly 

            // Resources are the files that are embedded in an assembly.
            // GetManifestResourceNames() method in the Assembly class returns the names of the resources in the assembly.
            // GetManifestResourceStream() method in the Assembly class returns a Stream object that represents the resource in the assembly.
            // Manifest resources are the resources that are embedded in the assembly.
            // The resources are embedded in the assembly when the assembly is built.
            // The resources are stored in the assembly's manifest, which is a metadata table that describes the resources in the assembly.
            // The resources are stored in the assembly's manifest as binary data.
            // The resources are stored in the assembly's manifest as a byte array.


            //var stream = programAssembly.GetManifestResourceStream("27_Assemblies.Data.countries.txt");
            var stream = programAssembly.GetManifestResourceStream(programType, "Data.countries.json");

            //using (var reader = new StreamReader(stream))
            //{
            //    Console.WriteLine(reader.ReadToEnd());
            //}

            var data = new BinaryReader(stream).ReadBytes((int)stream.Length);
            foreach (var character in data)
            {
                Console.Write((char)character);
            }


            stream.Close();

            Console.ReadKey();
        }

        class Employee
        {

        }

    }
}
