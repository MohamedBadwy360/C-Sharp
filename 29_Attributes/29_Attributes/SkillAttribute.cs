namespace _29_Attributes
{
    // Create Custom Attribute Class
    // AttributeUsage attribute is used to specify where the attribute can be applied. It is a flag enumeration.
    // AllowMultiple property of AttributeUsage attribute is used to specify if the attribute can be applied multiple times.
    // Inherited property of AttributeUsage attribute is used to specify if the attribute is inherited by derived classes.
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    [AttributeUsage(AttributeTargets.Property)]
    public class SkillAttribute : Attribute
    {
        public SkillAttribute(string name, int minimum, int maximum)
        {
            Name = name;
            Minimum = minimum;
            Maximum = maximum;
        }

        public string Name { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }


        public bool IsValid(object obj)
        {
            int value = (int)obj;
            return value >= Minimum && value <= Maximum;
        }
    }
}
