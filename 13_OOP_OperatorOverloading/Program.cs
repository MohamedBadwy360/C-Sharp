namespace _13_OOP_OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20;

            var z = x + y;    // + is arthmetic operator (binary operator) and it is overloaded for int type
            var w = x > y;    // > is logical / comparison operator (binary operator) and it is overloaded for int type
            var n = -x;       // - is unary operator and it is overloaded for int type
            var k = !w;       // ! is negation / boolean operator (unary operator) and it is overloaded for int type


            Money m1 = new Money(10);
            Money m2 = new Money(20);

            // Operator overloading is a feature that allows us to redefine the way operators work for a user-defined type
            // Operator overloading is a type of polymorphism in which an operator is overloaded to give user-defined meaning to it
            // Operator overloading is a compile-time polymorphism in which the operator is overloaded to provide the special meaning to the user-defined data type
            // Operator overloading is a type of static polymorphism
            // Operator overloading is used to overload or redefines most of the operators available in C#

            Money m3 = m1 + m2;    // + is arthmetic operator (binary operator) and it is overloaded for Money type

            Console.WriteLine($"Money1 = {m1.Amount}, Money2 = {m2.Amount}");
            Console.WriteLine($"Money1 + Money2 = {m3.Amount}");

            Money m4 = m1 - m2;
            Console.WriteLine($"Money1 - Money2 = {m4.Amount}");

            Console.WriteLine(m4 < m3);

            Console.WriteLine($"++m4  = {(++m4).Amount}");
        }
    }

    class Money
    {
        private decimal _amount;
        public decimal Amount { get => _amount; }

        public Money(decimal amount)
        {
            _amount = amount;
        }

        // Operator overloading for Money type for + 
        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.Amount + money2.Amount);
        }

        // Operator overloading for Money type for - 
        public static Money operator -(Money money1, Money money2)
        {
            return new Money(money1.Amount - money2.Amount);
        }


        // Operator overloading for Money type for > 
        public static bool operator >(Money money1, Money money2) => money1.Amount > money2.Amount;

        // Must overload < operator as well to make it work if you overload > operator
        public static bool operator <(Money money1, Money money2) => money1.Amount < money2.Amount;


        // The same as >=, <= must be overloaded as well if you overload any of them
        public static bool operator >=(Money money1, Money money2) => money1.Amount >= money2.Amount;
        public static bool operator <=(Money money1, Money money2) => money1.Amount <= money2.Amount;

        // The same as ==, != must be overloaded as well if you overload any of them
        public static bool operator ==(Money money1, Money money2) => money1.Amount == money2.Amount;
        public static bool operator !=(Money money1, Money money2) => money1.Amount != money2.Amount;


        // Unary operator overloading for Money type for ++
        public static Money operator ++(Money money)
        {
            var value = money.Amount;
            return new Money(++value);
        }

        // Unary operator overloading for Money type for --
        public static Money operator --(Money money)
        {
            var value = money.Amount;
            return new Money(--value);
        }
    }
}
