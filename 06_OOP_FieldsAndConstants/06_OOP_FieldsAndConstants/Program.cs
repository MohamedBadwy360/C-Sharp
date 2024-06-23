namespace _06_OOP_FieldsAndConstants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object (Instance) Creation Syntax: 
            // Declaration: <class-name / type> <object-name>;
            // Assignment: <object-name> = new <class-name / type>();

            // Initialization: <class-name / type> <object-name> = new <class-name / type>();

            Employee[] employees = new Employee[2];

            Employee e1 = new Employee();

            Console.WriteLine("First Employee: ");
            Console.Write("First Name: ");
            e1.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e1.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            employees[0] = e1;

            Employee e2 = new Employee();

            Console.WriteLine("\nSecond Employee: ");
            Console.Write("First Name: ");
            e2.FName = Console.ReadLine();

            Console.Write("Last Name: ");
            e2.LName = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            employees[1] = e2;

            foreach (var emp in employees)
            {
                var netSalary = emp.Wage * emp.LoggedHours * (1 - Employee.TAX);

                Console.WriteLine("--------------------");
                Console.WriteLine($"Employee: {emp.FName} {emp.LName}");
                Console.WriteLine($"Wage: {emp.Wage}");
                Console.WriteLine($"Logged Hours: {emp.LoggedHours}");
                Console.WriteLine($"Net Salary: {netSalary}");
                Console.WriteLine("--------------------");
            }
        }
    }
}
