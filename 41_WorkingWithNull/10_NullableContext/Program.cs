#nullable enable        // enable nullable context for the entire project (nullable directive)

namespace _10_NullableContext
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In legacy code, if upgrade to modern framwork and you enable nullable context, you will get a lot of warnings so you can't just enable it and forget about it. Make Nullable disable by default and enable it for new projects.
            // There is another method to upgrade and migrate to modern framework, you can use the NullableContextUpgrader tool.

            // <Nullable>warnings</Nullable> in .csproj file emits warnings for nullable reference types, warnings appear when dereferencing nullable reference types.

            // With new project use <Nullable>enable</Nullable> in .csproj file to enable nullable reference types.

            // <Nullable>annotations</Nullable> in .csproj file express your design intent before enabling warnings.


            // When can enable nullable context in a file only by using #nullable enable directive at the top of the file and #nullable restore to return to the default setting.

            // I can enable only nullable annotations in a file by using #nullable enable annotations directive at the top of the file anf #nullable restore annotations to return to the default setting.

            // If I want to enable only nullable warnings in a file, I can use #nullable enable warnings directive at the top of the file and #nullable restore warnings to return to the default setting.

            // -------------------------------------------------------------------------------------

            string? fname = null;                                               // read from user
            string lname = null;                                                // read from user
            var person = new Person(fname.ToUpper(), lname.ToLower());
            Console.ReadKey();
        }
    }
}


#nullable restore           // restore nullable context to the default setting (nullable directive)
