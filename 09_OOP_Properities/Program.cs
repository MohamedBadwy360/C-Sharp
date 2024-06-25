namespace _09_OOP_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(100m);
            dollar.Amount = 200;    // set accessor is called to assign a new value
            Console.WriteLine(dollar.Amount);   // get accessor is called to return the value
            Console.WriteLine(dollar.IsZero);   // get accessor is called to return the value
            Console.WriteLine(dollar.IsZero_ExpressionBodied);   // get accessor is called to return the value
        }
    }
}
