namespace _12_OOP_Events
{
    // Declaration of the delegate
    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

    // Publisher
    public class Stock
    {
        private string _name;
        private decimal _price;

        public string Name => _name;
        public decimal Price { get => _price; set => _price = value; }

        // Event declaration using the delegate 
        public event StockPriceChangeHandler OnPriceChanged;

        public Stock(string stockName)
        {
            _name = stockName;
        }

        public void ChangePriceByPercent(decimal percent)
        {
            decimal oldPrice = _price;
            _price += Math.Round(_price * percent, 2);

            if (OnPriceChanged is not null)         // ensure that there are subscribers
            {
                OnPriceChanged(this, oldPrice);     // raise the event (call the delegate) / notify the subscribers / publish the event
            }
        }
    }
}
