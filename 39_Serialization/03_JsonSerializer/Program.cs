using Newtonsoft.Json;
using System.Text.Json;

namespace _03_JsonSerializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Json Serialization and Deserialization 
            // Json Serialization: Convert C# object to Json string
            // Json Deserialization: Convert Json string to C# object

            // Last time we used XmlSerializer to serialize and deserialize objects
            // Now we will use JsonSerializer to serialize and deserialize objects

            // JsonSerializer is available in System.Text.Json namespace

            // In the past we used Newtonsoft.Json library for serialization and deserialization of objects to and from Json string 
            // Newtonsoft.Json library is still widely used and is more powerful than System.Text.Json

            // System.Text.Json is a new library and is available in .NET Core 3.0 and later versions
            // System.Text.Json is faster than Newtonsoft.Json and is recommended for new projects

            // ------------------------------------------------------------------------------------------

            // Serialize and Deserialize object using Newtonsoft.Json library

            Console.WriteLine("Using Newtonsoft.Json library\n");

            Employee employee = new Employee
            {
                Id = 1,
                Fname = "John",
                Lname = "Doe",
                Benefits = new List<string> { "Health Insurance", "Paid Time Off", "Retirement Plan" }
            };

            var jsonContent = SerializeToJsonStringUsingNewtonSoftJson(employee);
            Console.WriteLine(jsonContent);

            var employeeObj = DeserializeFromJsonStringNewtonSoftJson(jsonContent);
            Console.WriteLine($"Id: {employeeObj.Id}, Fname: {employeeObj.Fname}, Lname: {employeeObj.Lname}");


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Using System.Text.Json\n");

            // Serialize and Deserialize object using System.Text.Json library

            var jsonContent2 = SerializeToJsonStringUsingJsonNet(employee);
            Console.WriteLine(jsonContent2);

            var employeeObj2 = DeserializeFromJsonStringJsonNet(jsonContent2);
            Console.WriteLine($"Id: {employeeObj2.Id}, Fname: {employeeObj2.Fname}, Lname: {employeeObj2.Lname}");

            Console.ReadKey();
        }

        static string SerializeToJsonStringUsingNewtonSoftJson(Employee employee)
        {
            string result = "";
            result = JsonConvert.SerializeObject(employee, Formatting.Indented);         // Serialize object to Json string
            return result;
        }

        static Employee DeserializeFromJsonStringNewtonSoftJson(string jsonString)
        {
            Employee employee = null;
            employee = JsonConvert.DeserializeObject<Employee>(jsonString);  // Deserialize Json string to object
            return employee;
        }

        static string SerializeToJsonStringUsingJsonNet(Employee employee)
        {
            string result = "";
            result = System.Text.Json.JsonSerializer.Serialize(employee, new JsonSerializerOptions { WriteIndented = true });         // Serialize object to Json string
            return result;
        }

        static Employee DeserializeFromJsonStringJsonNet(string jsonString)
        {
            Employee employee = null;
            employee = System.Text.Json.JsonSerializer.Deserialize<Employee>(jsonString);  // Deserialize Json string to object
            return employee;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public List<string> Benefits { get; set; } = new List<string>();
    }
}
