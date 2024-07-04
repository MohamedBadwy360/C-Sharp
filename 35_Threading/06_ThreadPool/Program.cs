namespace _06_ThreadPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Threads are overhead for the operating system in terms of memory, time, and resources.

            // ThreadPool is a collection of threads that are available to perform work items on behalf of the application.
            // It is a way to reduce the number of threads that are created and destroyed.
            // It is a way to reuse threads that have already been created.
            // .NET Framework provides a managed thread pool of pre-created recyclable threads that are available to perform work items on behalf of the application.

            // Why use ThreadPool?
            // 1. It is a managed thread pool that is used to execute work items.
            // 2. It is a collection of threads that are available to perform work items on behalf of the application.
            // 3. It is a way to reduce the number of threads that are created and destroyed.
            // 4. It is a way to reuse threads that have already been created.
            // 5. It is a way to improve the performance of the application by reducing the overhead of creating and destroying threads and number of threads that are created and destroyed.
            // 6. It is a way to reduce the overhead of creating and destroying threads.


            // ThreadPool class: It is a static class that provides a managed thread pool of pre-created recyclable threads that are available to perform work items on behalf of the application.
            // ThreadPool.QueueUserWorkItem: It is a method that is used to queue a work item for execution on the thread pool.
            // ThreadPool.GetAvailableThreads: It is a method that is used to get the number of available threads in the thread pool.
            // ThreadPool.GetMaxThreads: It is a method that is used to get the maximum number of threads that can be created in the thread pool.
            // ThreadPool.GetMinThreads: It is a method that is used to get the minimum number of threads that can be created in the thread pool.
            // ThreadPool.SetMaxThreads: It is a method that is used to set the maximum number of threads that can be created in the thread pool.
            // ThreadPool.SetMinThreads: It is a method that is used to set the minimum number of threads that can be created in the thread pool.

            // Limitations of ThreadPool:
            // 1. Pooled thread can't be named.
            // 2. Always background threads.

            // ------------------------------------------------------------------------------------------

            // Task Class: It is a class that is used to represent asynchronous operations.
            // Task class uses the thread pool to execute the work item.
            // Task class is used to perform asynchronous operations.
            // Task class is used to perform parallel operations.
            // Task class is used to perform concurrent operations.
            // Task class is used to perform multi-threaded operations.

            // Task class methods:
            // 1. Task.Run: It is a method that is used to run a work item asynchronously on the thread pool.
            // 2. Task.Factory.StartNew: It is a method that is used to run a work item asynchronously on the thread pool.
            // 3. Task.Wait: It is a method that is used to wait for the task to complete.
            // 4. Task.WaitAll: It is a method that is used to wait for all the tasks to complete.
            // 5. Task.WaitAny: It is a method that is used to wait for any of the tasks to complete.
            // 6. Task.WhenAll: It is a method that is used to wait for all the tasks to complete.
            // 7. Task.WhenAny: It is a method that is used to wait for any of the tasks to complete.
            // 8. Task.ContinueWith: It is a method that is used to continue with the task after the task is completed.



            // ------------------------------------------------------------------------------------------

            // First way to use thread in ThreadPool 

            Console.WriteLine("Using Thread Pool\n");
            ThreadPool.QueueUserWorkItem(new WaitCallback(Print));          // Will use ThreadPool thread to execute the method Print

            // Second way to use thread in ThreadPool using Task class
            Console.WriteLine("----------------------------");
            Console.WriteLine("Using Task\n");
            Task.Run(Print);                    // Will use ThreadPool thread to execute the method Print

            Employee employee = new Employee { TotalHours = 40, Rate = 15 };
            ThreadPool.QueueUserWorkItem(new WaitCallback(CalculateSalary), employee);   // Will use ThreadPool thread to execute the method CalculateSalary
            Console.WriteLine(employee.TotalSalary);

            Console.ReadKey();
        }

        private static void CalculateSalary(object employee)
        {
            var emp = employee as Employee;
            if (employee is null)
                return;
            emp.TotalSalary = emp.TotalHours * emp.Rate;
            Console.WriteLine(emp.TotalSalary.ToString("C"));
        }

        private static void Print()
        {
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}, Thread Name: {Thread.CurrentThread.Name}");
            Console.WriteLine($"Is Pooled thread: {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Background: {Thread.CurrentThread.IsBackground}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Cycle {i + 1}");
            }
        }

        private static void Print(object state)
        {
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}, Thread Name: {Thread.CurrentThread.Name}");
            Console.WriteLine($"Is Pooled thread: {Thread.CurrentThread.IsThreadPoolThread}");
            Console.WriteLine($"Background: {Thread.CurrentThread.IsBackground}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Cycle {i + 1}");
            }
        }
    }

    class Employee
    {
        public decimal TotalHours { get; set; }
        public decimal Rate { get; set; }

        public decimal TotalSalary { get; set; }

    }
}
