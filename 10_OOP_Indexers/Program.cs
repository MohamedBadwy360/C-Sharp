namespace _10_OOP_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IP ip = new IP(192, 168, 1, 1);
            //Console.WriteLine(ip);
            //Console.WriteLine($"Segment1: {ip[0]}");

            byte[,] inputs = new byte[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            Sudoko sudoko = new Sudoko(inputs);
            Console.WriteLine(inputs[2, 1]);
            sudoko[2, 1] = 100;
            Console.WriteLine(inputs[2, 1]);
        }
    }
}
