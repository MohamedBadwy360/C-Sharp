namespace _14_OOP_Finalizer
{
    class Person
    {
        public string Name { get; set; }

        // Constructor of the class is called when the object of the class is created and memory is allocated for the object.
        public Person()
        {
            Console.WriteLine("This is person constructor");
        }

        // Destructor of the class is called when the object of the class is destroyed and memory is deallocated for the object.
        // Object is destroyed when the program ends or when the object is no longer needed or when the object is explicitly destroyed or when the object goes out of scope or when the object is set to null.
        ~Person()
        {
            Console.WriteLine("This is person destructor");
        }

    }
}
