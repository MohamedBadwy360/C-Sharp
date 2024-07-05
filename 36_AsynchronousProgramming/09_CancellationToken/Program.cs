namespace _09_CancellationToken
{
    internal class Program
    {
        // async Task Main is available from C# 7.1
        // async Task Main is used to make the Main method asynchronous.
        // async Task Main is used to call asynchronous methods.
        static async Task Main(string[] args)
        {
            // CancellationToken provide the ability to cancel an operation and notify the operation that it should be canceled to save resources.
            // CancellationToken is used to cancel an operation that is in progress.

            // CancellationToken is a struct that is used to cancel an operation.
            // Cancellation token is passed to the method that is performing the operation.
            // The method checks the cancellation token and if it is cancelled, it stops the operation.

            // CancellationTokenSource is used to create a CancellationToken.
            // CancellationTokenSource is used to provide the infrastructure to cancel the operation.
            // CancellationTokenSource is used to provide a token to the method that is performing the operation.

            // CacncellationToken cancel the request all the way from the caller to the callee (bottom to top).

            // CancellationTokenSource class:
            // 1. CancellationTokenSource is used to create a CancellationToken.
            // 2. CancellationTokenSource is used to provide the infrastructure to cancel the operation.
            // 3. CancellationTokenSource is used to provide a token to the method that is performing the operation.
            // 4. CancellationTokenSource is used to cancel the operation.

            // CancellationTokenSource class methods:
            // 1. Cancel() - This method is used to cancel the operation.
            // 2. CancelAfter() - This method is used to cancel the operation after a specified time.
            // 3. Dispose() - This method is used to release all the resources used by the CancellationTokenSource object.

            // CancellationTokenSource class properties:
            // 1. Token - This property is used to get the CancellationToken object.

            // CancellationToken struct:
            // 1. CancellationToken is used to cancel the operation.
            // 2. CancellationToken is passed to the method that is performing the operation.
            // 3. The method checks the cancellation token and if it is cancelled, it stops the operation.

            // CancellationToken struct methods:
            // 1. ThrowIfCancellationRequested() - This method is used to throw an exception if the operation is cancelled.

            // CancellationToken clastructss properties:
            // 1. CanBeCanceled - This property is used to check if the operation can be cancelled.
            // 2. IsCancellationRequested - This property is used to check if the operation is cancelled.


            // --------------------------------------------------------------------------------------------

            // Create a CancellationTokenSource object to cancel the operation 
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            //await Check01(cancellationTokenSource);
            //await Check02(cancellationTokenSource);
            await Check03(cancellationTokenSource);

            Console.ReadKey();
        }

        static async Task Check01(CancellationTokenSource cancellationTokenSource)
        {
            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cancellationTokenSource.Cancel();           // Cancel the operation if the user presses 'Q'
                    Console.WriteLine("Task has been cancelled !!!");
                }
            });

            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                Console.Write("Checking ...");
                await Task.Delay(4000);                         // will check every 4 seconds if the operation is cancelled or not,. will wait for 4 seconds after cancellation to complete the operation.
                Console.Write($" Completed on {DateTime.Now}");
                Console.WriteLine();
            }

            Console.WriteLine("Check was Terminated");

            cancellationTokenSource.Dispose();          // Dispose the CancellationTokenSource object after the operation is completed because it implements IDisposable
        }

        static async Task Check02(CancellationTokenSource cancellationTokenSource)
        {
            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cancellationTokenSource.Cancel();           // Cancel the operation if the user presses 'Q'
                    Console.WriteLine("Task has been cancelled !!!");
                }
            });

            while (true)
            {
                Console.Write("Checking ...");

                // pass the CancellationToken to the Task.Delay method to check if the operation is cancelled or not. 
                // If cancelled, it will throw an exception and the operation will be stopped.
                await Task.Delay(4000, cancellationTokenSource.Token);
                Console.Write($" Completed on {DateTime.Now}");
                Console.WriteLine();
            }

            //Console.WriteLine("Check was Terminated");

            //cancellationTokenSource.Dispose();          // Dispose the CancellationTokenSource object after the operation is completed because it implements IDisposable
        }

        static async Task Check03(CancellationTokenSource cancellationTokenSource)
        {
            Task.Run(() =>
            {
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Q)
                {
                    cancellationTokenSource.Cancel();           // Cancel the operation if the user presses 'Q'
                    Console.WriteLine("Task has been cancelled !!!");
                }
            });

            try
            {
                while (true)
                {
                    cancellationTokenSource.Token.ThrowIfCancellationRequested();       // Check if the operation is cancelled or not. If cancelled, it will throw an exception and the operation will be stopped.

                    Console.Write("Checking ...");
                    await Task.Delay(4000);
                    Console.Write($" Completed on {DateTime.Now}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}");
            }

            Console.WriteLine("Check was Terminated");

            cancellationTokenSource.Dispose();          // Dispose the CancellationTokenSource object after the operation is completed because it implements IDisposable
        }
    }
}
