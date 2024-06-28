namespace _20_Interface
{
    interface IMove
    {
        void Move();

        // Default implementation of method (C# 8.0)
        void Turn()
        {
            Console.WriteLine("Turning......");
        }
    }
}
