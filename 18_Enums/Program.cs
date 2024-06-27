namespace _18_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Month.May);   // May
            Console.WriteLine((int)Month.May);   // 5

            var days = Day.SATURDAY | Day.SUNDAY;
            if (days.HasFlag(Day.WEEKEND))
            {
                Console.WriteLine("Enjoy Weekend");
            }

            Console.WriteLine("-------------------------");

            // Converting enum to its integer value
            Console.WriteLine((int)Month.July);

            // Converting enum to its string value
            Console.WriteLine(Month.July.ToString());

            // Parsing enum to its name (string)
            Console.WriteLine(Enum.GetName(typeof(Month), 7));

            // Parsing string to its enum value
            Console.WriteLine(Enum.Parse(typeof(Month), "July"));       // case-sensitive
            Console.WriteLine(Enum.Parse(typeof(Month), "july", true)); // case-insensitive

            var february = "FEBRUARY";
            if (Enum.TryParse(february, true, out Month month))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            if (Enum.IsDefined(typeof(Month), month))
            {
                Console.WriteLine("Defined");
            }
            else
            {
                Console.WriteLine("Undefined");
            }

            // Iterating over enum values
            Console.WriteLine("------------------------");

            foreach (var mon in Enum.GetNames(typeof(Month)))
            {
                Console.WriteLine($"{mon} = {(byte)Enum.Parse(typeof(Month), mon)}");
            }

            foreach (var mon in Enum.GetValues(typeof(Month)))
            {
                Console.WriteLine($"{mon} = {(byte)mon}");
            }


            Console.ReadKey();
        }
    }
}
