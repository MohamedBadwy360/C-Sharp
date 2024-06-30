using System.Reflection;

namespace _29_Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Attributes are used to add metadata to code elements such as classes, methods, properties, and fields.
            // Attributes are used to provide additional information about the code to the compiler.
            // Attributes are used to control the behavior of the compiler.
            // Attributes are used to specify the behavior of the runtime.

            // Attributes are classes that inherit from the System.Attribute class directly or indirectly.
            // Attributes are defined by placing square brackets [] before the code element.
            // Attributes can be applied to classes, methods, properties, fields, and other code elements.
            // Attributes can be applied to assemblies, modules, and other metadata elements.

            // We can pass arguments to attributes.
            // We can pass named arguments to attributes.

            // Attributes are added in compile time but they are processed in runtime.
            // We can get the attributes of a code element using reflection.

            // if we don't have an predefined attribute class that serve our purpose, we can create custom attribute class.

            // We can specify where the attribute can be applied using AttributeUsage attribute.
            // We can specify if the attribute can be applied multiple times using AllowMultiple property of AttributeUsage attribute.
            // We can specify if the attribute is inherited by derived classes using Inherited property of AttributeUsage attribute.


            Update[] updates = new Update[]
            {
                new Update(1, "UI Update"),
                new Update(2, "Security Update"),
                new Update(3, "Bug Fix"),
                new Update(4, "Performance Update")
            };

            //UpdateProcessor.Download(updates);                          // Obsolete with warning
            //UpdateProcessor.Install(updates);                           // Obsolete with error
            UpdateProcessor.DownloadAndInstall(updates);


            // -------------------------------------------------------------------------

            // Get the attributes of a code element using reflection. 
            // GetCustomAttributes() method is used to get the attributes of a code element.
            // GetCustomAttribute<>() method is used to get a specific attribute of a code element.


            Console.WriteLine("-----------------------------------------");

            var players = new List<Player>
            {
                new Player { Name = "Ronaldo", BallControl = 90, Dribbling = 85, Power = 95, Speed = 92, Passing = 80 },
                new Player { Name = "Messi", BallControl = 95, Dribbling = 95, Power = 80, Speed = 90, Passing = 90 },
                new Player { Name = "Neymar", BallControl = 92, Dribbling = 93, Power = 85, Speed = 91, Passing = 88 }
            };

            List<Error> errors = new List<Error>();

            foreach (var player in players)
            {
                var properties = player.GetType().GetProperties();
                foreach (var property in properties)
                {
                    // Get the SkillAttribute of the property using reflection. 
                    var skillAttribute = property.GetCustomAttribute<SkillAttribute>();

                    // If the property has a SkillAttribute, validate the value of the property.
                    if (skillAttribute is not null)
                    {
                        // Get the value of the property using reflection.
                        var value = property.GetValue(player);

                        // If the value is not valid, add an error to the errors list.
                        if (!skillAttribute.IsValid(value))
                        {
                            errors.Add(new Error(property.Name,
                                $"Invalid value. Accepted range is {skillAttribute.Minimum} - {skillAttribute.Maximum}"));
                        }
                    }
                }

                if (errors.Count > 0)
                {
                    foreach (var error in errors)
                    {
                        Console.WriteLine(error);
                    }
                }
                else
                {
                    Console.WriteLine($"{player.Name} is valid.");
                }
            }
        }
    }
}
