namespace _25_XML_Documentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // XML Documentation is a way to document your code in a way that can be used by Visual Studio to provide intellisense and tooltips.
            // It is a way to provide information about your code to other developers.
            // It is a way to provide information about your code to yourself.
            // It is a way to provide information about your code to the future you.
            // It's important to document your code so that others can understand it.
            // It's implemented using XML comments. 
            // XML comments are special comments that are enclosed in triple slashes (///).
            // XML comments are used to document classes, methods, properties, fields, and other code elements.

            // <summary> tag is used to provide a summary of the code element.
            // <param> tag is used to provide information about the parameters of a method.
            // <returns> tag is used to provide information about the return value of a method.
            // <exception> tag is used to provide information about the exceptions that a method can throw.
            // <remarks> tag is used to provide additional information about the code element.
            // <example> tag is used to provide an example of how to use the code element.
            // <see> tag is used to provide a reference to another code element.
            // <seealso> tag is used to provide a reference to another code element.
            // <c> tag is used to provide code snippets.
            // <code> tag is used to provide code snippets. => don't show in intellisense or tooltips. but when generated documentation.
            // <list> tag is used to provide a list of items.
            // <item> tag is used to provide an item in a list.
            // <para> tag is used to provide a paragraph of text.
            // <value> tag is used to provide information about the value of a property.
            // <typeparam> tag is used to provide information about the type parameter of a generic class or method.
            // <typeparamref> tag is used to provide a reference to a type parameter of a generic class or method.
            // <permission> tag is used to provide information about the permissions required to use a code element.    
            // <paramref> tag is used to provide a reference to a parameter of a method.
            // <list> tag is used to provide a list of items.
            // <item> tag is used to provide an item in a list.
            // <term> tag is used to provide a term in a list.
            // <description> tag is used to provide a description of an item in a list.
            // cref attribute is used to provide a reference to a code element.
            // langword attribute is used to provide a reference to a language keyword.
            // name attribute is used to provide a name for a code element.
            // typeparamref attribute is used to provide a reference to a type parameter of a generic class or method.
            // file attribute is used to provide a reference to a file.
            // path attribute is used to provide a reference to a path.
            // line attribute is used to provide a reference to a line number.
            // type attribute is used to provide a reference to a type.
            // href attribute is used to provide a reference to a URL.




            // To view the XML documentation, you can hover over the code element in Visual Studio.
            // You can also view the XML documentation in the Object Browser.
            // You can also view the XML documentation in the IntelliSense.


            // Best Practices   
            // Every public class, method, property, field, and other code elements should be documented.
            // Private classes, methods, properties, fields, and other code elements should be documented if they are complex or difficult to understand.


            Console.WriteLine("First Name: ");
            var fName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            var lName = Console.ReadLine();

            Console.WriteLine("Hire Date: ");
            DateTime? hireDate = null;
            if (DateTime.TryParse(Console.ReadLine(), out DateTime hDate))
            {
                hireDate = hDate;
            }

            var id = Generator.GenerateId(fName, lName, hireDate);
            var password = Generator.GenerateRandomPassword(8);

            Console.WriteLine($"Generated ID: {id}");
            Console.WriteLine($"Generated Password: {password}");
        }
    }


    /// <summary>
    /// The main Generator class.
    /// </summary>
    /// <remarks>
    /// A class that generates unique IDs and random passwords.
    /// </remarks>
    public class Generator
    {
        /// <include file="Documentation.xml" path='docs/members[@name="generator"]/LastIdSequence/*' />
        public static int LastIdSequence { get; private set; } = 1;

        /// <summary>
        /// Generates a unique ID based on the <paramref name="fName"/>, <paramref name="lName"/>, and <paramref name="hireDate"/>.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="hireDate"></param>
        /// <code>
        /// var id = Generator.GenerateId("John", "Doe", DateTime.Now);
        /// Console.WriteLine(id);
        /// </code>
        /// <returns>
        /// A unique ID in the format of II-YY-MM-DD-SS string.
        /// <list type="bullet">
        /// <item>
        /// <term>II</term>
        /// <description>Empolyees initials (first letter of <paramref name="fName"/>, and first letter of <paramref name="lName"/>)</description>
        /// </item>
        /// <item>
        /// <term>YY</term>
        /// <description>Date 2 digit year</description>
        /// </item>
        /// <item>
        /// <term>MM</term>
        /// <description>Date 2 digit month</description>
        /// </item>
        /// <item>
        /// <term>DD</term>
        /// <description>Date 2 digit day</description>
        /// </item>
        /// <item>
        /// <term>SS</term>
        /// <description>Sequence No. (01 - 99)</description>
        /// </item>
        /// </list>
        /// </returns>
        /// <exception cref="ArgumentNullException">Throw when <paramref name="fName"/> is null</exception>
        /// <exception cref="ArgumentNullException">Throw when <paramref name="lName"/> is null</exception>
        /// <exception cref="InvalidOperationException">Throw when <paramref name="hireDate"/> is in the past</exception>
        /// See <see cref="Generator.GenerateRandomPassword(int)"/> to generate a random password.
        public static string GenerateId(string fName, string lName, DateTime? hireDate)
        {
            // II YY MM DD 01
            if (fName is null)
            {
                throw new ArgumentNullException($"{nameof(fName)} can't be null");
            }

            if (lName is null)
            {
                throw new ArgumentNullException($"{nameof(lName)} can't be null");
            }

            if (hireDate is null)
            {
                hireDate = DateTime.Now;

                if (hireDate.Value.Date < DateTime.Now.Date)
                {
                    throw new InvalidOperationException("Hire date can't be in the past");
                }
            }

            var yy = hireDate.Value.Date.ToString("yy");
            var MM = hireDate.Value.Date.ToString("MM");
            var dd = hireDate.Value.Date.ToString("dd");

            return $"{fName.ToUpper()[0]}{lName.ToUpper()[0]}-{yy}-{MM}-{dd}-{LastIdSequence++}";
        }

        // This a way for external documentation file.
        /// <include file='Documentation.xml' path='docs/members[@name="generator"]/GenerateRandomPassword/*'/>
        public static string GenerateRandomPassword(int length)
        {
            string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            string password = string.Empty;

            var random = new Random();

            while (0 < length--)
            {
                password += ValidChars[random.Next(0, ValidChars.Length)];
            }

            return password;
        }
    }
}
