namespace _17_Struct
{
    // The readonly modifier on the struct ensures that all instance fields of the struct must be immutable. This means that after an instance of the Age struct is created, its state cannot be changed.
    // Readonly Struct => immutable struct
    readonly struct Age
    {
        // Best practice to not chnage the value of fields in struct so declare it as readonly
        public readonly int Years;

        public Age(int years)
        {
            this.Years = years;
        }
    }
}
