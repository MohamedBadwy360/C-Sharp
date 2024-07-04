using Humanizer;

namespace _01_Facebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Package is the smallest unit of code in C#.
            // Package is a collection of classes, interfaces, enumerations, and structs.
            // Package can be a folder or a namespace.

            // Nuget is a package manager for .NET.
            // Nuget is a repository of packages.
            // Nuget is a command-line tool.
            // Nuget is a Visual Studio extension.
            // Nuget is a website that hosts packages. (nuget.org)

            // Package Manager Console is a command-line interface for Nuget.

            // -----------------------------------------------------------------------------------------------

            // Humanizer is a package that helps you manipulate strings, numbers, dates, times, etc.

            // How to install a package Humanizer.Core using Nuget Package Manager Console?
            // 1. Open the Nuget Package Manager Console.
            // 2. Type Install-Package Humanizer.Core and press Enter.

            // How to install a package Humanizer.Core using Nuget Package Manager? 
            // 1. Right-click on the project.
            // 2. Click on Manage Nuget Packages.
            // 3. Search for Humanizer.Core.
            // 4. Click on Install.

            // How to use Humanizer?
            // 1. Add using Humanizer; at the top of the file.
            // 2. Use the Humanizer methods.

            // -----------------------------------------------------------------------------------------------

            // Benefits of using packages:
            // 1. Saves time.
            // 2. Reduces errors.
            // 3. Increases productivity.
            // 4. Reduces code duplication.
            // 5. Increases code quality.
            // 6. Reduces maintenance cost.
            // 7. Increases code readability.
            // 8. Reduces learning curve.
            // 9. Increases code reusability.
            // 10. Reduces development cost.

            // -----------------------------------------------------------------------------------------------

            // How to update a package?
            // 1. Open the Nuget Package Manager Console.
            // 2. Type Update-Package Humanizer.Core and press Enter.

            // How to uninstall a package?
            // 1. Open the Nuget Package Manager Console.
            // 2. Type Uninstall-Package Humanizer.Core and press Enter.

            // -----------------------------------------------------------------------------------------------

            // How to create my own package and publish it to Nuget?
            // 1. Create a class library project.
            // 2. Add the classes, interfaces, enumerations, and structs.
            // 3. Add the necessary dependencies.
            // 4. Build the project.
            // 5. Create a Nuget account.
            // 6. Create a Nuget API key.
            // 7. Create a Nuget package.
            // 8. Publish the Nuget package.

            // Before publishing the package, you should test it locally.
            // 1. Build the project.
            // 2. Open the project folder.
            // 3. Open the bin folder.
            // 4. Open the Debug folder.
            // 5. Open the .nupkg file.
            // 6. Check the contents of the package.
            // 7. Install the package to another project.
            // 8. Test the package.


            // After coding the package you should update metadata in the .csproj file. 
            // <PackageId>MyPackage</PackageId>
            // <Version>1.0.0</Version>
            // <Authors>Ali</Authors>
            // <Owners>Ali</Owners>
            // <Description>My first package.</Description>
            // <PackageProjectUrl>
            // <RepositoryUrl>
            // <LicenseUrl>
            // <Tags>MyPackage, Ali</Tags>
            // <PackageIcon>
            // <PackageReleaseNotes>
            // Or click on the project -> Properties -> Package tab -> Fill the fields.



            // After updating the metadata, you should pack the project.
            // 1. Open the Nuget Package Manager Console.
            // 2. Type dotnet pack -c Release and press Enter.
            // 3. Open the bin folder.
            // 4. Open the Release folder.
            // 5. Open the .nupkg file.
            // 6. Check the contents of the package.
            // 7. Install the package to another project.
            // 8. Test the package.
            // Or
            // 1. Right-click on the project After Changing the project to Release mode.
            // 2. Click on Pack.
            // 3. Open the bin folder.
            // 4. Open the Release folder.
            // 5. Open the .nupkg file.
            // 6. Check the contents of the package.
            // 7. Install the package to another project.
            // 8. Test the package.



            // After testing the package, you should publish the package.
            // 1. Open the Nuget Package Manager Console.
            // 2. Type dotnet nuget push MyPackage.1.0.0.nupkg -k your_api_key -s https://api.nuget.org/v3/index.json and press Enter.
            // 3. Check the package on nuget.org.
            // 4. Install the package to another project.
            // 5. Test the package.

            // After publishing the package, you should test it remotely.
            // 1. Install the package to another project.
            // 2. Test the package.

            // -----------------------------------------------------------------------------------------------

            // Difference between Debug and Release mode:
            // Debug mode is used for development.
            // Release mode is used for deployment.
            // Debug mode is slower.
            // Release mode is faster.
            // Debug mode has more information.
            // Release mode has less information.
            // Debug mode has more checks.
            // Release mode has less checks.
            // Debug mode has more logs.
            // Release mode has less logs.

            // If I need to make a code run in Debug mode and not in Release mode, I can use the #if DEBUG directive #endif. It is called conditional compilation / preprocessor directive.

            // -----------------------------------------------------------------------------------------------

            // How to publish a package to Nuget Org?
            // 1. Create a Nuget account.
            // 2. Create a Nuget API key.
            // 3. Create a Nuget package.
            // 4. Publish the Nuget package.

            // Or 
            // 1. Create a Nuget account.
            // 2. Click on Upload.
            // 3. Drag and drop the .nupkg file.
            // 4. Fill the fields.
            // 5. Click on Submit.

            // After submitting the package, you should test it remotely.
            // 1. Install the package to another project.
            // 2. Test the package.

            // After submitting the packcage, you can't delete it. You can only unpublish it.

            // -----------------------------------------------------------------------------------------------

            List<FBComment> comments = new List<FBComment>
            {
                new FBComment { Owner = "Ali", Comment = "Hello, I am Ali.", CreatedAt = DateTime.Now },
                new FBComment { Owner = "Veli", Comment = "Hi, I am Veli.", CreatedAt = DateTime.Now.AddMinutes(5) },
                new FBComment { Owner = "Deli", Comment = "Hey, I am Deli.", CreatedAt = DateTime.Now.AddMinutes(10) },
                new FBComment { Owner = "Meli", Comment = "Yo, I am Meli.", CreatedAt = DateTime.Now.AddMinutes(15) },
                new FBComment { Owner = "Zeli", Comment = "Aloha, I am Zeli.", CreatedAt = DateTime.Now.AddMinutes(20) },
                new FBComment { Owner = "Keli", Comment = "Merhaba, I am Keli.", CreatedAt = DateTime.Now.AddMinutes(25) },
                new FBComment { Owner = "Leli", Comment = "Selam, I am Leli.", CreatedAt = DateTime.Now.AddMinutes(30) }
            };

            foreach (var comment in comments)
            {
                Console.WriteLine(comment);
            }

            Console.ReadKey();
        }
    }

    class FBComment
    {
        public string Owner { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            //return $"{Owner} says: \n\"{Comment}\"\n\t\t\t\t{CreatedAt.ToString("yyyy-MM-dd hh:mm")}";
            return $"{Owner} says: \n\"{Comment}\"\n\t\t\t\t{CreatedAt.Humanize()}";    // from Humanizer package 
        }
    }
}
