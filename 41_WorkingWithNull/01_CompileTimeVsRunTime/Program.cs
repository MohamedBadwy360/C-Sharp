namespace _01_CompileTimeVsRunTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compile time is the time when the code is converted into executable.
            // Run time is the time when the code is executed.
            // Compile time errors are those errors which are detected by the compiler.
            // Run time errors are those errors which are detected while the program is running.
            // Compile time errors are syntax errors.
            // Run time errors are logical errors.
            // Compile time errors are easy to debug.
            // Run time errors are hard to debug.
            // Compile time errors are less time consuming.
            // Run time errors are more time consuming.
            // Compile time errors are less risky.
            // Run time errors are more risky.
            // Compile time errors are less expensive.
            // Run time errors are more expensive.

            // Runtime errors are those errors which are detected while the program is running.
            // The program compiles successfully but it generates an error while it is running.
            // The program throws an exception when it encounters a runtime error.


            // ------------------------ Compile Time ------------------------

            string input = "123A";
            // "compile time" building source code and convert it to IL
            // int num1 = input; // CS0029 can't convert string to int

            //  "runtime" when you excuted the compiled code
            int num2 = int.Parse(input);
            Console.ReadKey();
        }
    }
}
