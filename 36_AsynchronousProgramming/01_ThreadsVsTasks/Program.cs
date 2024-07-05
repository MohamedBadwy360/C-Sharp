
namespace _01_ThreadsVsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Difference between Threads and Tasks: 
            // Threads are lower level and more complex to work with than Tasks.
            // Tasks are built on top of the Thread class and provide a simpler and more efficient way to work with threads.
            // Threads are managed by the operating system, while Tasks are managed by the .NET runtime.
            // Tasks use the ThreadPool to execute work, while Threads do not.
            // Tasks are pooled and reused and backgrund threads, while Threads are not.
            // Threads are more flexible and can be used in more complex scenarios, while Tasks are simpler and easier to work with.


            // Task is a higher level abstraction that uses the ThreadPool to execute work. 
            // The Task class is part of the Task Parallel Library (TPL) and provides a simple way to work with threads.
            // Task simplifies the process of working with threads by providing a higher level of abstraction.

            // There is generic and non-generic Task class.
            // The generic Task class is used when you want to return a result from the asynchronous operation.
            // The non-generic Task class is used when you do not want to return a result from the asynchronous operation.

            // Highly recommended to use Tasks instead of Threads in most scenarios.

            // ------------------------------------------------------------------------------------------

            // Task class: 
            // - Represents an asynchronous operation.
            // - Provides a simple way to work with threads.
            // - Uses the ThreadPool to execute work.
            // - Provides a way to return a result from the asynchronous operation.
            // - Provides a way to handle exceptions that occur during the asynchronous operation.

            // Task class static properties: 
            // - CompletedTask: Gets a task that has already completed successfully.
            // - Factory: Gets the default task factory.
            // - CurrentId: Gets the ID of the currently executing task.

            // Task class static methods:
            // - Wait: Blocks the calling
            // - ContinueWith: Specifies a continuation task to run when the task completes.
            // - Run: Creates and starts a task.
            // - WhenAll: Creates a task that will complete when all of the provided tasks have completed.
            // - WhenAny: Creates a task that will complete when any of the provided tasks have completed.
            // - WaitAll: Waits for all of the provided tasks to complete.
            // - WaitAny: Waits for any of the provided tasks to complete.
            // - Delay: Creates a task that will complete after a specified time delay.
            // - FromResult: Creates a task that has already completed with the specified result.
            // - FromException: Creates a task that has already completed with the specified exception.
            // - FromCanceled: Creates a task that has already completed with the specified cancellation token.



            // ------------------------------------------------------------------------------------------

            Thread t1 = new Thread(() => Display("Hello from t1!"));        // not pooled, not background
            t1.Start();
            t1.Join();

            Task.Run(() => Display("Hello from Task!")).Wait();                    // pooled, background

            Console.ReadKey();
        }

        static void Display(string message)
        {
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine(message);
        }

        static void ShowThreadInfo(Thread currentThread)
        {
            Console.WriteLine($"TID: {currentThread.ManagedThreadId}, Pooled: {currentThread.IsThreadPoolThread}, Background: {currentThread.IsBackground}");
        }
    }
}
