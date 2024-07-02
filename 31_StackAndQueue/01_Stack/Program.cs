namespace _01_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack is a collection of objects that works on the principle of Last In, First Out (LIFO).
            // It is used to store a collection of objects.
            // It is a generic collection, so it can store any type of data.
            // It is present in the System.Collections namespace.
            // It is a reference type.
            // Stack is a class that represents a stack data structure.
            // Stack stores the elements in the order in which they were added.
            // The last element added to the stack is the first element to be removed.
            // The stack class provides the Push() method to add elements to the stack and the Pop() method to remove elements from the stack.
            // The Peek() method is used to return the top element of the stack without removing it.
            // The Contains() method is used to check whether a specific element is present in the stack.
            // The Clear() method is used to remove all elements from the stack.
            // The Count property is used to get the number of elements in the stack.
            // The ToArray() method is used to copy the elements of the stack to a new array.
            // The TrimExcess() method is used to set the capacity of the stack to the actual number of elements in the stack.
            // The GetEnumerator() method is used to iterate through the elements of the stack.
            // The Stack class provides a constructor that initializes an empty stack.
            // The Stack class provides a constructor that initializes a stack with the specified collection.
            // The Stack class provides a constructor that initializes a stack with the specified capacity.

            Stack<Command> undo = new Stack<Command>();
            Stack<Command> redo = new Stack<Command>();

            string line;

            while (true)
            {
                Console.WriteLine("Enter a URL or type 'exit' to quit:");
                line = Console.ReadLine().ToLower();

                if (line == "exit")
                {
                    break;
                }
                else if (line == "back")
                {
                    if (undo.Count > 0)
                    {
                        var url = undo.Pop();
                        redo.Push(url);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line == "forward")
                {
                    if (redo.Count > 0)
                    {
                        var url = redo.Pop();
                        undo.Push(url);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    // Add the URL to the stack
                    undo.Push(new Command(line));
                }

                // Clear the console 
                Console.Clear();

                Print("back", undo);
                Console.WriteLine("---------------------------------");
                Print("forward", redo);
            }

            //Stack<int> numbers = new Stack<int>(new List<int> { 1, 2, 3 });

            //while (numbers.Count > 0)
            //{
            //    var n = numbers.Peek();
            //    Console.WriteLine(n);
            //}

        }

        public static void Print(string name, Stack<Command> stack)
        {
            Console.WriteLine($"{name} history");
            Console.WriteLine("---------------");
            Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;

            foreach (var item in stack)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    class Command
    {
        private readonly DateTime _createdAt;
        private readonly string _url;

        public Command(string url)
        {
            _createdAt = DateTime.Now;
            _url = url;
        }

        public override string ToString()
        {
            return $"[{_createdAt.ToString("yyyy-MM-dd hh:mm")}] - {_url}";
        }
    }
}
