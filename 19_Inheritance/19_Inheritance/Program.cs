namespace _19_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance is a technique which allows one class to inherit the members of another class.
            // Inheritance is a mechanism of code reuse and it allows us to create a new class that is based on an existing class.
            // The new class is called derived (or child) class and the existing class is called the base (or parent) class.
            // The derived class inherits all the members (fields, methods, properties, and events) of the base class.
            // The derived class can also add new members to itself.
            // The derived class can also modify the behavior of the base class members using method overriding.
            // Inheritance is a key feature of object-oriented programming.
            // Inheritance is a way to implement the IS-A relationship between objects.
            // Inheritance is a technique which let a type acquire all properties and behavior of its parent type automatically.

            // Why use inheritance? 
            // 1. Code Reusability: Inheritance allows us to reuse the code defined in the base class.
            // 2. Maintenance: If we need to add a new method or property to all the classes in the hierarchy, we can add it to the base class and it will
            // 3. Extensibility: Inheritance allows us to create a new class that can extend the functionality of an existing class.
            // 4. Method Overriding: Inheritance allows us to override the behavior of the base class members.
            // 5. Polymorphism: Inheritance allows us to treat a derived class as a base class which is useful for creating polymorphic objects.

            // A class can inherit from only one class in C#.

            Eagle eagle = new Eagle();
            eagle.Move();
            eagle.Fly();


            // --------------------------------------------------------------


            // Upcasting and Downcasting in C#

            // Upcasting: Upcasting is the process of converting a derived class reference to a base class reference.
            // Upcasting is done implicitly by the compiler.
            // Upcasting is useful when we want to treat a derived class object as a base class object.
            // Upcasting is used to create polymorphic objects.
            Console.WriteLine("------------------------");

            //Animal animal = new Eagle();      // will work, because Eagle is derived from Animal class
            var eagle2 = new Eagle();
            Animal animal = eagle2;     // will see only Animal class methods and properties and not Eagle class methods and properties
            animal.Move();              // can see only Animal class methods and properties and not Eagle class methods and properties


            // Downcasting: Downcasting is the process of converting a base class reference to a derived class reference.
            // Downcasting is done explicitly by the programmer.
            // Downcasting is used when we want to treat a base class object as a derived class object.
            // Downcasting is used to access the members of the derived class.
            Eagle e = (Eagle)animal;
            e.Fly();                    // can see Eagle class methods and properties
            e.Move();                   // can see Animal class methods and properties

            // --------------------------------------------------------------
            Console.WriteLine("------------------------");

            Eagle eagle3 = new Eagle();
            Animal AbstractAnimal = eagle3;
            // Falcon falcon = (Falcon)AbstractAnimal;    // will throw InvalidCastException at runtime because AbstractAnimal is of type Eagle and not Falcon

            // To avoid InvalidCastException, we can use the as operator, is operator, or pattern matching in C#.
            Falcon falcon = AbstractAnimal as Falcon;  // will not throw exception, will return null if conversion is not possible and will not throw exception at runtime
            if (falcon != null)
            {
                falcon.Hunt();
            }
            else
            {
                Console.WriteLine("Conversion is not possible");
            }

            // We can also use pattern matching to avoid InvalidCastException. Pattern matching is a feature of C# 7.0. 
            if (AbstractAnimal is Falcon)
            {
                Falcon falcon3 = (Falcon)AbstractAnimal;
                falcon3.Hunt();
            }
            else
            {
                Console.WriteLine("Conversion is not possible");
            }

            // Another way to avoid InvalidCastException is to use the is operator. The is operator checks whether the given object is compatible with a given type.
            if (AbstractAnimal is Falcon falcon2)
            {
                falcon2.Hunt();
            }
            else
            {
                Console.WriteLine("Conversion is not possible");
            }


            // --------------------------------------------------------------

            // Abstract Class in C# 

            Console.WriteLine("------------------------");

            //AbstractAnimal AbstractAnimal_1 = new AbstractAnimal();  // will not work because AbstractAnimal is an abstract class and cannot be instantiated

            Eagle2 eagle2_1 = new Eagle2();     // will work because Eagle2 is derived from AbstractAnimal class and not AbstractAnimal class itself is instantiated here 


            // --------------------------------------------------------------

            // Sealed Class in C#

            SealedAnimal animal3_1 = new SealedAnimal();  // will work because Animal3 is a sealed class and can be instantiated directly without any derived class 


            // --------------------------------------------------------------

            // Polymorphism in C#

            // Polymorphism is a key feature of object-oriented programming. Polymorphism allows us to treat a derived class object as a base class object.
            // Polymorphism is a Greek word that means "many-shaped" and it allows us to create a single interface and have multiple implementations.
            // Polymorphism is a technique which allows us to create a single interface and have multiple implementations.
            // Polymorphism is a way to perform a single action in different ways.
            // Polymorphism is a way to implement the same method in different ways in the derived classes.
            // Polymorphism is a way to perform a single action in different ways in the derived classes.

            // The method in base class should be marked as virtual and the method in derived class should be marked as override.
            // The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
            // The override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.

            Console.WriteLine("-------------------------------");

            Eagle eagle1 = new Eagle();
            eagle1.Move();      // will call Move() method of Eagle class because it is overridden in Eagle class and not in Animal class 

            Eagle2 eagle2_2 = new Eagle2();
            eagle2_2.Move();    // will call Move() method of Eagle2 class because it is overridden in Eagle2 class and not in AbstractAnimal class

            // Difference between virtual and abstract methods in C#
            // 1. The virtual method has a body and the abstract method does not have a body.
            // 2. The virtual method is implemented in the base class and it can be overridden in the derived class.
            // 3. The abstract method is implemented in the derived class using the override keyword.
            // 4. The virtual method is used to provide a default implementation of a method in the base class.
            // 5. The abstract method is used to provide a specific implementation of a method in the derived class.
            // 6. The virtual method is used to allow the derived class to override the method. 
            // 7. The abstract method is used to force the derived class to override the method.
            // 9. The abstract method represents a contract between the base class and the derived class. The derived class must implement all the abstract members of the abstract class.
            // 10. The virtual method does not represent a contract between the base class and the derived class. The derived class may or may not override the virtual method.


            // -------------------------------------------------------------

            // Object class => the ultimate base class of all classes in .net

            Console.WriteLine("------------------------------");

            Animal animal1 = new Animal() { Name = "Lion" };
            Console.WriteLine(animal1);

            Console.WriteLine(typeof(Animal));
            Console.WriteLine(animal1.GetType());


            // --------------------------------------------------------------

            SubClass subClass = new SubClass(123);

            // --------------------------------------------------------------

            // Hiding/Shadowing Base Class Members in C#

            // To hide a base class member in the derived class, we can use the new keyword.
            // The new keyword is used to hide a base class member in the derived class.

            SubClass subClass1 = new SubClass();
            Console.WriteLine(subClass1.X);
        }
    }

    // How to implement inheritance in C#?
    // In C#, inheritance is implemented using the colon (:) symbol. The derived class follows the base class in the class declaration
    // and the colon is used to specify the base class. The following is the syntax of inheritance in C#.
    // class DerivedClass : BaseClass
    // {
    //     // Derived class members
    // }

    class Animal
    {
        public string Name { get; set; }
        // The Move() method is a virtual method. The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        // The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to be overridden in a derived class.
        public virtual void Move()
        {
            Console.WriteLine("Moving");
        }

        public override string ToString()
        {
            // Default Textual Representation
            //return base.ToString();

            return $"Animal: {Name}";
        }
    }

    // The Eagle class is derived from the Animal class using the colon (:) symbol.
    // The Eagle class inherits the Move() method from the Animal class.
    // The Eagle class can also add new members to itself.
    // The derived class can see all the members of the base class(protected, public, and internal members) except private members.
    class Eagle : Animal
    {
        // Overriding is a technique which allows a derived class to provide a specific implementation of a method that is already provided by its base class.
        // The override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        public override void Move()
        {
            // base keyword is used to access the members of the base class from the derived class.
            base.Move();
            Console.WriteLine("\t=>Moving the Eagle");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }

    class Falcon : Animal
    {
        public void Hunt()
        {
            Console.WriteLine("Hunting");
        }
    }

    // An abstract class is a class that cannot be instantiated. An abstract class is created using the abstract keyword.
    // An abstract class can have abstract methods, abstract properties, and abstract events.
    // An abstract method is a method that is declared in an abstract class using the abstract keyword and it does not have a body.
    // An abstract method is implemented in the derived class using the override keyword.
    // An abstract class can also have non-abstract methods, properties, and events.
    // An abstract class can have a constructor and it can be used to initialize the fields of the abstract class.
    // An abstract class can have fields, properties, and methods.
    // An abstract class can have static members.
    // An abstract class can have access modifiers.
    // An abstract class can have a static constructor.
    // An abstract class can have a destructor.
    // An abstract class can have constants, fields, constructors, destructors, properties, indexers, events, operators, and methods.
    abstract public class AbstractAnimal
    {
        // An abstract method is a method that is declared in an abstract class using the abstract keyword and it does not have a body.
        // An abstract method is implemented in the derived class using the override keyword.
        public abstract void Move();
    }

    // The derived class must implement all the abstract members of the abstract class.
    // If the derived class does not implement all the abstract members of the abstract class, then the derived class must also be declared as abstract.
    public class Eagle2 : AbstractAnimal
    {
        // The Move() method is implemented in the derived class using the override keyword.
        // The override keyword is used to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        // sealed keyword is used to prevent a method from being overridden in the derived class
        public sealed override void Move()
        {
            Console.WriteLine("Eagle_2 is moving");
        }
    }

    public class AmericanEagle : Eagle2
    {
        // Cannot override the Move() method because it is sealed in the base class Eagle2
        //public override void Move()
        //{
        //    Console.WriteLine("AmericanEagle is moving");
        //}
    }

    // A sealed class is a class that cannot be inherited. A sealed class is created using the sealed keyword.
    // A sealed class cannot be used as a base class.
    // A sealed class cannot have derived classes.
    // A sealed class can have fields, properties, methods, and events.
    // A sealed class can have access modifiers.
    // A sealed class can have a static constructor.
    // A sealed class can have a destructor.
    // A sealed class can have constants, fields, constructors, destructors, properties, indexers, events, operators, and methods.
    sealed class SealedAnimal
    {

    }

    // The following code will not compile because a sealed class cannot be used as a base class.
    // class Eagle3 : Animal3
    // {
    // }

    public class BaseClass
    {
        public int X = 10;

        public BaseClass()
        {

        }

        public BaseClass(int x)
        {
            X = x;
        }
    }

    public class SubClass : BaseClass
    {
        // The base class constructor's are accessible to the derived class but aren't automatically inherited
        // Calling the base class constructor and passing value to it
        public SubClass(int x) : base(x)
        {

        }

        public SubClass()
        {

        }

        // This will hide the base class member X and will not override it 
        // To hide a base class member in the derived class, we can use the new keyword. 
        // The new keyword is used to hide a base class member in the derived class. 
        public new int X = 20;
    }
}
