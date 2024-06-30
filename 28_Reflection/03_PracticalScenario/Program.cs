namespace _03_PracticalScenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Suppose you have a game and those Enemies


            do
            {
                Console.Write("\n\nEnemy: ");
                var input = "_03_PracticalScenario." + Console.ReadLine();
                object obj = null;

                try
                {
                    var enemy = Activator.CreateInstance(typeof(Program).Assembly.GetName().Name, input);
                    obj = enemy.Unwrap();       // Unwrap() is used to get the actual object from the wrapper object that is returned by CreateInstance() method.
                }
                catch { }

                switch (obj)
                {
                    case Goon goon:
                        Console.WriteLine(goon);
                        break;
                    case Agar agar:
                        Console.WriteLine(agar);
                        break;
                    case Pixa agar:
                        Console.WriteLine(agar);
                        break;
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }
            }
            while (true);
        }
    }

    public class Goon
    {
        public override string ToString()
        {
            return $"{{ Speed: 17, HitPower: 11, Strength: 7 }}";
        }
    }

    public class Agar
    {
        public override string ToString()
        {
            return $"{{ Speed: 20, HitPower: 15, Strength: 10 }}";
        }
    }

    public class Pixa
    {
        public override string ToString()
        {
            return $"{{ Speed: 15, HitPower: 10, Strength: 6 }}";
        }
    }
}
