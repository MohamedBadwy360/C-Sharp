namespace _01_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linked list is a data structure that consists of nodes, where each node contains a value and a reference to the next node in the sequence.
            // The first node is called the head and the last node is called the tail.
            // Linked list is a dynamic data structure, which means that it can grow or shrink in size during the execution of the program.
            // Linked list is a good choice when you don't know the size of the list in advance or when you need to insert or remove elements frequently.
            // The main disadvantage of linked list is that it doesn't provide random access to elements, which means that you can't access an element by its index.
            // The time complexity of accessing an element in a linked list is O(n), where n is the number of elements in the list.
            // The time complexity of inserting or removing an element at the beginning of the list is O(1).
            // The time complexity of inserting or removing an element at the end of the list is O(n).
            // The time complexity of inserting or removing an element in the middle of the list is O(n).
            // There are several types of linked lists, such as singly linked list, doubly linked list, and circular linked list.
            // In a singly linked list, each node contains a value and a reference to the next node.
            // In a doubly linked list, each node contains a value, a reference to the next node, and a reference to the previous node.
            // In a circular linked list, the last node points back to the first node, forming a circle.
            // In this section, we will implement a singly linked list in C#.
            // LinkedList<T> class represents a singly linked list.

            // LinkedList has two public constructors: LinkedList() and LinkedList(IEnumerable<T> collection).

            // LinkedList<T> class provides the following properties and methods:
            // - Count: Gets the number of elements in the list.
            // - IsEmpty: Gets a value that indicates whether the list is empty.
            // - Head: Gets the first node in the list.
            // - Tail: Gets the last node in the list.
            // - First: Gets the first node in the list.
            // - Last: Gets the last node in the list.
            // - Current: Gets the current node in the list.
            // - Next: Gets the next node in the list.
            // - Value: Gets the value of the current node.
            // - AddFirst(T value): Adds a new node with the specified value at the beginning of the list.
            // - AddLast(T value): Adds a new node with the specified value at the end of the list.
            // - RemoveFirst(): Removes the first node from the list.
            // - RemoveLast(): Removes the last node from the list.
            // - ForEach(Action<T> action): Performs the specified action on each element in the list.
            // - GetEnumerator(): Returns an enumerator that iterates through the list.
            // - AddAfter(Node<T> node, T value): Adds a new node with the specified value after the specified node.
            // - AddAfter(Node<T> node, Node<T> newNode): Adds the specified node after the specified node.
            // - AddBefore(Node<T> node, T value): Adds a new node with the specified value before the specified node.
            // - AddBefore(Node<T> node, Node<T> newNode): Adds the specified node before the specified node.
            // - Remove(Node<T> node): Removes the specified node from the list.
            // - Clear(): Removes all nodes from the list.


            YTVideo lesson1 = new YTVideo { Id = "YTV1", Title = "Varibles", Duration = new TimeSpan(00, 30, 00) };
            YTVideo lesson2 = new YTVideo { Id = "YTV2", Title = "Operators", Duration = new TimeSpan(00, 45, 00) };
            YTVideo lesson3 = new YTVideo { Id = "YTV3", Title = "Control Structures", Duration = new TimeSpan(01, 00, 00) };
            YTVideo lesson4 = new YTVideo { Id = "YTV4", Title = "Arrays", Duration = new TimeSpan(00, 45, 00) };
            YTVideo lesson5 = new YTVideo { Id = "YTV5", Title = "Methods", Duration = new TimeSpan(01, 30, 00) };

            //LinkedList<YTVideo> playlist = new LinkedList<YTVideo>(new YTVideo[]
            //{
            //    lesson1, lesson2, lesson3, lesson4, lesson5
            //});

            LinkedList<YTVideo> playlist = new LinkedList<YTVideo>();

            playlist.AddFirst(lesson1);
            playlist.AddAfter(playlist.First, lesson2);
            //playlist.AddAfter(playlist.First.Next, lesson3);
            var node3 = new LinkedListNode<YTVideo>(lesson3);
            playlist.AddAfter(playlist.First.Next, node3);
            playlist.AddBefore(playlist.Last, lesson4);
            playlist.AddLast(lesson5);

            Print("C# Programming", playlist);



            Console.ReadLine();
        }

        static void Print(string title, LinkedList<YTVideo> playlist)
        {
            Console.WriteLine($"┌ {title}");
            foreach (var vedio in playlist)
            {
                Console.WriteLine(vedio);
            }
            Console.WriteLine("└");
            Console.WriteLine($"total = {playlist.Count} item(s).");
        }
    }

    class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return $"├── {Title} ({Duration})\n│\thttps://www.youtube.com/watch?v={Id}";
        }
    }


    // Node class represents a node in a singly linked list.
    //public class Node<T>
    //{
    //    public T Value { get; set; }
    //    public Node<T> Next { get; set; }

    //    public Node(T value)
    //    {
    //        Value = value;
    //        Next = null;
    //    }
    //}

    // LinkedList class represents a singly linked list.
    //public class LinkedList<T>
    //{
    //    private Node<T> _head;
    //    private Node<T> _tail;
    //    private int _count;
    //    public int Count => _count;
    //    public bool IsEmpty => _count == 0;
    //    public Node<T> Head => _head;
    //    public Node<T> Tail => _tail;
    //    public LinkedList()
    //    {
    //        _head = null;
    //        _tail = null;
    //        _count = 0;
    //    }
    //    public void AddFirst(T value)
    //    {
    //        Node<T> node = new Node<T>(value);
    //        if (IsEmpty)
    //        {
    //            _head = node;
    //            _tail = node;
    //        }
    //        else
    //        {
    //            node.Next = _head;
    //            _head = node;
    //        }
    //        _count++;
    //    }
    //    public void AddLast(T value)
    //    {
    //        Node<T> node = new Node<T>(value);
    //        if (IsEmpty)
    //        {
    //            _head = node;
    //            _tail = node;
    //        }
    //        else
    //        {
    //            _tail.Next = node;
    //            _tail = node;
    //        }
    //        _count++;
    //    }
    //    public void RemoveFirst()
    //    {
    //        if (IsEmpty)
    //        {
    //            throw new InvalidOperationException("The list is empty.");
    //        }
    //        _head = _head.Next;
    //        _count--;
    //        if (IsEmpty)
    //        {
    //            _tail = null;
    //        }
    //    }
    //    public void RemoveLast()
    //    {
    //        if (IsEmpty)
    //        {
    //            throw new InvalidOperationException("The list is empty.");
    //        }
    //        if (_head == _tail)
    //        {
    //            _head = null;
    //            _tail = null;
    //        }
    //        else
    //        {
    //            Node<T> current = _head;
    //            while (current.Next != _tail)
    //            {
    //                current = current.Next;
    //            }
    //            current.Next = null;
    //            _tail = current;
    //        }
    //        _count--;
    //    }
    //    public void ForEach(Action<T> action)
    //    {
    //        Node<T> current = _head;
    //        while (current != null)
    //        {
    //            action(current.Value);
    //            current = current.Next;
    //        }
    //    }
    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        Node<T> current = _head;
    //        while (current != null)
    //        {
    //            yield return current.Value;
    //            current = current.Next;
    //        }
    //    }
    //}
}
