namespace RealWorldScenario
{
    // Custom Exception class to handle invalid address 
    internal class InvalidAddressException : Exception
    {
        public InvalidAddressException(string message) : base(message) { }
    }
}
