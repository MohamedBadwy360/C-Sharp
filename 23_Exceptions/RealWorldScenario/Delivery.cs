namespace RealWorldScenario
{
    class Delivery
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus Status { get; set; }


        public override string ToString()
        {
            return $"\nId: {Id}, CustomerName: {CustomerName}, Address: {Address}, Status: {Status}";
        }
    }
}
