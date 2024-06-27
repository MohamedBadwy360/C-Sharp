namespace _17_Struct
{
    struct Student
    {
        // From C# 10.0 struct can have parameterless constructor 
        // Before C# 10.0 struct can't have parameterless constructor
        // It's imlicitly found by default in struct
        //public Student()
        //{

        //}

        // Not allowed to have instance field initializers in struct
        // You can't initialize instance fields in struct like class
        // You should initialize fields in constructor
        //private int _id = 10;     // error
        private int _id;        // true


        //Struct Support Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Struct Support Methods
        // Struct Support Indexers
        // Struct Support Events
        // Struct Support Delegates
        // Struct Support Constructors
        // Struct Support Fields
        // Struct Support Constants
        // Struct Support Enums
        // Struct Support Interfaces
        // Struct Support Structs
        // Struct Support Classes
        // Struct Doesn't Support Inheritance => so doesn't support protected, virtual
        // Struct imlicitly inherit from System.ValueType and System.Object
        // Implicitly sealed => so doesn't support abstract, virtual, override, new, sealed
        // Struct Doesn't Support Finalizers
        // Struct Doesn't Support Field Initializers
        // Struct Doesn't Support Parameterless Constructor => From C# 10.0 struct can have parameterless constructor
        // Struct are immutable => so doesn't support ref, out, in => because ref, out, in are used to change value of variable
        // Struct are value type => so doesn't support null => because null is reference type


        // Best practices not use struct for large data => because struct is value type and stored in stack memory
        // Max size of struct is 16 bytes => if more than 16 bytes, it's better to use class => because class is reference type and stored in heap memory 
        // Not best practices to use reference type like string in struct => because struct is value type and stored in stack memory => so it's better to use value type in struct


        // Struct is value type and stored in stack memory => so it's better to use struct for small data and value type
        // Stack memory is faster than heap memory => because stack memory is stored in CPU and heap memory is stored in RAM
        // Stack memory is limited => 1MB => so it's better to use struct for small data and value type => because struct is stored in stack memory


        public void Show()
        {
            Console.WriteLine("I am a student");
        }

        public override string ToString()
        {
            return "I am a student";
        }

        //~Student()
        //{
        //    // Struct can't have destructor
        //}
    }
}
