namespace PracticalUseCaseOnInheritance
{
    public class Maintainance : Employee
    {
        private const decimal Hardship = 100m;

        public Maintainance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $", \nHardship: ${Math.Round(Hardship, 2):N}, \nTotal Salary: ${Math.Round(this.CalculateSalary(), 2):N}";
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + Hardship;
        }
    }
}
