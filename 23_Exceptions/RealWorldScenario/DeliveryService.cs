
namespace RealWorldScenario
{
    internal class DeliveryService
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Process(delivery);
                Ship(delivery);
                Transit(delivery);
                Deliver(delivery);
            }
            catch (AccidentException ex)
            {
                //throw;    // re-throw the exception to the caller method to handle it there
                Console.WriteLine($"Delivery fails due to: an accident at {ex.Location}");
                delivery.Status = DeliveryStatus.Unknown;
            }
            catch (Exception ex)
            {
                //throw;    // re-throw the exception to the caller method to handle it there
                Console.WriteLine($"Delivery fails due to: {ex.Message}");
                delivery.Status = DeliveryStatus.Unknown;
            }
            //finally
            //{
            //    Console.WriteLine("End");
            //}
        }

        private void Process(Delivery delivery)
        {
            FakeIt("Processing");

            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Unable to process the item");
            }

            delivery.Status = DeliveryStatus.Processed;
        }

        private void Ship(Delivery delivery)
        {
            FakeIt("Shipping");

            if (random.Next(1, 5) == 1)
            {
                throw new InvalidOperationException("Parcel is damaged during the loading");
            }

            delivery.Status = DeliveryStatus.Shipped;
        }

        private void Transit(Delivery delivery)
        {
            FakeIt("On Way");

            if (random.Next(1, 5) == 1)
            {
                throw new AccidentException("Highway 1", "Accident !!!!!");
            }

            delivery.Status = DeliveryStatus.InTransit;
        }
        private void Deliver(Delivery delivery)
        {
            FakeIt("Delivering");

            if (random.Next(1, 5) == 1)
            {
                throw new InvalidAddressException($"Delivery address {delivery.Address} is invalid.");
            }

            delivery.Status = DeliveryStatus.Delivered;
        }

        private void FakeIt(string title)
        {
            Console.Write($"\n{title}");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }
        }
    }
}
