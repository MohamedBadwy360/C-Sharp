namespace _04_RaceCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In Sequential execution, race condition is not possible because the code is executed sequentially.

            // In concurrent execution / parallel execution / multi-thread execution, race condition is possible because multiple threads are executing the code simultaneously and accessing the shared resource.

            // Race Condition is a scenario where two or more threads try to modify a shared resource at the same time. As a result, the values of the shared resource are unpredictable.
            // Race Condition is a type of concurrency bug.
            // Race Condition is a scenario where the outcome of the program is affeced because of timing of execution of threads.

            // To solve race condition problem we use lock keyword to make sure that only one thread can access the shared resource at a time.

            // lock keyword is used to obtain a mutual-exclusion lock for a given object, execute a statement block, and then release the lock.
            // It take an object/reference type as a parameter, this object is used to synchronize access to the shared resource.
            // lock keyword is used to create a critical section, a block of code that must be executed by only one thread at a time.

            // Any code that may cause race condition should be placed inside a lock block and pass to lock keyword a reference type that will be used to synchronize access to the shared resource.


            // -------------------------------------------------------------------------------------------

            var wallet = new Wallet("Issam", 50);

            //wallet.Debit(40);                                                  // 10
            //wallet.Debit(30);                                                         
            //Console.WriteLine(wallet);


            // method that take parameter we use lambda expression to pass it to the thread constructor 
            Thread t1 = new Thread(() => wallet.Debit(40));
            Thread t2 = new Thread(() => wallet.Debit(30));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine(wallet);

            Console.ReadKey();
        }
    }

    class Wallet
    {
        private readonly object bitcoinsLock = new object();
        public Wallet(string name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public string Name { get; private set; }
        public int Bitcoins { get; private set; }


        public void Debit(int amount)
        {
            lock (bitcoinsLock)
            {
                if (Bitcoins >= amount)
                {
                    Thread.Sleep(1000);

                    Bitcoins -= amount;
                }
            }
        }

        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
        }


        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
