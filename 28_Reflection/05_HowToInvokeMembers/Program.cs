using System.Reflection;

namespace _05_HowToInvokeMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("123", "John Doe", 1000);

            // Get the type of the Account class
            Type type = typeof(BankAccount);

            // Invoke the Deposit method of the Account class
            MethodInfo depositMethod = type.GetMethod("Deposit");
            depositMethod.Invoke(account, new object[] { 500m });
            Console.WriteLine(account);

            Console.ReadKey();
        }
    }

    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private decimal _balance;

        public string AccountNumber => _accountNumber;
        public string AccountHolder => _accountHolder;
        public decimal Balance => _balance;

        public event EventHandler OnNegativeBalance;

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            _accountNumber = accountNumber;
            _accountHolder = accountHolder;
            _balance = balance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;

            if (_balance < 0)
            {
                OnNegativeBalance?.Invoke(this, null);
            }
        }

        public override string ToString()
        {
            return $"{{ AcountNumber: {_accountNumber}, AccountHolder: {_accountHolder}, Balance: {_balance}}}";
        }
    }
}
