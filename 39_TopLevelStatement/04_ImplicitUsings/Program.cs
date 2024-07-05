
// Implicit usings is a new feature in C# 10.
// It's used to avoid writing the using directive for the most common namespaces.

// Where the implicit usings are used:
// 1. System
// 2. System.Collections.Generic
// 3. System.Linq
// 4. System.Text
// 5. System.Threading.Tasks
// 6. System.IO

// To enable implicit usings:
// 1. Right click on the project.
// 2. Edit project file.
// 3. Add <ImplicitUsings>enable</ImplicitUsings> in the first <PropertyGroup> tag.

// How to disable implicit usings:
// 1. Right click on the project.
// 2. Edit project file.
// 3. Add <ImplicitUsings>disable</ImplicitUsings> in the first <PropertyGroup> tag.

// How to disable one of the implicit usings:
// 1. Right click on the project.
// 2. Edit project file.
// 3. Add <ImplicitUsings>enable</ImplicitUsings> in the first <PropertyGroup> tag.
// 4. Add <ImplicitUsingRemove>System</ImplicitUsingRemove> in the first <PropertyGroup> tag.

// How to include a new implicit using:
// 1. Right click on the project.
// 2. Edit project file.
// 3. Add <ImplicitUsings>enable</ImplicitUsings> in the first <PropertyGroup> tag.
// 4. Add <ImplicitUsing Include="System.Net.Http" /> in the first <ItemGroup> tag.


// Where I can found the implicit usings:
// 1. In the project file.
// 2. In the obj folder in the project file.
// 3. In Debug folder.
// 5. In .net8 folder.
// 6. In the project_name.GlobalUsings.g.cs file.


Console.WriteLine(DateTime.Now);

Console.ReadKey();