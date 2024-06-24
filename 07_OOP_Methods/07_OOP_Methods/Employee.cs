namespace _07_OOP_Methods
{
    public class Employee
    {
        // static field => shared among all instances of the class (objects), can be accessed using the class name
        // static fields are initialized only once, at the start of the program
        // static fields can be changed during the program execution but the change will be reflected in all instances of the class (objects)
        // static and constant fields are stored in the memory area called high frequency heap (HFH) 
        public static double TAX = 0.03;

        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        private double CalculateSalary() => Wage* LoggedHours;
        private double CalculateTax() => CalculateSalary() * TAX;
        private double CalculateNetSalary() => CalculateSalary() * CalculateTax();

        public string PrintSlip()
        {
            return $"Employee: {FName} {LName}\n" +
                   $"Salary: {CalculateSalary()}\n" +
                   $"Tax: {CalculateTax()}\n" +
                   $"Net Salary: {CalculateNetSalary()}";
        }
    }
}
