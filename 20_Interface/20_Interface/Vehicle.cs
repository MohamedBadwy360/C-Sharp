namespace _20_Interface
{
    // Abstract type
    abstract class Vehicle
    {
        protected string _name;
        protected string _model;
        protected int _year;

        protected Vehicle(string name, string model, int year)
        {
            _name = name;
            _model = model;
            _year = year;
        }
    }
}
