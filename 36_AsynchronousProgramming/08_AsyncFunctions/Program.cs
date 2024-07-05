namespace _08_AsyncFunctions
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Async Functions 
            // We can use async functions to make our code more responsive and efficient.
            // Async functions are used to perform long-running operations without blocking the main thread.
            // We can use the async keyword before the return type of a function to make it an async function.
            // We can use the await keyword before a function call inside an async function to wait for the function to complete.
            // We can use the Task class to run an async function and get the result using the GetAwaiter method.
            // We can use the OnCompleted method to get the result of an async function when it completes.

            // async keyword convert the function into object of Task class and inside it a state machine is created to handle the async operation and track the progress of this method.
            // await keyword is used to wait for the async operation to complete and then continue with the rest of the code.
            // Any non-blocking operation inside the async function should be awaited ( use await keyword before the function call).
            // When using await keyword, the control is returned to the caller of the async function and the function is executed in the background.
            // The async function returns a Task object which can be used to track the progress of the async function.
            // When using await keword before a non-blocking function, the result of the awaited function become a value of the Task object not a task object itself.

            // .Wait() => block the thread until the task is completed.
            // .Result => block the thread until the task is completed and return the result of the task.
            // await keyword => does not block the thread and return the control to the caller of the async function until the async function is completed.

            // async & await must be used together.
            // async keyword is used to make the function asynchronous.
            // await keyword is used to wait for the asynchronous operation to complete.

            // Task.Run() => used to run a function in a separate thread.
            // Task.Run() is used to run a function in a separate thread and return a Task object that can be used to track the progress of the function.



            // ------------------------------------------------------------------------------------

            // 1) Old way of calling async function
            //var task = Task.Run(() => ReadContent("https://www.youtube.com/playlist?list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l"));
            //var awaiter = task.GetAwaiter();
            //awaiter.OnCompleted(() =>
            //{
            //    Console.WriteLine(awaiter.GetResult());
            //});


            // 2) Using async and await keywords

            Console.WriteLine(await ReadContentAsync("https://www.youtube.com/playlist?list=PL4n1Qos4Tb6SWPbJNpiznp-Ok4A8J_23l"));

            Console.ReadKey();
        }

        static Task<string> ReadContent(string url)
        {
            var client = new HttpClient();
            return client.GetStringAsync(url);
        }

        // Task<string> means that the function will return a Task object that contains a string.
        // Task<string> is a promise that the function will return a string in the future.
        // The async keyword is used to make the function asynchronous.
        // The await keyword is used to wait for the GetStringAsync method to complete and return the result.
        // await return the control to the caller of the async function until the async function is completed.
        // The GetStringAsync method is an asynchronous method that returns a Task object.
        static async Task<string> ReadContentAsync(string url)
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync(url);
            return content;
        }
    }
}
