namespace _15_OOP_NestedTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.EmployeeInsurance?.CompanyName);

            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Composition - Nested Type => is a type that is defined within another type
        // Composition is a strong relationship between two classes where one contains the other and the contained class cannot exist without the container class.
        // Composition is a "has a" relationship.
        public Insurance EmployeeInsurance { get; set; }

        public Employee()
        {
            EmployeeInsurance = new Insurance() { PolicyId = -1, CompanyName = "N/A" };
        }

        // Composition - Nested Type => is a type that is defined within another type
        public class Insurance
        {
            public int PolicyId { get; set; }
            public string CompanyName { get; set; }
        }
    }

    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
