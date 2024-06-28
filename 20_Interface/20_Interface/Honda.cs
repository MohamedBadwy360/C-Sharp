namespace _20_Interface
{
    // Concrete type
    class Honda : Vehicle, IDrivable
    {
        public Honda(string name, string model, int year) : base(name, model, year)
        {
        }

        public void Move()
        {
            Console.WriteLine("Moving......");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping......");
        }
    }
}
