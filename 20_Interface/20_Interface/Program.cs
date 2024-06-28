namespace _20_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cannot reference an abstract type with a concrete type
            // Can reference a concrete type with an abstract type
            Vehicle v1 = new Honda("Honda", "Civic", 2020);     // Upcasting (Implicit)
            Honda v2 = new Honda("Honda", "Accord", 2020);     // No casting

            // Cannot create an instance of an abstract class
            // Vehicle v3 = new Vehicle();     // Error

            // Cannot create an instance of an interface
            // IVehicle v4 = new IVehicle();     // Error


            // Interface 
            // Interface is a contract that defines the properties, methods, and events that a class must implement.
            // Interface is a reference type
            // Interface can have only behaviors
            // Interface can implement/inherit multiple interfaces
            // Interface cannot have fields => can have properties / only behaviors
            // Interface cannot have constructors
            // Interface cannot have destructors
            // Interface cannot have static members
            // Interface cannot have instance members
            // Interface cannot have access modifiers
            // Interface can have default implementation of methods (C# 8.0)


            // Cannot create an instance of an interface
            // IVehicle v5 = new IVehicle();     // Error
            // Can reference a concrete type with an interface type 
            ILoader caterpillar = new Caterpillar("Caterpillar", "D6", 2020);   // will see only Load and Unload methods of ILoader 
            caterpillar.Load();
            caterpillar.Unload();

            IDrivable honda = new Honda("Honda", "Civic", 2020);   // will see only Move and Stop methods of IDrivable
            honda.Move();
            honda.Stop();


            IMove move = new MovingVehicle();   // will see only Move method of IMove
            move.Move();
            move.Turn();    // Default implementation of method (C# 8.0)

            IDisplace displace = new MovingVehicle();   // will see only Move method of IDisplace
            displace.Move();
        }
    }
}
