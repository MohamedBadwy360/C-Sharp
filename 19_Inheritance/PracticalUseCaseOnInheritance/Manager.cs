namespace PracticalUseCaseOnInheritance
{
    public class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05m;

        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $", \nAllowance: ${Math.Round(CalculateAllowance(), 2):N}, \nTotal Salary: ${Math.Round(this.CalculateSalary(), 2):N}";
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateAllowance();
        }

        private decimal CalculateAllowance()
        {
            return base.CalculateSalary() * AllowanceRate;
        }
    }
}
