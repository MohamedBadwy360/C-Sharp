namespace _20_Interface
{
    // Can inherit from a class(abstract/concrete) and implement an interface or multiple interfaces
    class Caterpillar : Vehicle, ILoader, IDrivable
    {
        public Caterpillar(string name, string model, int year) : base(name, model, year)
        {
        }

        public void Load()
        {
            Console.WriteLine("Loading......");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading......");
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
