namespace _08_OOP_Constructor
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(1, 1, 2021);

            // Object Initialization using accessing properties
            Employee employee = new Employee();
            employee.Name = "John Doe";
            employee.Address = "123 Main St";
            employee.DateOfBirth = new DateTime(2000, 1, 1);

            // Object Initialization using Object Initializer
            Employee employee1 = new Employee
            {
                Name = "John Doe",
                Address = "123 Main",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            // Object Initialization using Object Initializer with Constructor
            Employee employee2 = new Employee("Mohamed Ali")
            {
                Address = "123 Main",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            Engineer engineer = Engineer.Create("Mohamed Badwy", "Tahway", new DateTime(2000, 7, 6));

            Console.WriteLine(date.ToString());
            Console.WriteLine(engineer.ToString());
        }
    }
}
