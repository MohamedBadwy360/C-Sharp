namespace _07_SyncVsAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------------- Synchronous --------------------------------------

            // A synchronous method is a blocking method. It means that the method will not return until it has completed its work.
            // A synchronous operation does its work before returning to the calller.
            // A synchronous operation does its work on the same thread that called it.

            // In UI applications, if you call a synchronous method that takes a long time to complete, the UI will freeze until the method returns.

            // Thread.Sleep() is used to pause the current thread for a specified amount of time. It blocks the current thread until the time is up.
            // Thread.Join() is used to wait for a thread to complete. It blocks the current thread until the thread is completed.
            // Thread.Sleep() and Thread.Join() are blocking methods. They block the current thread until the time is up or the thread is completed. They are synchronous methods.

            // -------------------------------------- Asynchronous --------------------------------------

            // An Asynchronous method is a non-blocking method. It means that the method will return immediately, without waiting for the method to complete.
            // An Asynchronous operation can do moost or all of its work after returning to the caller.
            // An asynchronous operation does its work on a different thread than the caller.
            // An asynchronous operation does its work in the background, and notifies the caller when it is done.
            // An asynchronous method returns a Task or Task<T> object, which represents the ongoing work.

            // In UI applications, if you call an asynchronous method that takes a long time to complete, the UI will remain responsive, because the method is not blocking the UI thread.

            // Task are used to represent asynchronous operations. A Task object represents an ongoing work. It can be used to check the status of the work, wait for the work to complete, and get the result of the work.
            // Task.Run() is used to run a method on a different thread. It returns a Task object that represents the ongoing work.
            // Task.Delay() is used to pause the current thread for a specified amount of time. It returns a Task object that represents the ongoing work.
            // Task.Wait() is used to wait for a Task to complete. It blocks the current thread until the Task is completed.
            // Task.GetAwaiter().OnCompleted() is used to specify a continuation that will be executed when the Task is completed. It does not block the current thread.


            // -----------------------------------------------------------------------------------------

            ShowThreadInfo(Thread.CurrentThread, 38);

            CallSynchronous();                              // This will block the current thread for 4 seconds. It will not return until the 4 seconds are completed. 
            ShowThreadInfo(Thread.CurrentThread, 41);

            CallAsynchronous();                             // This will not block the current thread. It will return immediately and the task will be executed on a different thread. 
            ShowThreadInfo(Thread.CurrentThread, 44);

            Console.ReadKey();
        }

        static void CallSynchronous()
        {
            Thread.Sleep(4000);                             // This will block the current thread for 4 seconds. It will not return until the 4 seconds are completed.
            ShowThreadInfo(Thread.CurrentThread, 52);       // This will be executed on the same thread as the caller.

            // This is a synchronous method. It will block the current thread until the method is completed before moving to the next line because of the Thread.Sleep(4000).
            Task.Run(() => Console.WriteLine("+++++++++++++++++ Synchronous +++++++++++++++++")).Wait();   // This will block the current thread until the task is completed. 
        }

        static void CallAsynchronous()
        {
            ShowThreadInfo(Thread.CurrentThread, 60);       // This will be executed on the same thread as the caller. 

            // This is an asynchronous method. It will not block the current thread. It will return immediately and the task will be executed on a different thread.
            // After 4 seconds, the task will be completed and the continuation will be executed on the same thread.
            Task.Delay(4000).GetAwaiter().OnCompleted(() =>
            {
                ShowThreadInfo(Thread.CurrentThread, 66);
                Console.WriteLine("+++++++++++++++++ Asynchronous +++++++++++++++++");
            });
        }

        private static void ShowThreadInfo(Thread th, int line)
        {
            Console.WriteLine($"Line#: {line}, TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
        }

        private static void ShowThreadInfo(Thread th)
        {
            Console.WriteLine($"TID: {th.ManagedThreadId}, Pooled: {th.IsThreadPoolThread}, Background: {th.IsBackground}");
        }
    }
}
