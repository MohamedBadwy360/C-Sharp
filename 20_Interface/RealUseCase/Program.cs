namespace RealUseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(new Cash());
            cashier.Checkout(9999999.99m);

            Cashier cashier1 = new Cashier(new Debit());
            cashier1.Checkout(9999999.99m);

            // Difference Loose Coupling & Tight Coupling 
            // Loose Coupling is a design goal that seeks to reduce the inter-dependencies between components of a system with the goal of reducing the risk that changes in one component will require changes in any other component.
            // Tight Coupling is when a group of classes are highly dependent on one another.


        }
    }

    class Cashier
    {
        // Tight Coupling
        //private readonly Csh _cash;
        //private readonly Debit _debit;
        //private readonly Credit _credit;
        // .......
        // .......
        // .......
        // .......


        // Loose Coupling
        private readonly IPayment _payment;

        public Cashier(IPayment payment)
        {
            _payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }

    interface IPayment
    {
        void Pay(decimal amount);
    }

    class Cash : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment: {Math.Round(amount, 2):N}");
        }
    }

    class Debit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment: {Math.Round(amount, 2):N}");
        }
    }

    class Credit : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Credit Payment: {Math.Round(amount, 2):N}");
        }
    }

    class MasterCard : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"MasterCard Payment: {Math.Round(amount, 2):N}");
        }
    }

    class Visa : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Visa Payment: {Math.Round(amount, 2):N}");
        }
    }

    class PayPal : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"PayPal Payment: {Math.Round(amount, 2):N}");
        }
    }
}
