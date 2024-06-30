namespace _26_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Extension methods allow you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
            // Extension methods are static methods that are called as if they were instance methods on the extended type.
            // They are defined in a static class and are marked with the 'this' keyword before the first parameter.
            // The first parameter specifies the type that the method operates on, and the parameter is preceded by the 'this' keyword.
            // Extension methods can be called on an instance of the type that they extend.

            // DateTime is a struct in the System namespace that represents an instant in time.
            // DateTime has many properties and methods that allow you to work with dates and times.
            // DateTime.Now returns the current date and time on the computer without the timezone.
            DateTime dt = DateTime.Now;
            Console.WriteLine($"DateTime.Now: {dt}");   // yyyy-MM-dd HH:mm:ss AM/PM
            dt = new DateTime(2024, 1, 25, 11, 30, 00);
            Console.WriteLine($"New DateTime: {dt}");    // yyyy-MM-dd HH:mm:ss AM/PM

            // DateTimeOffset is a struct in the System namespace that represents a date and time with an offset from UTC.
            // DateTimeOffset has many properties and methods that allow you to work with dates and times.
            // DateTimeOffset.Now returns the current date and time on the computer with the timezone.
            DateTimeOffset dto = DateTimeOffset.Now;    // DateTimeOffset.Now returns the current date and time on the computer with the timezone.
            Console.WriteLine($"DateTimeOffset.Now: {dto}");    // yyyy-MM-dd HH:mm:ss AM/PM +HH:mm
            dto = DateTimeOffset.UtcNow;        // Coordinated Universal Time (UTC) is the time standard by which the world regulates clocks and time.
            Console.WriteLine($"DateTimeOffset.UtcNow: {dto}");    // yyyy-MM-dd HH:mm:ss AM/PM +HH:mm

            // TimeSpan is a struct in the System namespace that represents a time interval.
            // TimeSpan has many properties and methods that allow you to work with time intervals.
            // TimeSpan.Zero represents a time interval of zero.
            TimeSpan ts = TimeSpan.Zero;
            Console.WriteLine($"TimeSpan.Zero: {ts}");    // 00:00:00

            ts = new TimeSpan(2, 15, 00);
            dt = dt.Add(ts);                                     // Adds the specified time interval to the current date and time.
            Console.WriteLine($"New DateTime: {dt}");            // yyyy-MM-dd HH:mm:ss AM/PM

            dt = dt.AddDays(4);                                  // Adds the specified number of days to the current date and time.
            Console.WriteLine($"New DateTime + 4 days: {dt}");


            // -----------------------------------------------------------------------------------------------
            // Extension Methods

            Console.WriteLine("\n---------------------------\n");

            DateTime dateTime = DateTime.Now;

            // Calling the extension methods - call as if they were instance methods on the extended type (DateTime)
            Console.WriteLine($"IsWeekend: {dateTime.IsWeekend()}");    // False
            Console.WriteLine($"IsWeekday: {dateTime.IsWeekday()}");    // True

            // Another way to call the extension methods - traditional way to call static methods
            Console.WriteLine($"IsWeekend: {DateTimeExtensions.IsWeekend(dateTime)}");    // False
            Console.WriteLine($"IsWeekday: {DateTimeExtensions.IsWeekday(dateTime)}");    // True


            // -----------------------------------------------------------------------------------------------

            // Method chaining - calling multiple methods in a single statement by chaining the method calls together using the dot operator.
            // Method chaining is a common pattern in LINQ queries and fluent interfaces.
            // Method chaining is a technique that allows you to call multiple methods on the same object in a single statement.
            // Method chaining is achieved by returning the object itself from the method.
            // Method chaining is achieved by using extension methods. Extension methods allow you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
            // Method chaining is achieved by using the 'this' keyword before the first parameter of the extension method.

            Console.WriteLine("\n------------------------\n");

            //// Before Adding AddSauce() instance method to Pizza class
            //Pizza pizza = new Pizza();
            //pizza.AddDough("Thin")
            //    .AddSauce()
            //    .AddCheeze(true)
            //    .AddToppings("Black Olives", 3.5m);

            //Console.WriteLine(pizza);
            // Output:
            // Content:
            // Thin Dough X $4.00
            // Tomato Sauce X $2.00
            // Extra Cheeze X $6.00
            // Black Olives Toppings X 3.5
            // ----------------------------
            // TotalSalary: 15.5


            // -----------------------------------------------------------------------------------------------

            // Which win? - Extension methods or Instance methods
            // Instance methods take precedence over extension methods.
            // If a type has an instance method with the same signature as an extension method, the instance method is called.

            // After Adding AddSauce() instance method to Pizza class
            Pizza pizza2 = new Pizza();
            pizza2.AddDough("Thin")
                .AddSauce()             // Instance method Take precedence over extension method AddSauce()
                .AddCheeze(true)
                .AddToppings("Black Olives", 3.5m);

            Console.WriteLine(pizza2);
            // Output:
            // Content:
            // Thin Dough X $4.00
            // TOMATO SAUCE X $2.00
            // Extra Cheeze X $6.00
            // Black Olives Toppings X 3.5
            // ----------------------------
            // TotalSalary: 15.5
        }
    }

    class Pizza
    {
        public string Content { get; set; }
        public decimal TotalSalary { get; set; }

        public Pizza AddSauce()
        {
            this.Content += $"TOMATO SAUCE X $2.00\n";
            this.TotalSalary += 2.00m;
            return this;
        }

        public override string ToString()
        {
            return $"Content: \n{Content}----------------------------\nTotalSalary: {TotalSalary.ToString("#.##")}";
        }
    }

    static class PizzaExtensions
    {
        public static Pizza AddDough(this Pizza pizza, string doughType)
        {
            pizza.Content += $"{doughType} Dough X $4.00\n";
            pizza.TotalSalary += 4.00m;
            return pizza;
        }

        public static Pizza AddSauce(this Pizza pizza)
        {
            pizza.Content += $"Tomato Sauce X $2.00\n";
            pizza.TotalSalary += 2.00m;
            return pizza;
        }

        public static Pizza AddCheeze(this Pizza pizza, bool extra)
        {
            pizza.Content += $"{(extra ? "Extra" : "Regular")} Cheeze X ${(extra ? "6.00" : "4.00")}\n";
            pizza.TotalSalary += (extra ? 6m : 4m);
            return pizza;
        }

        public static Pizza AddToppings(this Pizza pizza, string toppingsType, decimal toppingsPrice)
        {
            pizza.Content += $"{toppingsType} Toppings X {toppingsPrice.ToString("#.##")}\n";
            pizza.TotalSalary += toppingsPrice;
            return pizza;
        }
    }
}
