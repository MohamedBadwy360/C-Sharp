namespace _08_OOP_Constructor
{
    internal partial class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public DateTime DateOfBirth { get; set; }

            public Employee() { }
            public Employee(string name)
            {
                Name = name;
            }
        }
    }
}
