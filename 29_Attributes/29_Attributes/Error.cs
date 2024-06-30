namespace _29_Attributes
{
    public class Error
    {
        private string _field;
        private string _details;

        public Error(string field, string details)
        {
            _field = field;
            _details = details;
        }

        public override string ToString()
        {
            return $"{{ \"{_field}\": \"{_details}\" }}";
        }
    }
}
