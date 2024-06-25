namespace _10_OOP_Indexers
{
    public class IP
    {
        public byte[] segments = new byte[4];

        public IP(byte segment1, byte segment2, byte segment3, byte segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        // Indexer - get and set values by index 
        public byte this[byte index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }

        public override string ToString()
        {
            return string.Join('.', segments);
        }
    }
}
