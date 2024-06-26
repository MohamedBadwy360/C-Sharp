namespace _11_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the array of Employee objects
            Employee[] employees = new Employee[]
            {
                new Employee { Id = 1, Name = "Mark", TotalSalary = 50000m, Gender = "M" },
                new Employee { Id = 2, Name = "Mary", TotalSalary = 75000, Gender = "F" },
                new Employee { Id = 3, Name = "Sam", TotalSalary = 70000m, Gender = "M" },
                new Employee { Id = 4, Name = "Sara", TotalSalary = 80000m, Gender = "F" },
                new Employee { Id = 5, Name = "David", TotalSalary = 50000m, Gender = "M" },
                new Employee { Id = 6, Name = "Pam", TotalSalary = 90000m, Gender = "F" },
                new Employee { Id = 7, Name = "John", TotalSalary = 20000m, Gender = "M" },
                new Employee { Id = 8, Name = "Sandy", TotalSalary = 95000m, Gender = "F" },
                new Employee { Id = 9, Name = "Julie", TotalSalary = 31000m, Gender = "F" },
                new Employee { Id = 10, Name = "Ken", TotalSalary = 15000m, Gender = "M" }
            };

            // Process the employees
            //Report.ProcessEmployee(employees, "Employees with salary greater than 60000", IsGreaterThan60000);
            //Report.ProcessEmployee(employees, "Employees with salary between 30000 and 60000", IsBetween30000And60000);
            //Report.ProcessEmployee(employees, "Employees with salary less than 30000", IsLessThan30000);

            Report.ProcessEmployee(employees, "Employees with salary greater than 60000", employee => employee.TotalSalary > 60000m);
            Report.ProcessEmployee(employees, "Employees with salary between 30000 and 60000", employee => employee.TotalSalary >= 30000m && employee.TotalSalary <= 60000);
            Report.ProcessEmployee(employees, "Employees with salary less than 30000", employee => employee.TotalSalary < 30000m);



            // MultiCast Delegate
            // Declare a delegate
            Rect rect;

            // Instantiate the delegate with the methods to be called
            rect = RectangleHelper.GetArea;
            // Add another method to the delegate instance / Subscribe to the delegate instance
            rect += RectangleHelper.GetPerimeter;

            // Invoke the delegate instance
            rect(10, 10);

            Console.WriteLine("After unsubscribing from GetPerimeter");
            // Unsubscribe from the delegate instance / Remove a method from the delegate instance
            rect -= RectangleHelper.GetPerimeter;
            rect(10, 10);
        }

        //static bool IsGreaterThan60000(Employee employee) => employee.TotalSalary > 60000m;
        //static bool IsBetween30000And60000(Employee employee) => employee.TotalSalary >= 30000m
        //    && employee.TotalSalary <= 60000;
        //static bool IsLessThan30000(Employee employee) => employee.TotalSalary < 30000m;

    }
}
