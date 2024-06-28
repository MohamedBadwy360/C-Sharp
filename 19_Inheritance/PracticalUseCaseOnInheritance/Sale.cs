namespace PracticalUseCaseOnInheritance
{
    public class Sales : Employee
    {
        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal commission, decimal salesVoluum)
            : base(id, name, loggedHours, wage)
        {
            Commission = commission;
            SalesVolume = salesVoluum;
        }

        protected decimal Commission { get; set; }
        protected decimal SalesVolume { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", \nCommission: ${Math.Round(Commission, 2):N}, \nSales Volume: ${Math.Round(SalesVolume, 2):N}, \nBonus: ${Math.Round(CalculateBonus(), 2):N}, \nBonus: ${Math.Round(CalculateBonus(), 2):N}, \nTotal Salary: ${Math.Round(this.CalculateSalary(), 2):N}";
        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }

        private decimal CalculateBonus()
        {
            return SalesVolume * Commission;
        }
    }
}
