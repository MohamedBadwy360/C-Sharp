using System.Diagnostics;

namespace _01_ProcessAndThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Modern applications need to deal with running different units out of order or at the same time simultaneously with out affecting the outcome result.
            // This is where the concept of process and thread comes in.
            // A process is a container for a set of resources used when executing a program.
            // A thread is a unit of execution within a process.
            // A process can have multiple threads.
            // A thread can be thought of as a lightweight process.
            // Threads share the same memory space and resources of the process that created them.
            // Threads are used to perform multiple tasks at the same time.
            // Threads are used to perform background tasks.
            // Threads are used to perform time-consuming tasks.
            // Threads are used to keep the UI responsive.
            // Threads are used to perform tasks that require waiting for a long time.

            // Any application runs in a process and take a process ID and a process can have multiple threads.
            // This process id is unique for each process and is used to identify the process.
            // The process id is a unique identifier for a process.
            // When a process is created, the operating system assigns a unique process id to the process.
            // and by design CLR creates a single thread to execute the code.
            // The single thread is to execute the code in the main method. 
            // This thread is called the main thread.
            // The main thread is the first thread that is created when an application starts.

            // Thread is the basic unit of execution in a process.
            // Thread is hte basic unit to which the operating system allocates processor time.
            // A thread can be in one of the following states:
            // 1. Unstarted: The thread is created but has not started yet.
            // 2. Running: The thread is currently running.
            // 3. Waiting: The thread is waiting for a resource or an event.
            // 4. Dead: The thread has completed execution.
            // The thread is in the running state when the operating system allocates processor time to the thread.
            // The thread is in the waiting state when the thread is waiting for a resource or an event.
            // The thread is in the dead state when the thread has completed execution.

            // in .NET an application starts with a single thread called the main thread.
            // The main thread is created when the application starts.

            // ---------------------------------------------------------------------------------------------

            // Process class:
            // The System.Diagnostics namespace provides the Process class to work with processes.
            // Process is used to deal with system processes.

            // The Process class provides the following properties to work with processes:
            // 1. Id: Gets the unique identifier for the process.
            // 2. ProcessName: Gets the name of the process.
            // 3. StartTime: Gets the time when the process started.
            // 4. Responding: Gets a value that indicates whether the user interface of the process is responding.
            // 5. HasExited: Gets a value that indicates whether the process has exited.
            // 6. MainWindowTitle: Gets the title of the main window of the process.
            // 7. BasePriority: Gets the base priority of the process.
            // 8. PriorityClass: Gets or sets the priority class of the process.
            // 9. ProcessorAffinity: Gets or sets the processors on which the threads in the process can run.
            // 10. Threads: Gets the collection of threads that are running in the process.
            // 11. StartInfo: Gets the start information of the process.
            // 12. StandardInput: Gets a stream used to write input to the process.
            // 13. StandardOutput: Gets a stream used to read the output from the process.
            // 14. StandardError: Gets a stream used to read the error output from the process.

            // The Process class provides the following methods to work with processes:
            // 1. Start: Starts a process resource by specifying the name of an application and a set of command-line arguments.
            // 2. WaitForExit: Instructs the Process component to wait indefinitely for the associated process to exit.
            // 3. Kill: Closes a process that has a user interface by sending a close message to its main window.
            // 4. Close: Frees all the resources that are associated with this component.
            // 5. GetProcesses: Gets all the processes that are running on the local computer.
            // 6. GetProcessById: Gets the process resources that are running on the local computer by specifying the process ID.
            // 7. GetCurrentProcess: Gets the current process.

            // The Process class provides the following events to work with processes:
            // 1. Exited: Occurs when a process exits.
            // 2. OutputDataReceived: Occurs when an application writes to its redirected StandardOutput stream.
            // 3. ErrorDataReceived: Occurs when an application writes to its redirected StandardError stream.

            // ---------------------------------------------------------------------------------------------

            // Thread class:
            // The System.Threading namespace provides the Thread class to work with threads.
            // Thread is used to deal with system threads.

            // The Thread class provides the following properties to work with threads:
            // 1. CurrentThread: Gets the currently running thread.
            // 2. CurrentCulture: Gets or sets the culture for the current thread.
            // 3. CurrentUICulture: Gets or sets the UI culture for the current thread.
            // 4. IsAlive: Gets a value indicating the execution status of the current thread.
            // 5. IsBackground: Gets or sets a value indicating whether or not a thread is a background thread.
            // 6. IsThreadPoolThread: Gets a value indicating whether or not a thread is a thread from the thread pool.
            // 7. ManagedThreadId: Gets a unique identifier for the current managed thread.
            // 8. Name: Gets or sets the name of the thread.
            // 9. Priority: Gets or sets the scheduling priority of a thread.
            // 10. ThreadState: Gets a value containing the states of the current thread.

            // The Thread class provides the following methods to work with threads:
            // 1. Start: Starts a thread.
            // 2. Sleep: Suspends the current thread for a specified time.
            // 3. Join: Blocks the calling thread until a thread terminates.
            // 4. Yield: Causes the calling thread to yield execution to another thread that is ready to run.
            // 5. Interrupt: Interrupts a thread that is in the WaitSleepJoin thread state.
            // 6. Abort: Raises a ThreadAbortException in the thread on which it is invoked, to begin the process of terminating the thread.
            // 7. ResetAbort: Cancels an Abort requested for the current thread.
            // 8. GetDomain: Gets the AppDomain in which the current thread is running.
            // 9. GetDomainID: Gets a unique application domain identifier.
            // 10. GetNamedDataSlot: Allocates a named data slot on all the threads in the current application domain.
            // 11. GetData: Retrieves the value from the specified slot on the current thread.
            // 12. SetData: Sets the data in the specified slot on the current thread.
            // 13. BeginCriticalRegion: Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.
            // 14. EndCriticalRegion: Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.
            // 15. GetProcessorId: Gets the unique identifier of the current processor.
            // 16. MemoryBarrier: Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that memory accesses prior to the call to MemoryBarrier execute after memory accesses that follow the call to MemoryBarrier.

            // The Thread class provides the following events to work with threads:
            // 1. ThreadStart: Occurs when a thread is started.
            // 2. ThreadException: Occurs when an unhandled exception is thrown in a thread.

            // ---------------------------------------------------------------------------------------------

            Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Thread I: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"PocressorId: {Thread.GetCurrentProcessorId()}");

            Console.ReadKey();
        }
    }
}
