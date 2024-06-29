namespace RealWorldScenario
{
    // Custom Exception class to handle accidents
    internal class AccidentException : Exception
    {
        public string Location { get; set; }
        public AccidentException(string location, string message) : base(message)
        {
            Location = location;
        }
    }
}
