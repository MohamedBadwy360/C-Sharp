namespace _11_Delegate
{
    public class Report
    {
        // delegate is a type that represents references to methods with a particular parameter list and return type.
        public delegate bool IsIligible(Employee employee);

        public static void ProcessEmployee(Employee[] employees, string title, IsIligible isIligible)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var employee in employees)
            {
                if (isIligible(employee))
                {
                    Console.WriteLine($"[{employee.Id}] {employee.Name} is [{employee.Gender}] => {employee.TotalSalary}");
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
