namespace _03_LongRunningTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can distinguish between long-running and short-running threads based on the comparison between their start up time and their life span(run time).
            // Startup time: The time it takes to start a thread.
            // Life span: The time it takes to run a thread.
            // If the startup time is greater than the life span, the thread is considered a long-running thread.
            // If the startup time is less than the life span, the thread is considered a short-running thread.
            // startup time > life span => long-running thread => don't use thread pool.
            // startup time < life span => short-running thread => use thread pool.

            // Long running tasks are those that are expected to run for a long time.
            // Short running tasks are those that are expected to run for a short time.

            // Long-running threads are those that are expected to run for a long time, and short-running threads are those that are expected to run for a short time.

            // With long running tasks, we use Factory.StartNew() with the TaskCreationOptions.LongRunning option to create a new thread for the task.
            // The only difference to use this way that the thread is not pooled but is background.

            // TaskCreationOptions:
            // 1. None: The default option.
            // 2. PreferFairness: The task scheduler will try to distribute the tasks fairly.
            // 3. LongRunning: The task scheduler will create a new thread for the task.
            // 4. AttachedToParent: The task will be attached to the parent task.
            // 5. DenyChildAttach: The task will not be attached to the parent task.
            // 6. HideScheduler: The task scheduler will be hidden.
            // 7. RunContinuationsAsynchronously: The task will run the continuations asynchronously.

            // Best things for pooled threads are short-running tasks to make rotation of threads in the pool.
            // Long-running tasks are not suitable for pooled threads because they will block the pool.


            // --------------------------------------------------------------------------------------------

            // The LongRunning option is used to create a new thread for the long running task.
            Task.Factory.StartNew(RunLongTask, TaskCreationOptions.LongRunning);    // The thread is not pooled but is background.

            Console.ReadKey();
        }

        static void RunLongTask()
        {
            Thread.Sleep(3000);
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine("Long Task Commpleted");
        }

        static void ShowThreadInfo(Thread currentThread)
        {
            Console.WriteLine($"TID: {currentThread.ManagedThreadId}, Pooled: {currentThread.IsThreadPoolThread}, Background: {currentThread.IsBackground}");
        }
    }
}
