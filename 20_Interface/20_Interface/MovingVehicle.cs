namespace _20_Interface
{
    class MovingVehicle : IMove, IDisplace
    {
        // Explicitly implement the interface
        void IMove.Move()
        {
            Console.WriteLine("IMove.Move.....");
        }

        // Explicitly implement the interface 
        void IDisplace.Move()
        {
            Console.WriteLine("IDisplace.Move.....");
        }
    }
}
