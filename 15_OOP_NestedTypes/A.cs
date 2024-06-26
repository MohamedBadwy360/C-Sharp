namespace _15_OOP_NestedTypes
{
    // Containing Type
    class A
    {
        private int _x;
        // Nested Type is a type defined within another type.
        // Nested types can be public, private, protected, or internal.
        // Nested types doesn't pollute the global namespace.
        // Nested types can access private members of the containing type.
        // Nested types can be generic.

        // Nested Type
        // We use nested types when we want to encapsulate a type that is only used by the containing type. 
        class B
        {
            void SetX(int x)
            {
                A a = new A();
                a._x = x;       // Accessing private member of containing type.
            }
        }
    }
}
