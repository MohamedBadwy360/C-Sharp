namespace _02_TaskReturnsValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task class object properties:
            // 1. Id - Gets the unique ID of this Task instance.
            // 2. Status - Gets the task status.
            // 3. IsCompleted - Gets whether the task has completed.
            // 4. IsFaulted - Gets whether the task has thrown an exception.
            // 5. IsCanceled - Gets whether the task has been canceled.
            // 6. Exception - Gets the AggregateException that caused the Task to end prematurely.
            // 7. Result - Gets the result value of this Task<TResult>.
            // 8. AsyncState - Gets a user-defined object that qualifies or contains information about a task.
            // 9. CreationOptions - Gets the TaskCreationOptions used to create this task.
            // 10. AsyncState - Gets a user-defined object that qualifies or contains information about a task.
            // 11. Factory - Gets the TaskFactory that was used to create this Task instance.
            // 12. CancellationPending - Gets whether this Task is waiting for activation due to a call to the Task.WaitAll method.
            // 13. IsWaitNotificationEnabled - Gets whether this task instance will be notified of completion by a call to the Task.WaitAll method.
            // 14. CompletedTask - Returns a task that has already completed successfully.
            // 15. CurrentId - Gets the Task ID of the currently executing Task.


            // Task class object methods:
            // 1. Start() - Starts the Task.
            // 2. Wait() - Waits for the Task to complete execution.
            // 3. WaitAll() - Waits for all of the provided Task objects to complete execution.
            // 4. WaitAny() - Waits for any of the provided Task objects to complete execution.
            // 5. ContinueWith() - Creates a continuation that executes asynchronously when the target Task completes.
            // 6. Run() - Creates a Task that executes an action.
            // 7. Run<TResult>() - Creates a Task that executes an action and returns a value.
            // 8. FromResult() - Creates a Task that's completed successfully with the specified result.
            // 9. FromCanceled() - Creates a Task that's completed due to cancellation with the specified cancellation token.
            // 10. FromException() - Creates a Task that's completed due to an exception with the specified exception.
            // 11. WhenAll() - Creates a Task that will complete when all of the Task objects in an enumerable collection have completed.
            // 12. WhenAny() - Creates a Task that will complete when any of the Task objects in an enumerable collection have completed.
            // 13. Delay() - Creates a Task that completes after a time delay.
            // 14. WhenAll() - Creates a Task that will complete when all of the Task objects in an enumerable collection have completed.
            // 15. WhenAny() - Creates a Task that will complete when any of the Task objects in an enumerable collection have completed.
            // 16. Delay() - Creates a Task that completes after a time delay.
            // 17. RunSynchronously() - Runs the Task synchronously on the current TaskScheduler.
            // 18. ConfigureAwait() - Configures an awaiter used to await this Task.
            // 19. GetAwaiter() - Returns an awaiter used to await this Task.


            // GetResult() - Ends the wait for the completion of the task.


            // -------------------------------------------------------------------------------------------

            // Thread block: 
            // We mean by thread block that the main thread will wait for the task to finish its work before continuing the main thread work.
            // The main thread will be blocked until the task finishes its work.
            // (in general) We mean that the method(operation) that the thread calls, put or take, is blocking the thread from processing to execute to the next line of the code.

            // Task.Result => will block the main thread until the task finishes its work.

            // -------------------------------------------------------------------------------------------

            Task<DateTime> task = Task.Run(() => DateTime.Now);
            Console.WriteLine(task);        // will print the task object => Output: System.Threading.Tasks.Task`1[System.DateTime]

            // will block the main thread until the task finishes its work.
            Console.WriteLine(task.Result); // will print the task return value => Output: 10/10/2021 12:00:00 AM

            Console.WriteLine(task.GetAwaiter().GetResult());   // exactly the same as task.Result

            Console.ReadKey();
        }
    }
}
