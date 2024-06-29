namespace _23_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exceptions are runtime errors that can be handled by the programmer to prevent the program from crashing. 
            // Exceptions are thrown when an error occurs in the program.
            // Exceptions are objects of type Exception or a derived class of Exception.
            // Exceptions are thrown using the throw keyword.
            // Exceptions are caught using the try-catch block.
            // You can catch multiple exceptions using multiple catch blocks.
            // The finally block is used to run the code that should always run, whether an exception is thrown or not.
            // The finally block is optional.
            // The finally block is used to clean up resources like closing a file or a database connection.
            // You can use filters to catch specific exceptions.
            // Filters are used to catch exceptions based on a condition.
            // Filters are used with the when keyword.
            // The generic exception should be the last catch block.
            // The generic exception should be of type Exception.
            // In catch block, you can use the Exception object to get the details of the exception like Message, Source, StackTrace, etc.
            // In catch block, you can inform the user about the exception by displaying the exception message.
            // In catch block you can log the exception details to a file or a database.
            // In catch block, you can rethrow the exception to the calling method.
            // In catch block, you can swallow the exception by not doing anything in the catch block.


            // try-catch block

            // The try block contains the code that may throw an exception.
            try
            {
                // Code that may throw an exception
                BadMethod();
            }
            // Handling the specific exception
            catch (DivideByZeroException ex) when (ex.Source == "23_Exceptions")    // With Filter
            {
                // Code to handle the exception
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
            }
            catch (DivideByZeroException ex)        // Without Filter
            {
                // Code to handle the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            // Swallow the exception by not doing anything in the catch block
            // It is not recommended to swallow the exception without any action
            // Do not do this in production code
            // But it you want to swallow the exception, you can log the exception details to a file or a database or inform the user about the exception or rethrow the exception to the calling method to handle it there
            catch (InvalidOperationException ex)
            {
                // Swallow the exception by not doing anything in the catch block 
                // It is not recommended to swallow the exception without any action 
                // Do not do this in production code 
                // But it you want to swallow the exception, you can log the exception details to a file or a database or inform the user about the exception or rethrow the exception to the calling method to handle it there
            }
            // Handling the generic exception
            // The generic exception should be the last catch block
            catch (Exception ex)
            {
                // Code to handle the exception
                Console.WriteLine("Error: " + ex.Message);
            }
            // Code that will always run
            finally
            {
                // Code that will always run
                Console.WriteLine("Finally block");
            }
        }

        static int BadMethod()
        {
            int a = 10;
            int b = 0;
            return a / b;
        }
    }
}
