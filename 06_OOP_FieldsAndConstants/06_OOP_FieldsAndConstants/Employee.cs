namespace _06_OOP_FieldsAndConstants
{
    // <class access-modifier> class <class-name> { class block }
    // <class access-modifier> class <class-name> : <base-class> { }
    // <class access-modifier> class <class-name> : <interface-name> { }
    // <class access-modifier> class <class-name> : <base-class>, <interface-name> { }
    // <class access-modifier> class <class-name> : <base-class>, <interface-name>, <interface-name> { }
    // <class access-modifier> class <class-name> : <base-class>, <interface-name>, <interface-name>, <interface-name> { }

    // <class access-modifier> => public, internal (default), private, protected, protected internal, private protected
    // public => Accessible from any other class
    // internal => Accessible only from the same assembly
    // private => Accessible only from the same class
    // protected => Accessible only from the same class and derived
    // protected internal => Only code in the same assembly or in a derived class in another assembly can access this type or member
    // private protected => Only code in the same assembly and in the same class or a derived class can access the type or member
    public class Employee
    {
        // Constants => A constant is a field that can't be changed after the object is created
        // Constants => <access modifier> const <data type> <field name> = <value>;
        // Constants => const <data type> <field name> = <value>; (default access modifier is private)
        // Constants are accessed through the class name, not through an object
        public const double TAX = 0.03;

        // Field => <access modifier> <data type> <field name> = <initial value>;
        // Field => <access modifier> <data type> <field name>;
        // Field => <data type> <field name> = <initial value>; (default access modifier is private)
        // Field => <data type> <field name>; (default access modifier is private)
        // Field => <access modifier> const <data type> <field name> = <initial value>;
        // Field => <access modifier> readonly <data type> <field name> = <initial value>;
        // Field => <data type> <field name> = <initial value>; (default access modifier is private)
        // Field => <data type> <field name>; (default access modifier is private)
        // Fields are accessed through an object of the class
        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;
    }
}
