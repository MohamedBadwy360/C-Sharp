namespace _02_Sequential
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The same thread can be transferred between different processors during its lifetime.
            // The thread is not bound to a specific processor.
            // The operating system is responsible for scheduling threads on processors.
            // The operating system can move a thread from one processor to another to balance the load.
            // The operating system can move a thread from one processor to another to optimize the cache usage.
            // The operating system can move a thread from one processor to another to optimize the power consumption.
            // The operating system can move a thread from one processor to another to optimize the performance.
            // The operating system can move a thread from one processor to another to optimize the temperature.
            // The operating system can move a thread from one processor to another to optimize the memory usage.
            // The operating system can move a thread from one processor to another to optimize the I/O operations.
            // The operating system can move a thread from one processor to another to optimize the network usage.
            // The operating system can move a thread from one processor to another to optimize the disk usage.
            // The operating system can move a thread from one processor to another to optimize the GPU usage.
            // The operating system can move a thread from one processor to another to optimize the CPU usage.
            // The operating system can move a thread from one processor to another to optimize the memory bandwidth.
            // The operating system can move a thread from one processor to another to optimize the cache bandwidth.
            // The operating system can move a thread from one processor to another to optimize the power bandwidth.
            // The operating system can move a thread from one processor to another to optimize the performance bandwidth.

            // Thread Scheduler 
            // The thread scheduler is responsible for scheduling threads on processors.
            // It is responsible for creating, destroying, and managing threads.
            // It uses Round Robin algorithm to schedule threads.


            var wallet = new Wallet("Issam", 80);

            wallet.RunRandomTransactions();
            Console.WriteLine("----------------");
            Console.WriteLine($"{wallet}\n");

            wallet.RunRandomTransactions();
            Console.WriteLine("----------------");
            Console.WriteLine($"{wallet}\n");

            Console.ReadKey();
        }
    }

    class Wallet
    {
        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public string Name { get; private set; }
        public int Bitcoins { get; private set; }


        public void Debit(int amount)
        {
            Bitcoins -= amount;
        }

        public void Credit(int amount)
        {
            Bitcoins += amount;
        }

        public void RunRandomTransactions()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 }; // 80

            foreach (var amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                    Debit(absValue);
                else
                    Credit(absValue);
                Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}" +
                    $", Processor Id: {Thread.GetCurrentProcessorId()}] {amount}");
            }
        }

        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
