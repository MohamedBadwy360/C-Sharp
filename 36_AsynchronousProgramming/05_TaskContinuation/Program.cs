namespace _05_TaskContinuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task Continuation is used to run a task after another task is completed successfully or with an exception or cancelled
            // Task.ContinueWith() method is used to run a task after another task is completed
            // Task.ContinueWith() method has 3 overloads
            // 1. Task.ContinueWith(Action<Task> action)
            // 2. Task.ContinueWith(Action<Task> action, TaskContinuationOptions options)
            // 3. Task.ContinueWith(Action<Task> action, CancellationToken cancellationToken, TaskContinuationOptions options, TaskScheduler scheduler)

            // Task.GetAwaiter() returns a TaskAwaiter object which has OnCompleted() method that is used to run a task after another task is completed

            // TaskAwaiter: is a struct that is used to wait for the completion of a task and to get the result of the task when it's completed and to run a task after another task is completed successfully or with an exception or cancelled
            // It has 3 methods:
            // 1. Task.GetAwaiter().GetResult() is used to get the result of a task when it's completed
            // 2. Task.GetAwaiter().IsCompleted is used to check if a task is completed or not
            // 1. Task.GetAwaiter().OnCompleted(Action action) is used to run a task after another task is completed

            // task.ContinueWith() is used to run a task after another task is completed successfully or with an exception or cancelled and it's used to run a task in a different thread than the main thread 

            // We can use Task.ContinueWith() or Task.GetAwaiter().OnCompleted() to run a task after another task is completed successfully or with an exception or cancelled but Task.ContinueWith() is more powerful than Task.GetAwaiter().OnCompleted() because Task.ContinueWith() has more overloads and it can run a task in a different thread than the main thread and it can run a task after another task is completed successfully or with an exception or cancelled 
            // Task.ContinueWith() is better.

            // --------------------------------------------------------------------------------------------

            Task<int> task = Task.Run(() => CountPrimeNumberInARange(2, 3_000_000));
            //Console.WriteLine(task.Result);     // bad practice because it blocks the main thread until the task is completed, it's used if the result don't take long time to be calculated

            //Console.WriteLine("Using awaiter OnCompleted");
            //var awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() =>
            //{
            //    Console.WriteLine(awaiter.GetResult());     // blocks the main thread (in origin) until the task is completed but the task is completed so it doesn't block the main thread in this case because the task is completed
            //});

            //Console.WriteLine("Awaiting !!!");

            task.ContinueWith(t =>
            {
                Console.WriteLine(t.Result);        // blocks the main thread (in origin) until the task is completed but the task is completed so it doesn't block the main thread in this case because the task is completed
            });

            Console.WriteLine("Awaiting !!!");


            Console.ReadKey();
        }

        static int CountPrimeNumberInARange(int lowerBound, int upperBound)
        {
            var count = 0;
            for (int i = lowerBound; i < upperBound; i++)
            {
                var j = 2;
                var isPrime = true;
                while (j <= (int)Math.Sqrt(i))
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    ++j;
                }

                if (isPrime)
                    ++count;
            }
            return count;
        }
    }
}
