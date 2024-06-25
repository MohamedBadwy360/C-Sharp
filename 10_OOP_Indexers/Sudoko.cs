namespace _10_OOP_Indexers
{
    public class Sudoko
    {
        private byte[,] _matrix;

        public Sudoko(byte[,] matrix)
        {
            _matrix = matrix;
        }

        public byte this[byte row, byte col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Index cannot be negative");
                }

                if (row >= _matrix.GetLength(0) || col >= _matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                return _matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Index cannot be negative");
                }

                if (row >= _matrix.GetLength(0) || col >= _matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }

                if (value < 1 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 9");
                }

                _matrix[row, col] = value;
            }
        }
    }
}
