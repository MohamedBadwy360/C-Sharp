namespace _16_Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Errors 
            // 1. Syntax Error => is a compile time error 
            // 2. Runtime Error => is an error that occurs during the execution of the program 
            // 3. Logical Error => is an error that occurs when the program runs successfully but does not give the expected output

            // Debugging 
            // 1. Breakpoints => is a point in the code where the debugger will pause the execution of the program
            // 2. Step Over => is a debugging command that allows you to execute the next line of code without stepping into the function
            // 3. Step Into => is a debugging command that allows you to step into the function and execute the code line by line
            // 4. Step Out => is a debugging command that allows you to step out of the function and return to the calling function
            // 5. Continue => is a debugging command that allows you to continue the execution of the program until the next breakpoint is reached
            // 6. Watch => is a debugging feature that allows you to monitor the value of a variable or an expression during the execution of the program
            // 7. Call Stack => is a debugging feature that allows you to view the sequence of function calls that led to the current point in the program
            // 8. Locals => is a debugging feature that allows you to view the values of local variables in the current scope
            // 9. Autos => is a debugging feature that allows you to view the values of variables that are relevant to the current line of code
            // 10. Immediate => is a debugging feature that allows you to execute code in the context of the current breakpoint

            // Debugging Techniques
            // 1. Print Statements => is a debugging technique that involves adding print statements to the code to display the values of variables
            // 2. Logging => is a debugging technique that involves writing log messages to a file or console to track the flow of the program
            // 3. Exception Handling => is a debugging technique that involves catching and handling exceptions to prevent the program from crashing
            // 4. Unit Testing => is a debugging technique that involves writing test cases to verify the correctness of individual units of code
            // 5. Code Review => is a debugging technique that involves reviewing the code with other developers to identify and fix bugs
            // 6. Pair Programming => is a debugging technique that involves two developers working together to write and debug code
            // 7. Rubber Duck Debugging => is a debugging technique that involves explaining the code to an inanimate object to identify and fix bugs
            // 8. Binary Search => is a debugging technique that involves dividing the code into halves and testing each half to identify the bug
            // 9. Code Refactoring => is a debugging technique that involves restructuring the code to make it easier to understand and maintain
            // 10. Code Profiling => is a debugging technique that involves analyzing the performance of the code to identify bottlenecks and optimize it

            // Exception => is an error that occurs during the execution of the program and disrupts the normal flow of the program
            // Exception Handling => is a mechanism that allows you to handle exceptions gracefully and prevent the program from crashing


            int amount = 1000;
            int members = 2;

            members = Reduce(members, 2);
            var share = Ditribute(amount, members);     // Exception: DivideByZeroException which is a runtime error 
            Console.WriteLine(share);

            decimal celcius = 0;
            decimal fahrenheit = ConvertCelciusToFahrenheit(celcius);
            Console.WriteLine($"{celcius}C = {fahrenheit}F");
            celcius = ConvertFahrenheitToCelcius(fahrenheit);
            Console.WriteLine($"{fahrenheit}F = {celcius}C");

            Console.ReadKey();
        }

        static int Reduce(int members, int value)
        {
            return members -= value;
        }

        static int Ditribute(int amount, int members)
        {
            // We can solve runtime error by adding exception handling 
            // We can use try-catch block to handle the exception or check the value of members before dividing 
            try
            {
                // in try block we write the code that may throw an exception
                return amount / members;
            }
            catch (Exception ex)
            {
                // in case of exception is thrown, catch block will handle the exception
                // we can log the exception or display a message to the user 
                Console.WriteLine($"Unexcpected error: {ex.Message}");
            }
            finally
            {
                // optional block that will always execute whether exception is thrown or not
                //Console.WriteLine("Finally block executed");
            }

            return 0;
        }

        static decimal ConvertCelciusToFahrenheit(decimal celcius)
        {
            return celcius * 9 / 5 + 32;
        }

        static decimal ConvertFahrenheitToCelcius(decimal fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;     // the true logic
            //return fahrenheit - 32 * 5 / 9;         // the bug / logical error that will return wrong value 

            // We can discover this bug by debugging the code and stepping through the code line by line to see the values of variables
            // We can trace the flow of the code and identify the point where the bug occurs and fix it 
            // We can track the values of variables and expressions to see if they are correct and match our expectations 
            // We can use breakpoints to pause the execution of the program and inspect the values of variables and expressions
            // We can use watch window to monitor the values of variables and expressions during the execution of the program
            // We can use immediate window to execute code and evaluate expressions in the context of the current breakpoint


            // the bug is that the operator precedence is not correct 
            // the correct precedence is to subtract 32 from fahrenheit first then multiply by 5 then divide by 9
            // the wrong precedence is to subtract 32 from the result of 32 * 5 then divide by 9
        }
    }
}
