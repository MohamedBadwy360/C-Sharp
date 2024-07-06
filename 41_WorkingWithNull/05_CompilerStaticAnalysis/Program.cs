namespace _05_CompilerStaticAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compiler Static Analysis
            // Compiler can analyze the code and determine if a variable can be null or not
            // Compiler searches for null checks and assignments to determine if a variable can be null or not
            // Compiler can determine if a variable is non-null or maybe-null

            // If a variable is non-null, it can't be null
            // If a variable is maybe-null, it can be null

            // If you make checks for null, the compiler can determine if a variable is null or not
            // If you don't make checks for null, the compiler can't determine if a variable is null or not



            Console.ReadKey();
        }

        private static string? GetName()
        {
            return null;
        }

        #region  Non-null
        static bool Scenario1()
        {
            string name = String.Empty; // Assignment of non null value
            return name.Length > 10;
        }
        static bool Scenario2()
        {
            string? name = GetName();
            if (name == null) // checked against null
                return false;
            return name.Length > 10; // name shouldn't be null
        }
        #endregion

        #region  Maybe-null
        static bool MaybeNullScenario()
        {
            string? name = GetName();
            return name.Length > 10; // maybe null
        }
        #endregion 
    }
}
