namespace _11_TaskCombinator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // How to combine tasks in C#? (Task.WhenAll, Task.WhenAny, Task.ContinueWith, Task.Factory.ContinueWhenAll, Task.Factory.ContinueWhenAny)

            // Combinator pattern is a design pattern that allows for the combination of multiple tasks into a single task.
            // This pattern is useful when you have multiple tasks that need to be executed in parallel or sequentially.

            // Combinator benfits:
            // - Simplifies the code by allowing you to combine multiple tasks into a single task.
            // - Provides a way to handle the completion of multiple tasks at once.
            // - Allows you to control the order in which tasks are executed.

            // Task.WhenAll - Combines multiple tasks into a single task that completes when all of the tasks have completed.
            // Task.WhenAny - Combines multiple tasks into a single task that completes when any of the tasks have completed.
            // Task.ContinueWith - Creates a continuation task that runs after the original task has completed.
            // Task.Factory.ContinueWhenAll - Creates a continuation task that runs after all of the specified tasks have completed.
            // Task.Factory.ContinueWhenAny - Creates a continuation task that runs after any of the specified tasks have completed.




            // ----------------------------------------------------------------------------------------

            var has4000ViewHours = Task.Run(() => Has4000ViewHours());
            var has1000Subscriber = Task.Run(() => Has1000Subscriber());

            // Task.WhenAll - Combines multiple tasks into a single task that completes when all of the tasks have completed.
            Console.WriteLine("Using Task.WhenAny()");
            Console.WriteLine("-------------------------");

            var any = await Task.WhenAny(has1000Subscriber, has4000ViewHours);
            Console.WriteLine(any.Result);

            Console.WriteLine("Using Task.WhenAll()");
            Console.WriteLine("-------------------------");

            var all = await Task.WhenAll(has1000Subscriber, has4000ViewHours);

            foreach (var taskResult in all)
            {
                Console.WriteLine(taskResult);
            }


            Console.ReadKey();
        }

        static Task<string> Has1000Subscriber()
        {
            Task.Delay(4000).Wait();
            return Task.FromResult("congratulation !! you have 1000 subscribers");
        }

        static Task<string> Has4000ViewHours()
        {
            Task.Delay(3000).Wait();
            return Task.FromResult("congratulation !! you have 4000 view hours");   // return a task that will complete after 3 seconds 
        }
    }
}
