namespace _09_OOP_Properties
{
    public class Dollar
    {
        // Backing field is a private field that stores the value of a property 
        private decimal _amount;

        // Properities are used to access the fields of a class
        // Properities are used to protect the fields of a class
        // Properities promotes the principle of data hiding and encapsulation of OOP
        public decimal Amount
        {
            // get accessor is used to return the field value
            // can be private, protected, internal, or public
            get
            {
                return _amount;
            }
            // set accessor is used to assign a new value to the field
            // can be private, protected, internal, or public
            set
            {
                // Validation logic can be added to the set accessor to validate the new value 
                if (value <= 0)
                {
                    _amount = 0;
                }
                else
                {
                    // value is a keyword used to assign a new value to the field 
                    // value is a temporary variable that holds the new value passed to the property 
                    _amount = Math.Round(value, 2);
                }
            }
        }

        // Read-only property
        public bool IsZero
        {
            get
            {
                return _amount == 0;
            }
            // set accessor is not allowed for read-only properties
        }

        // Read-only property with expression body syntax
        public bool IsZero_ExpressionBodied => _amount == 0;

        // Read-only property with initializer syntax
        public decimal ConversionFactor { get; } = 1.1m;

        // Prperities with initializer syntax
        public decimal ConversionFactor2 { get; set; } = 1.1m;

        // Auto-implemented properties are used to define properties without explicitly defining the backing field 
        public decimal Amount_AutomaticProperty { get; set; }

        public Dollar(decimal amount)
        {
            Amount = amount;
        }
    }
}
