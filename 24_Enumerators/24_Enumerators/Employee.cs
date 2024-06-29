namespace _24_Enumerators
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }


        // Overriding Equals method to do value comparison instead of reference comparison
        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Employee e))
                return false;

            return this.Id == e.Id && this.Name == e.Name && this.Salary == e.Salary && this.Department == e.Department;
        }

        // Overriding GetHashCode method to maintain the contract between Equals and GetHashCode methods (if two objects are equal then their hash code should be same)
        public override int GetHashCode()
        {
            // You can use any algorithm to generate hash code
            // Here we are using prime numbers to generate hash code (prime numbers are used to generate hash code because they are less likely to produce same hash code for different objects)
            int hash = 17;
            hash = hash * 7 + Id.GetHashCode();
            hash = hash * 7 + Name.GetHashCode();
            hash = hash * 7 + Salary.GetHashCode();
            hash = hash * 7 + Department.GetHashCode();
            return hash;
        }

        // Overloading == operator to do value comparison instead of reference comparison
        public static bool operator ==(Employee e1, Employee e2) => e1.Equals(e2);
        public static bool operator !=(Employee e1, Employee e2) => !e1.Equals(e2);
    }
}
