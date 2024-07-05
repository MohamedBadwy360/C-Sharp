namespace _12_ConcurrencyAndParallelism
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Asynchronous & Synchronous are programming models that are used to execute the code.
            // Asynchronous: It allows the program to execute the code without blocking the current thread.
            // Synchronous: It blocks the current thread until the execution of the code is completed.

            // Concurrency & Parallelism are the execution models that are used to execute the code.
            // Concurrency: It allows the program to execute multiple tasks at the same time.   االتعامل مع أكثر من شئ فى وقت واحد
            // Parallelism: It allows the program to execute multiple tasks simultaneously.     التنفيذ المتزامن للكثير من الأشياء فى وقت واحد
            // Concurrency is when two tasks can start, run, and complete in overlapping time periods. It doesn't necessarily mean they'll ever both be running at the same instant. For example, multitasking on a single-core machine.
            // Parallelism is when tasks literally run at the same time, e.g., on a multicore processor.
            // Concurrency is achieved by using a single-core processor, whereas Parallelism is achieved by using a multi-core processor.

            // In C#, we can achieve Concurrency & Parallelism using the following ways:
            // 1. Task Parallel Library (TPL)
            // 2. Parallel LINQ (PLINQ)
            // 3. Asynchronous Programming Model (APM)
            // 4. Event-based Asynchronous Pattern (EAP)
            // 5. Task-based Asynchronous Pattern (TAP)
            // 6. Asynchronous Programming Model (APM)


            // Task Parallel Library (TPL) is a set of public types and APIs in the System.Threading and System.Threading.Tasks namespaces in .NET that simplifies the work of adding parallelism and concurrency to applications.
            // TPL provides a task-based model for asynchronous programming. In this model, the work that needs to be performed is represented as a task. The task can tell you if the work is completed and if the operation returns a result, the task gives you the result.
            // TPL provides a task scheduler that coordinates the execution of tasks on the thread pool. The task scheduler makes decisions about how and when to start tasks based on factors like task priority, task dependencies, and the availability of threads.
            // TPL also includes a set of types that support the development of data parallel algorithms. These types include Parallel, ParallelQuery, and the data parallel algorithms in the System.Collections.Concurrent namespace.
            // TPL is intended to work with the .NET Framework, and it is not supported for use in Windows Store apps or Windows Phone apps.

            // Parallel class provides static methods to create and run parallel loops. It is a part of the System.Threading.Tasks namespace.
            // Parallel class provides the following methods:
            // 1. For: Executes a for loop in which iterations may run in parallel.
            // 2. ForEach: Executes a foreach operation on an IEnumerable in which iterations may run in parallel.
            // 3. Invoke: Executes each of the provided actions, possibly in parallel.

            // In parallel, every task is executed on a separate thread and each thread on a different processor. It allows the program to execute multiple tasks simultaneously.
            // In concurrency, every task is executed on the same thread and the thread on the same processor or may be different but rarely. It allows the program to execute multiple tasks at the same time.

            // In parallel, the tasks are executed simultaneously/in the same time. It is achieved by using a multi-core processor.
            // In concurrency, tasks are dealed with in the same time but the tasks are executed one by one. It is achieved by using a single-core processor.

            // -----------------------------------------------------------------------------------------

            var things = new List<DailyDuty>
            {
                new DailyDuty("Cleaning House"),
                new DailyDuty("Washing Dishes"),
                new DailyDuty("Doing Laundry"),
                new DailyDuty("Preparing Meals"),
                new DailyDuty("Checking Emails"),
                new DailyDuty("Cleaning House")
            };

            //Console.WriteLine("Using Parallel Processing");
            //await ProcessThingsInParallel(things);      // Executes a foreach operation on an IEnumerable in which iterations may run in parallel.

            Console.WriteLine("Using Concurrent Processing");
            await ProcessThingsInConcurrent(things);  // Concurrency is achieved by using a single-core processor (foreach loop).


            Console.ReadKey();
        }

        static Task ProcessThingsInParallel(IEnumerable<DailyDuty> things)
        {
            Parallel.ForEach(things, thing => thing.Process());     // Executes a foreach operation on an IEnumerable in which iterations may run in parallel.
            return Task.CompletedTask;      // Task.CompletedTask is a task that has already been completed successfully.
        }

        static Task ProcessThingsInConcurrent(IEnumerable<DailyDuty> things)
        {
            foreach (var thing in things)   // Concurrency is achieved by using a single-core processor (foreach loop).
            {
                thing.Process();            // It allows the program to execute multiple tasks at the same time.
            }

            return Task.CompletedTask;
        }
    }

    class DailyDuty
    {
        public string title { get; private set; }

        public bool Processed { get; private set; }

        public DailyDuty(string title)
        {
            this.title = title;
        }

        public void Process()
        {
            Console.WriteLine($"TID: {Thread.CurrentThread.ManagedThreadId}," +
                $"ProcessorId: {Thread.GetCurrentProcessorId()}");
            Task.Delay(100).Wait();
            this.Processed = true;
        }
    }
}
