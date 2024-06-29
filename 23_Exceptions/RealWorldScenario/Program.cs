namespace RealWorldScenario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new Delivery
            {
                Id = 1,
                CustomerName = "John Doe",
                Address = "123 Elm St",
                Status = DeliveryStatus.Shipped
            };

            DeliveryService deliveryService = new DeliveryService();

            try
            {
                deliveryService.Start(delivery);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delivery fails due to: {ex.Message}");
            }

            Console.WriteLine(delivery);

            Console.ReadKey();
        }
    }
}
