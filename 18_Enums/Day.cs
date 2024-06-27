namespace _18_Enums
{
    // Flags Enum
    // Bitwise operations can be performed on the enum values (OR, AND, XOR, NOT) 
    // The enum values must be powers of 2
    // The enum must be decorated with the [Flags] attribute
    // The enum values must be combined with the bitwise OR operator (|) 
    // Values can be tested with the bitwise AND operator (&) 
    // Values can be removed with the bitwise XOR operator (^)
    // Values can be toggled with the bitwise NOT operator (~)
    // Values can contain multiple flags/values at the same time 
    // We use the flags enum when we want to store multiple values in a single variable
    // We use HasFlag() method to check if a flag is set
    [Flags]
    enum Day : byte
    {
        NONE = 0b_0000_0000,     // 0
        MONDAY = 0b_0000_0001,     // 1
        TUESDAY = 0b_0000_0010,     // 2
        WEDNESDAY = 0b_0000_0100,     // 4
        THURSDAY = 0b_0000_1000,     // 8
        FRIDAY = 0b_0001_0000,     // 16
        SATURDAY = 0b_0010_0000,     // 32
        SUNDAY = 0b_0100_0000,      // 64
        WEEKEND = SATURDAY | SUNDAY,    // 96 = 32 | 64 = 0b_0110_0000
        BUSINESS_DAY = MONDAY | TUESDAY | WEDNESDAY | THURSDAY | FRIDAY,    // 31 = 1 | 2 | 4 | 8 | 16 = 0b_0001_1111
    }
}
