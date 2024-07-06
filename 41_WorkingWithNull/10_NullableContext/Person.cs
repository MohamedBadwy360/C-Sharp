#nullable enable annotations  // enable nullable annotations in this file only

namespace _10_NullableContext
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

#nullable restore annotations           // restore nullable annotations to the default setting