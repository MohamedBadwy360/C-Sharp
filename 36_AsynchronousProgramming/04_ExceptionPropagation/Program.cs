namespace _04_ExceptionPropagation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An Exception propagates from method to method, up to call stack until it is caught.
            // In single threaded application, the exception is propagated to the caller method.
            // In multi-threaded application, the exception is propagated to the thread that created the thread.


            // Try-catch is to catch the exception in the same method where it is thrown.

            // When you use thread to run a method, you can't catch the exception in the main thread.
            // Because the exception is thrown in the thread, not in the main thread.
            // The thread call the method that returns the exception, and the exception is thrown in the thread not in the main thread.
            // So, you can't catch the exception in the main thread.

            // if you want to catch the exception in the thread, you should implement the try-catch in the thread method not in the main thread that calls the thread method / start the thread.

            // If you want to propagate the exception to the main thread, in threads it's difficult to propagate the exception to the main thread.

            // You should use task instead of thread, because task has a better exception handling than thread.
            // Task has a better exception handling than thread, because task has a better exception handling mechanism.
            // Task propagate the exception to the caller method, so you can catch the exception in the caller method.

            // ------------------------------------------------------------------------------------------

            // Single threaded application

            //try
            //{
            //    ThrowException();
            //}
            //catch (Exception e)
            //{
            //    // Handle the exception
            //    Console.WriteLine("Exception is thrown !!!");
            //}

            // ------------------------------------------------------------------------------------------

            // this will throw an exception and the exception won't be handled in the try catch because the exception is throw in the t1 thread not the main thread.

            //try
            //{
            //    Thread t1 = new Thread(() => ThrowException());
            //    t1.Start();
            //    t1.Join();
            //}
            //catch (Exception e)
            //{
            //    // Handle the exception
            //    Console.WriteLine("Exception is thrown !!!");
            //}

            // ------------------------------------------------------------------------------------------

            // to catch the exception in the thread you should implement the try-catch in the thread method not in the main thread that calls the thread method / start the thread.
            // Exception is thrown in the thread, so you should catch the exception in the thread.
            // Exception is caught in the thread, so the exception won't be propagated to the main thread.

            //Thread t1 = new Thread(() => ThrowExceptionWithTryCatch());
            //t1.Start();
            //t1.Join();

            // ------------------------------------------------------------------------------------------

            // Using Task instead of Thread to catch the exception in the main thread.

            try
            {
                // Task can propagate the exception to the caller method, so you can catch the exception in the caller method.
                Task.Run(ThrowException).Wait();
            }
            catch
            {
                Console.WriteLine("Exception is thrown !!!");
            }

            Console.ReadKey();
        }

        static void ThrowException()
        {
            throw new NullReferenceException();
        }


        static void ThrowExceptionWithTryCatch()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch
            {
                Console.WriteLine("Exception is thrown !!!");
            }
        }
    }
}
