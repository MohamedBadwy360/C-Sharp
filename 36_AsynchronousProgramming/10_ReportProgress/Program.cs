namespace _10_ReportProgress
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // ReportProgress is a method that allows you to report progress to the user.
            // It is used in conjunction with the BackgroundWorker class.
            // The BackgroundWorker class is used to run an operation on a separate, dedicated thread.
            // This is useful when you want to run an operation that might take a long time to complete.
            // The BackgroundWorker class allows you to run the operation on a separate thread so that the UI remains responsive.
            // The ReportProgress method is used to report progress to the user.
            // You can call the ReportProgress method from the DoWork event handler to report progress to the user.
            // The ReportProgress method takes two arguments: an integer value that represents the percentage of the operation that has been completed, and an optional object that represents any additional information that you want to report to the user.
            // The ReportProgress method raises the ProgressChanged event, which you can handle to update the user interface with the progress information.
            // The ProgressChanged event handler runs on the same thread as the user interface, so you can update the user interface from the ProgressChanged event handler.
            // The ProgressChanged event handler takes two arguments: an object that represents the sender of the event, and an object that represents the progress information that was reported by the ReportProgress method.
            // The ProgressChanged event handler is called on the same thread as the user interface, so you can update the user interface from the ProgressChanged event handler.

            // ReportProgress give us the ability to pass an action to the ReportProgress method and execute it on a basis of the progress percentage.
            // This is useful when you want to update the UI with the progress percentage.
            // The action is executed on the same thread as the user interface, so you can update the user interface from the action.

            // --------------------------------------------------------------------------------------

            // Action delegate to make the progress.
            Action<int> progress = (percent) =>
            {
                Console.Clear();
                Console.WriteLine($"Progress: {percent}%");
            };

            await Copy(progress);       // Passing an action to the Copy method to execute it on a basis of the progress percentage.


            Console.ReadKey();
        }

        // Passing an action to the Copy method to execute it on a basis of the progress percentage.
        static Task Copy(Action<int> onProgressPercentChanged)
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Task.Delay(50).Wait();
                    if (i % 10 == 0)
                    {
                        onProgressPercentChanged(i);
                    }
                }
            });
        }
    }
}
