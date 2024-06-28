namespace PracticalUseCaseOnInheritance
{
    abstract public class Employee
    {
        private const int MinimumLoggedHours = 176;
        private const decimal OverTimeMultiplier = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public override string ToString()
        {
            return $"\nType: {GetType().Name}, \nId: {Id}, \nName: {Name}, \nLogged Hours: {LoggedHours}, \nWage: {Wage}, \nBase Salary: ${Math.Round(CalculateBaseSalary(), 2):N}, \n$Overtime Salary: {Math.Round(CalculateOvertimeSalary(), 2):N}";
        }

        protected virtual decimal CalculateSalary()
        {
            return CalculateBaseSalary() + CalculateOvertimeSalary();
        }

        private decimal CalculateBaseSalary()
        {
            return MinimumLoggedHours * Wage;
        }

        private decimal CalculateOvertimeSalary()
        {
            var additionalHours = (LoggedHours - MinimumLoggedHours) > 0 ? (LoggedHours - MinimumLoggedHours) : 0;
            return additionalHours * Wage * OverTimeMultiplier;
        }
    }
}
