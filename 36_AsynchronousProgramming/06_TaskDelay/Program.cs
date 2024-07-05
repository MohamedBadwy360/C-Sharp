namespace _06_TaskDelay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task Delay is used to delay the execution of the task for a specified time.
            // It is used to introduce a delay in the execution of the task.
            // Task.Delay is a static method that returns a task that completes after a specified time.
            // It is a non-blocking method, which means it does not block the calling thread.
            // Task Delay is asynchronous way of Thread.Sleep method.
            // Task.Delay() is like a logical delay, it does not block the thread, it just delays the execution of the task.

            // Thread.Sleep is used to block the calling thread for a specified time. 
            // It is used to introduce a delay in the execution of the thread.
            // Thread.Sleep is a static method that blocks the calling thread for a specified time.
            // Thread.Sleep is a blocking method, which means it blocks the calling thread.

            // --------------------------------------------------------------------------------------------

            DelayUsingTask(2000);
            //SleepUsingThread(2000);

            Console.ReadKey();
        }

        static void DelayUsingTask(int ms)
        {
            // You need to deal with the task returned by Task.Delay() method to get the delay effect.
            //Task.Delay(ms);                     // This will not block the calling thread. It will return a task that completes after the specified time. 
            //Console.WriteLine($"Completed after Task.Delay({ms})"); // This will be executed immediately after Task.Delay(ms) is called.

            // --------------------------------------------------------------------------------------------

            //Task.Delay(ms).Wait(); // This will block the calling thread. It will return a task that completes after the specified time.
            //Console.WriteLine($"Completed after Task.Delay({ms})"); // This will be executed after the specified time.


            //Task.Delay(ms).ContinueWith((t) =>                  // This will block the calling thread. It will return a task that completes after the specified time.
            //{
            //    Console.WriteLine($"Completed after Task.Delay({ms})");     // This will be executed after the specified time.
            //});

            Task.Delay(ms).GetAwaiter().OnCompleted(() => Console.WriteLine($"Completed after Task.Delay({ms})")); // This will block the calling thread. It will return a task that completes after the specified time.
        }

        static void SleepUsingThread(int ms)
        {
            Thread.Sleep(ms);       // This will block the calling thread for the specified time. 
            Console.WriteLine($"Completed after Thread.Sleep({ms})"); // This will be executed after the specified time.

        }
    }
}
