namespace _08_OOP_Constructor
{
    public class Engineer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Private Constructor to prevent object creation except through the static method below 
        private Engineer() { }
        private Engineer(string name, string address, DateTime birthOfDate)
        {
            Name = name;
            Address = address;
            DateOfBirth = birthOfDate;
        }

        // Static method to create object
        public static Engineer Create(string name, string address, DateTime birthOfDate)
        {
            return new Engineer(name, address, birthOfDate);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Date of Birth: {DateOfBirth}";
        }
    }
}
