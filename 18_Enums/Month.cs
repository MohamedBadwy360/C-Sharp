namespace _18_Enums
{
    // Enums is strongly typed named constants
    // Enums are value types
    // Enums are used to create our own data types
    // Enums are used to define a set of named constants and these constants are related to one thing/each other
    // Enums are used to group related values and make them more readable and maintainable
    // Enums take less memory and efficient
    // Default underlying type of enum is int
    // We can change the underlying type of enum by specifying the type after the enum keyword (byte, short, int, long)
    // This is simple enum
    enum Month : byte
    {
        // if we don't assign any value, it will start from 0
        // if we assign any value, it will start from that value
        // we can assign any value to any enum
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
