namespace _07_OOP_Methods
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

            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());

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
                emp.PrintSlip();
            }

            // --------------------------------------------

            //Demo demo = new Demo();
            //// caller
            //demo.DoSomething();
            //var z = demo.DoSomething2();    // primary expression

            //// 20 is an argument
            //demo.DoSomething3(15);

            //int age = 20;
            //demo.DoSomething4(age);
            //Console.WriteLine($"Age: {age}");

            //// with ref a variable must be initialized before passing it to the method
            //demo.DoSomething5(ref age);
            //Console.WriteLine($"Age: {age}");

            //// with out a variable can be uninitialized before passing it to the method
            //int age2;
            //demo.DoSomething6(out age2);
            //Console.WriteLine($"Age: {age2}");

            //// Static Method Call Syntax: <class-name>.<method-name>(<parameters list>);
            //Demo.DoSomething9();

            //Console.ReadKey();
        }
    }
}
