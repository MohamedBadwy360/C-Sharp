namespace _08_OOP_Constructor
{
    internal partial class Program
    {
        public class Date
        {
            private static readonly byte[] _daysInMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            private static readonly byte[] _daysInMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            private readonly byte _day;
            private readonly byte _month;
            private readonly ushort _year;

            // Constructor Signature: <Access Modifier> <Class Name> (<Parameters>) { }
            public Date(byte day, byte month, ushort year)
            {
                bool isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
                byte[] daysInMonth = isLeapYear ? _daysInMonth366 : _daysInMonth365;

                if (year > 1 && year <= 9999)
                {
                    if (month >= 1 && month <= 12)
                    {
                        if (day >= 1 && day <= daysInMonth[month])
                        {
                            _day = day;
                            _month = month;
                            _year = year;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(day), $"Day must be between 1 and {daysInMonth[month]}");
                        }
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1 and 9999");
                }
            }

            // Constructor Overloading
            public Date(ushort year) : this(1, 1, year) { } // Constructor Chaining (Calling another constructor from the same class)
            public Date(byte month, ushort year) : this(1, month, year) { } // Constructor Chaining (Calling another constructor from the same class
            public Date() : this(1, 1, 1) { } // Constructor Chaining (Calling another constructor from the same class)

            public override string ToString()
            {
                return $"{_day.ToString().PadLeft(2, '0')}/{_month.ToString().PadLeft(2, '0')}/{_year.ToString().PadLeft(4, '0')}";
            }
        }
    }
}
