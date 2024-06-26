namespace _12_OOP_Events
{
    // Subscriber
    internal class Program
    {
        static void Main(string[] args)
        {
            // Events enable a class or object to notify other classes or objects when something of interest occurs.
            // The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers.
            // Events are a type of multicast delegate, which means that they can hold references to more than one event handler.
            // The publisher determines when an event is raised; the subscribers determine what action is taken in response to the event.
            // Events are declared using delegates.

            Stock stock = new Stock("Apple");
            stock.Price = 100;

            // Subscribe to the event 
            stock.OnPriceChanged += Stock_OnPriceChanged;

            // Another way to subscribe to the event
            //stock.OnPriceChanged += (Stock stock, decimal oldPrice) =>
            //{
            //    if (stock.Price > oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    else if (stock.Price < oldPrice)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }

            //    Console.WriteLine($"{stock.Name}: {stock.Price}$");
            //};

            stock.ChangePriceByPercent(0.05m);
            stock.ChangePriceByPercent(-0.03m);
            stock.ChangePriceByPercent(0.00m);

            // Unsubscribe from the event
            stock.OnPriceChanged -= Stock_OnPriceChanged;

            stock.ChangePriceByPercent(0.10m);

        }

        // Method that will be called when the event is raised
        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine($"{stock.Name}: {stock.Price}$");
        }
    }
}
