using System.Reflection;

namespace _04_HowToGetClassMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account("123", "John Doe", 1000);
            //account.OnNegativeBalance += Account_OnNegativeBalance;

            //account.Withdraw(500);
            //Console.WriteLine(account);

            //account.Withdraw(600);
            //Console.WriteLine(account);

            // ------------------------------------------------------------------------------ 

            // Inspection of class members using reflection 

            // MemberInfo class is the base class for all members of a class (fields, properties, methods, events, etc.)
            // FieldInfo class is used to inspect fields of a class 
            // PropertyInfo class is used to inspect properties of a class
            // MethodInfo class is used to inspect methods of a class
            // EventInfo class is used to inspect events of a class
            // ConstructorInfo class is used to inspect constructors of a class 

            // Get all members of a class 
            Console.WriteLine("---------------------------- MemberInfo ---------------------------");
            MemberInfo[] members = typeof(Account).GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("---------------------------- MemberInfo ---------------------------");

            MemberInfo[] members1 = typeof(Account).GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var member in members1)
            {
                Console.WriteLine(member.Name);
            }

            Console.WriteLine("---------------------------- FieldInfo ---------------------------");

            FieldInfo[] privateFields = typeof(Account).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in privateFields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("---------------------------- PropertyInfo ---------------------------");
            PropertyInfo[] properties = typeof(Account).GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.GetGetMethod());     // Get method of the property 
                //Console.WriteLine(property.GetSetMethod());   // Set method of the property
                Console.WriteLine(property.Name);
            }

            Console.WriteLine("---------------------------- PropertyInfo ---------------------------");

            EventInfo[] events = typeof(Account).GetEvents();
            foreach (var ev in events)
            {
                Console.WriteLine(ev.Name);
            }

            Console.WriteLine("---------------------------- ConstructorInfo ---------------------------");

            ConstructorInfo[] constructors = typeof(Account).GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor);
            }

            Console.WriteLine("---------------------------- MethodInfo ---------------------------");

            MethodInfo[] methods = typeof(Account).GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method);
            }

            Console.WriteLine("---------------------------- Get Member By Name ---------------------------");

            MemberInfo[] ctors = typeof(Account).GetMember(".ctor");
            foreach (var ctor in ctors)
            {
                Console.WriteLine(ctor);
            }
        }

        private static void Account_OnNegativeBalance(object sender, EventArgs e)
        {
            Console.WriteLine("NEGATIVE BALANCE !!!!!!!!!!");
        }
    }

    public class Account
    {
        private string _accountNumber;
        private string _accountHolder;
        private decimal _balance;

        public string AccountNumber => _accountNumber;
        public string AccountHolder => _accountHolder;
        public decimal Balance => _balance;

        public event EventHandler OnNegativeBalance;

        public Account(string accountNumber, string accountHolder, decimal balance)
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
