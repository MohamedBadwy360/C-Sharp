namespace _01_IDisposableDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // When there is an unmanaged resource, we need to dispose of it.
            // Best practice is to use the using statement to dispose of the object.
            // The using statement is a C# language construct that is used to ensure that a resource is disposed of when it is no longer needed.
            // The using statement is used to declare a scope in which a resource is used and to ensure that the resource is disposed of when the scope is exited.

            // Microsoft Best Practice for disposing of objects that implement IDisposable:
            // 1. Use the using statement to ensure that the object is disposed of when it is no longer needed.
            // 2. Call the Dispose method explicitly when the object is no longer needed.
            // 3. Implement the IDisposable interface and provide a Dispose method that releases the resources used by the object.
            // 4. Use the Dispose pattern to ensure that the object is disposed of when it is no longer needed.

            // unmanged code should be disposed of when it is no longer needed.
            // unmanaged code should be in try-catch block to handle the exception.
            // unmanaged code should be in finally block to dispose of the object.


            // 1) not recommended
            //CurrencyService currencyService = new CurrencyService();
            //var result = currencyService.GetAllCurrencies();
            //currencyService.Dispose();                              // Dispose of the object when it is no longer needed. But is not recommended.
            //Console.WriteLine(result);


            // 2) recommended - try - catch block
            //CurrencyService currencyService = null;

            //try
            //{
            //    currencyService = new CurrencyService();
            //    var result = currencyService.GetAllCurrencies();
            //    Console.WriteLine(result);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error");
            //}
            //finally
            //{
            //    currencyService?.Dispose();                             // Dispose of the object when it is no longer needed.
            //}


            // 3) recommended - using statement
            // inside using statement, the object is disposed of when it is no longer needed.
            // I declare the object that implement IDisposable inside the using statement.
            // Using statement is a syntactic sugar for try-finally block.
            // Internally, the using statement calls the Dispose method on the object when the object is no longer needed and the scope is exited.
            //using (CurrencyService currencyService = new CurrencyService())
            //{
            //    var result = currencyService.GetAllCurrencies();
            //    Console.WriteLine(result);
            //}

            // 4) recommended - using statement with no block
            // using statement with no block is used when we don't need to use the object inside the using statement.
            // The using statement with no block is used to ensure that the object is disposed of when it is no longer needed.

            using CurrencyService currencyService = new CurrencyService();

            var result = currencyService.GetAllCurrencies();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    // HttpClient is not disposable 
    // We need to dispose of the HttpClient object.
    // So we need to implement the IDisposable interface and provide a Dispose method that releases the resources used by the object.
    // We need to use the Dispose pattern to ensure that the object is disposed of when it is no longer needed.
    class CurrencyService : IDisposable
    {
        // HttpClient is not disposable
        // HttpClient is a managed resource and it is not disposable 
        // HttpClient is a class that is designed to be reused for multiple requests.
        // HttpClient is designed to be long-lived and re-used for multiple requests.
        // HttpClient is a class that is used for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
        private readonly HttpClient _httpClient;

        // We need the disposing flag to determine if the object is being disposed of.
        // This ensures that the object is disposed of only once.
        private bool _disposed = false;

        public CurrencyService()
        {
            _httpClient = new HttpClient();
        }

        // We should implement finalizer to release the resources used by the object.
        // This is useful when the client code forgets to call the Dispose method.
        // The finalizer is called by the garbage collector when the object is no longer needed.
        // This operation is expensive and should be avoided if possible.
        // This operation should be treated as a last resort.
        // This operation should be treated clevery.
        ~CurrencyService()
        {
            // Finalizer calls Dispose method with disposing flag set to false.
            // This is for releasing the resources used by the object.
            Dispose(false);
        }


        // We need to implement protected virtual Dispose method that take bool parameter for releasing the resources used by the object for the class and derived classes.
        // This is for internal using by derived classes.
        // This is for releasing the resources used by the object.
        // disposing if true, release both managed and unmanaged resources.
        // disposing if false, release only unmanaged resources and large, expensive managed resources (fields) that are no longer needed.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }


            // Dispose Logic 

            // Dispose of managed resources
            if (disposing)
            {
                // Dispose HttpClient object
                _httpClient.Dispose();
            }
            // Dispose of unmanaged resources
            // Unmanaged resources are resources that are not managed by the .NET runtime.
            // Unmanaged resources are resources that are not managed by the garbage collector.
            // Set large fields to null to release the resources used by the object.


            _disposed = true;
        }


        // Implement the IDisposable interface and provide a Dispose method that releases the resources used by the object.
        // The Dispose method is called by the using statement when the object is no longer needed.
        // This is for releasing the resources used by the object.
        // This for external using by client code.
        public void Dispose()
        {
            // Dispose is called 100% by the client code so we need to suppress the finalizer.

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string GetAllCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var result = _httpClient.GetStringAsync(url).Result;
            return result;
        }
    }
}
