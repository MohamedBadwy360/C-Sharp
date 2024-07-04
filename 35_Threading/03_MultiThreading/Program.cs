namespace _03_MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread.Sleep() is used to simulate a long running operation in the code.
            // It is not recommended to use Thread.Sleep() in production code.
            // It is used to stop the execution of the current thread for a specified amount of time in milliseconds.
            // Thread.Sleep(1000) will stop the execution of the current thread for 1 second.

            // Naming Threads helps in debugging, tracing and understanding the code.
            // Thread.CurrentThread.Name = "Main Thread"; => This will name the main thread as "Main Thread".

            // How to create threads in C#?
            // 1. Using Thread class.
            // 2. Using Task class.
            // 3. Using ThreadPool.

            // Thread class is used to create and manage threads in C#.

            // You are at the mercy of Thread Scheduler.
            // Thread Scheduler is responsible for scheduling threads on the CPU.
            // Thread Scheduler is responsible for deciding which thread to run next.
            // Thread Scheduler is responsible for deciding how long a thread should run.
            // Thread Scheduler is responsible for deciding when to pause a thread and resume it.
            // Thread Scheduler is responsible for deciding when to terminate a thread.
            // Thread Scheduler is responsible for deciding when to switch between threads.

            // Foreground and Background Threads:
            // Thread.CurrentThread.Backround => Gets or sets a value indicating whether or not a thread is a background thread.
            // Background threads are identical to foreground threads, except that background threads do not prevent a process from terminating.
            // By default, all threads are foreground threads not background threads.
            // Foreground threads keep the application alive until the thread completes.
            // Foreground threads keep application alive as long as one of them is running.
            // Foreground threads are terminated when the application ends.
            // Foreground threads are used for long running operations.
            // If main thread ends and there are any foreground threads running, the application will not terminate.
            // Background threads are terminated when the application ends.
            // Background threads are used for short running operations.
            // Background threads are used for tasks that do not need to be completed before the application ends.
            // Background threads don't keep the application alive on their own. They are terminated when the application ends / all foreground threads are terminated.
            // If the application ends the Operating System will terminate/kill all background threads.
            // Background threads are called daemon threads which means they are not important for the application to run.

            // If the thread is foreground all the threads created by that thread are foreground threads.
            // If the thread is background all the threads created by that thread are background threads.

            // Thread Object Properities: 
            // Name: Gets or sets the name of the thread.
            // ManagedThreadId: Gets a unique identifier for the current managed thread.
            // IsBackground: Gets or sets a value indicating whether or not a thread is a background thread.
            // CurrentThread: Gets the currently running thread.
            // ThreadState: Gets a value containing the states of the current thread.

            // Joining a Thread: meaning waiting for a thread to finish.
            // Thread.Join() is used to wait for a thread to finish.
            // When to use Joining a Thread? => When you want to wait for a thread to finish before continuing the execution of the main thread.

            // ThreadState:
            // Unstarted: The thread has not been started yet.
            // Running: The thread is running.
            // WaitSleepJoin: The thread is sleeping, waiting or joining.
            // Stopped: The thread has stopped.
            // Aborted: The thread has been aborted.
            // AbortRequested: The thread is requested to be aborted.


            // ---------------------------------------------------------------------------------------------

            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine($"Main Thread Background Thread: {Thread.CurrentThread.IsBackground}");

            Console.WriteLine("------------------------------");

            var wallet = new Wallet("Mohamed", 100);

            // Using Thread class to create a new thread.
            Thread t1 = new Thread(wallet.RunRandomTransactions);   // Main thread creates a new thread t1.
            t1.Name = "T1";
            Console.WriteLine($"T1 Background Thread: {t1.IsBackground}");
            Console.WriteLine($"After declaration {t1.Name} state is: {t1.ThreadState}");

            // T1 is created as a foreground thread but it is still not started.
            // T1 is a foreground thread because it is created by the main thread which is a foreground thread.
            // We need to start the thread using Start() method.

            t1.Start();                                                             // Starting the thread t1.
            Console.WriteLine($"After start {t1.Name} state is: {t1.ThreadState}");         // ThreadState is Running.
            t1.Join();                                                              // Main thread waits for t1 to finish.
            Console.WriteLine($"After joining {t1.Name} state is: {t1.ThreadState}");       // ThreadState is Stopped.

            // Another way to create a thread using Thread class.
            Thread t2 = new Thread(new ThreadStart(wallet.RunRandomTransactions));  // Main thread creates a new thread t2.
            t2.Name = "T2";
            t2.Start();                                                             // Starting the thread t2.

            // The two threads t1 and t2 are running concurrently with the main thread.
            // The main thread is not waiting for the t1 and t2 threads to complete.
            // The two thread are running in parallel with the main thread.



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
            Thread.Sleep(1000);
            Bitcoins -= amount;
            Console.WriteLine(
                $"[Thread: {Thread.CurrentThread.ManagedThreadId}-{Thread.CurrentThread.Name} " +
                $", Processor Id: {Thread.GetCurrentProcessorId()}] -{amount}");
        }

        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
            Console.WriteLine(
                $"[Thread: {Thread.CurrentThread.ManagedThreadId}-{Thread.CurrentThread.Name} " +
                $", Processor Id: {Thread.GetCurrentProcessorId()}] +{amount}");
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

            }
        }

        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
