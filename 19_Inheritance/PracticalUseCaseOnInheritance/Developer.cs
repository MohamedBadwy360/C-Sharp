namespace PracticalUseCaseOnInheritance
{
    public class Developer : Employee
    {
        private const decimal Bonus = 0.03m;

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool isTasksCompleted) : base(id, name, loggedHours, wage)
        {
            IsTasksCompleted = isTasksCompleted;
        }

        protected bool IsTasksCompleted { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", \nTasksCompleted: {IsTasksCompleted},\nBonus: ${Math.Round(CalculateBonus(), 2):N}, \nTotal Salary: ${Math.Round(this.CalculateSalary(), 2):N}";
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }

        private decimal CalculateBonus()
        {
            return IsTasksCompleted ? base.CalculateSalary() * Bonus : 0;
        }
    }
}
