namespace _17_Struct
{
    // Immutable struct is recommended
    struct DigitalSize
    {
        private long _bit;

        private const long BITS_IN_BIT = 1;
        private const long BITS_IN_BYTE = 8;
        private const long BITS_IN_KILOBYTE = 1024 * BITS_IN_BYTE;
        private const long BITS_IN_MEGABYTE = 1024 * BITS_IN_KILOBYTE;
        private const long BITS_IN_GIGABYTE = 1024 * BITS_IN_MEGABYTE;
        private const long BITS_IN_TERABYTE = 1024 * BITS_IN_GIGABYTE;

        public string Bit => $"{_bit:N0} Bit";
        public string Byte => $"{_bit / BITS_IN_BYTE:N0} Byte";
        public string KiloByte => $"{_bit / BITS_IN_KILOBYTE:N0} KB";
        public string MegaByte => $"{_bit / BITS_IN_MEGABYTE:N0} MB";
        public string GigaByte => $"{_bit / BITS_IN_GIGABYTE:N0} GB";
        public string TeraByte => $"{_bit / BITS_IN_TERABYTE:N0} TB";


        public DigitalSize(long initialValue)
        {
            _bit = initialValue;
        }

        // Whether fields in a struct are mutable or immutable depends on how you define them. It's often recommended to make structs immutable when possible to avoid unintended side effects and make the code easier to understand and maintain.
        // If you want to change the value of a field in a struct, you should create a new instance of the struct with the updated value, rather than modifying the existing instance.


        public DigitalSize AddBit(long bits)
        {
            return Add(bits, BITS_IN_BIT);
        }

        public DigitalSize AddByte(long bytes)
        {
            return Add(bytes * BITS_IN_BYTE, BITS_IN_BIT);
        }

        public DigitalSize AddKiloByte(long kiloBytes)
        {
            return Add(kiloBytes * BITS_IN_KILOBYTE, BITS_IN_BIT);
        }

        public DigitalSize AddMegaByte(long megaBytes)
        {
            return Add(megaBytes * BITS_IN_MEGABYTE, BITS_IN_BIT);
        }

        public DigitalSize AddGigaByte(long gigaBytes)
        {
            return Add(gigaBytes * BITS_IN_GIGABYTE, BITS_IN_BIT);
        }


        private DigitalSize Add(long bits, long scale)
        {
            return new DigitalSize(bits * scale);
        }
    }
}
