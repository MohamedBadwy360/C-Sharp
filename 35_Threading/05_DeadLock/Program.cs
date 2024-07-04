namespace _05_DeadLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dead lock is a situation where two or more threads are blocked forever, waiting for each other.
            // Dead lock occurs when two threads have a circular dependency on a pair of synchronized objects.
            // Dead lock is a common problem in multi-threaded programming.
            // Dead lock is a situation where two or more threads are frozen in their execution because they are waiting for each other to release the lock / finish.

            // We can avoid dead lock by following these rules:
            // 1. Avoid nested locks.
            // 2. Avoid locking multiple objects at the same time.
            // 3. Use a timeout when acquiring a lock.
            // 4. Use a lock hierarchy to avoid circular dependencies.
            // 5. Use lock() statement instead of Monitor class.

            // We can use Monitor.TryEnter() method to avoid dead lock.
            // Monitor.TryEnter() method allows us to acquire a lock on an object with a specified timeout.
            // If the lock is not acquired within the specified timeout, the method returns false.
            // If the lock is acquired within the specified timeout, the method returns true.

            // We can solve the dead lock problem by using proper order of objects to lock.


            // -------------------------------------------------------------------------------------------


            // Happy path 

            //var wallet1 = new Wallet(1, "Issam", 100);
            //var wallet2 = new Wallet(2, "Reem", 50);
            //Console.WriteLine("\n Before Transaction");
            //Console.WriteLine("\n---------------------");
            //Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();
            //Console.WriteLine("\n After Transaction");
            //Console.WriteLine("\n---------------------");

            //var transferManager1 = new TransferManager(wallet1, wallet2, 50);
            //transferManager1.Transfer();
            //Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();

            // -------------------------------------------------------------------------------------------

            // Dead lock path

            var wallet1 = new Wallet(1, "Issam", 100);
            var wallet2 = new Wallet(2, "Reem", 50);
            Console.WriteLine("\n Before Transaction");
            Console.WriteLine("\n---------------------");
            Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();
            Console.WriteLine("\n After Transaction");
            Console.WriteLine("\n---------------------");

            var transferManager1 = new TransferManager(wallet1, wallet2, 50);
            var transferManager2 = new TransferManager(wallet2, wallet1, 30);

            var t1 = new Thread(transferManager1.Transfer);
            t1.Name = "T1";
            var t2 = new Thread(transferManager2.Transfer);
            t2.Name = "T2";

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.Write(wallet1 + ", "); Console.Write(wallet2); Console.WriteLine();

            Console.ReadKey();
        }
    }

    class Wallet
    {
        private readonly object bitcoinsLock = new object();
        public Wallet(int id, string name, int bitcoins)
        {
            Id = id;
            Name = name;
            Bitcoins = bitcoins;
        }

        public int Id { get; private set; }
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

    class TransferManager
    {
        private Wallet from;
        private Wallet to;

        private int amountToTransfer;

        public TransferManager(Wallet from, Wallet to, int amountToTransfer)
        {
            this.from = from;
            this.to = to;
            this.amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            var lock1 = from.Id < to.Id ? from : to;
            var lock2 = from.Id < to.Id ? to : from;

            Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {lock1}");
            lock (lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {lock1}");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {lock2}");

                lock (lock2)
                {
                    from.Debit(amountToTransfer);
                    to.Credit(amountToTransfer);
                }
            }
        }

        //public void Transfer()
        //{
        //    Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {from}");
        //    lock (from)
        //    {
        //        Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {from}");
        //        Thread.Sleep(1000);
        //        Console.WriteLine($"{Thread.CurrentThread.Name} trying to lock ... {to}");

        //        //lock (to)
        //        //{
        //        //    from.Debit(amountToTransfer);
        //        //    to.Credit(amountToTransfer);
        //        //}

        //        if (Monitor.TryEnter(to, 1000))
        //        {
        //            Console.WriteLine($"{Thread.CurrentThread.Name} lock acquired ... {to}");

        //            try
        //            {
        //                from.Debit(amountToTransfer);
        //                to.Credit(amountToTransfer);
        //            }
        //            finally
        //            {
        //                Monitor.Exit(to);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{Thread.CurrentThread.Name} unable to acquire lock on ... {to}");
        //        }
        //    }
        //}
    }
}
