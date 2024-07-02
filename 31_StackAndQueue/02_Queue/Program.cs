namespace _02_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue is a collection of objects that supports FIFO (First In First Out) semantics for adding and removing elements.
            // It is a generic collection, so you can store any type of objects in a Queue.
            // The Queue<T> class is a generic class and it is present in System.Collections.Generic namespace.
            // Queue stores the elements in the order in which they were added.
            // The Enqueue() method is used to add elements to the queue.
            // The Dequeue() method is used to remove and return the element at the beginning of the queue.
            // The Peek() method is used to return the element at the beginning of the queue without removing it.
            // The Contains() method is used to check whether a specific element is present in the queue.
            // The Clear() method is used to remove all elements from the queue.
            // The Count property is used to get the number of elements in the queue.
            // The ToArray() method is used to copy the elements of the queue to a new array.
            // The TrimExcess() method is used to set the capacity of the queue to the actual number of elements in the queue.
            // The GetEnumerator() method is used to iterate through the elements of the queue.
            // The Queue class provides a constructor that initializes an empty queue.
            // The Queue class provides a constructor that initializes a queue with the specified collection.
            // TryDequeue() method is used to remove and return the element at the beginning of the queue.
            // If the queue is empty, it returns false.
            // TryPeek() method is used to return the element at the beginning of the queue without removing it.
            // If the queue is empty, it returns false.


            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("documentation.docs", 1));
            printingJobs.Enqueue(new PrintingJob("presentation.ppt", 3));
            printingJobs.Enqueue(new PrintingJob("spreadsheet.xls", 2));
            printingJobs.Enqueue(new PrintingJob("report.xlsx", 1));
            printingJobs.Enqueue(new PrintingJob("image.jpg", 2));

            var rnd = new Random();
            Console.WriteLine($"Current quque count before while = {printingJobs.Count}");

            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                var job = printingJobs.Dequeue();
                Console.WriteLine($"Printing ..... {job}");
                Thread.Sleep(rnd.Next(1000, 5000));
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Current quque count after while = {printingJobs.Count}");

            Queue<int> queue = new Queue<int>();

            //Console.WriteLine(queue.Peek());                // Throws InvalidOperationException
            if (queue.TryPeek(out int result))                  // Returns false
            {
                Console.WriteLine(result);
            }
        }
    }

    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} X #{_copies} copies";
        }
    }
}
