namespace _04_ExpressionsAndIterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expression is a combination of values, variables, operators, and method calls that evaluates to a single value.
            // Primary expressions: literals, simple names, parenthesized expressions, member access expressions, element access expressions, invocation expressions, object creation expressions.
            // Unary expressions: unary plus, unary minus, logical negation, bitwise complement, increment, decrement, cast, typeof, sizeof, default, checked, unchecked.
            // Multiplicative operators: *, /, %
            // Additive operators: +, -
            // Shift operators: <<, >>
            // Relational and type testing operators: <, >, <=, >=, is, as
            // Equality operators: ==, !=
            // Logical AND operator: &&
            // Logical OR operator: ||
            // Conditional operator: ?:
            // Assignment and lambda operators: =, *=, /=, %=, +=, -=, <<=, >>=, &=, ^=, |=, =>
            // Null-coalescing operator: ??
            // Conditional logical operators: &, ^
            // Conditional logical OR operator: | 
            // Void expressions: expressions that are used for their side effects, not for their values.
            // Assignment expressions: expressions that assign a value to a variable.
            // Invocation expressions: expressions that invoke a method.
            // Object creation expressions: expressions that create a new object.
            // Member access expressions: expressions that access a member of an object.
            // Element access expressions: expressions that access an element of an array.
            // Indexer access expressions: expressions that access an element of a collection.
            // Postfix increment and decrement expressions: expressions that increment or decrement a variable after it is evaluated.
            // Unary plus and minus expressions: expressions that apply unary + or - to a value.
            // Logical negation and bitwise complement expressions: expressions that apply logical negation or bitwise complement to a value.
            // Cast expressions: expressions that explicitly convert a value from one type to another.
            // Multiplicative expressions: expressions that multiply or divide two values.
            // Additive expressions: expressions that add or subtract two values.
            // Shift expressions: expressions that shift the bits of a value to the left or right.
            // Relational and type-testing expressions: expressions that compare two values.
            // Equality expressions: expressions that test for equality or inequality.
            // Logical AND expressions: expressions that perform a logical AND operation.
            // Logical OR expressions: expressions that perform a logical OR operation.
            // Conditional expressions: expressions that evaluate one of two values based on a condition.
            // Null-coalescing expressions: expressions that return the left operand if it is not null, or the right operand otherwise.
            // Conditional logical expressions: expressions that perform a logical AND or OR operation only if the preceding expression is true or false.
            // Assignment expressions: expressions that assign a value to a variable.
            // Lambda expressions: expressions that represent an anonymous method.
            // Query expressions: expressions that perform a query operation on a data source.
            // Anonymous object creation expressions: expressions that create an object with properties.
            // Tuple expressions: expressions that create a tuple.
            // Default value expressions: expressions that return the default value of a type.
            // Checked expressions: expressions that check for overflow.
            // Unchecked expressions: expressions that ignore overflow.
            // Type-testing expressions: expressions that test whether an object is compatible with a given type.
            // sizeof expressions: expressions that return the size of a type.
            // typeof expressions: expressions that return the System.Type object for a type.
            // Pointer member access expressions: expressions that access a member of a pointer.
            // Address-of expressions: expressions that return the address of a variable.

            var amount = Math.Cos(30);      // Method call expression => Primary expression
            var x = 10;                     // Simple name expression => Primary expression

            Console.WriteLine("Hello");     // Invocation expression => Primary expression

            x = x + 10;     // Binary expression => Assignment expression
            int y = 10;

            // Arithmetic operators => Binary expression
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            string s1 = null;
            string s2 = s1 ?? "nothing;";    // Null-coalescing expression => Binary expression

            var s3 = s2?.ToUpper();          // Null-conditional expression => Member access expression



            // Increment and decrement operators => Unary expression => Postfix increment and decrement expression
            int a = 10;
            Console.WriteLine(a++);  // 10
            Console.WriteLine(a);    // 11
            Console.WriteLine(++a);  // 12
            Console.WriteLine(a);    // 12
            Console.WriteLine(--a);  // 11
            Console.WriteLine(a);    // 11
            Console.WriteLine(a--);  // 11
            Console.WriteLine(a);    // 10



            // Selection statements => if, else, else if, switch => Conditional expression 
            int mark = 90;
            if (mark > 90)
            {
                Console.WriteLine("A+");
            }
            else if (mark > 80)
            {
                Console.WriteLine("A");
            }
            else if (mark > 70)
            {
                Console.WriteLine("B");
            }
            else if (mark > 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Fail");
            }


            var amountJOD = 100;
            var currencyType = "USD";
            var output = 0d;

            var JODToUSD = 1.41d;
            var JODToEUR = 1.18d;
            var JODToCAD = 1.30d;

            // Switch statement => Conditional expression
            switch (currencyType)
            {
                case "USD":
                    output = amountJOD * JODToUSD;
                    break;
                case "EUR":
                    output = amountJOD * JODToEUR;
                    break;
                case "CAD":
                    output = amountJOD * JODToCAD;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{output}$");

            int num = 3;

            
            // Switch statement many cases with the same output
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("ODD");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("EVEN");
                    break;
            }

            // Switch with pattern
            object o = 3;
            switch (o)
            {
                case int integer:
                    Console.WriteLine("int");
                    break;
                case string s:
                    Console.WriteLine("string");
                    break;
                default:
                    Console.WriteLine("object");
                    break;
            }

            // Switch with pattern
            bool isVip = true;
            switch (isVip)
            {
                case bool b when b == true:
                    Console.WriteLine("True");
                    break;
                case bool b:
                    Console.WriteLine("No");
                    break;
            }


            var cardNo = 1;

            // Switch expression => Conditional expression
            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "KING",
                12 => "QUEEN",
                10 => "JACK",
                _ => cardNo.ToString()
            };

            Console.WriteLine(cardName);



            // Iterations => is a control structure that repeats a block of statements.
            // for, foreach, while, do-while

            // While loop 
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // Infinite while loop
            //while (true)
            //{
            //    Console.WriteLine("Infinite loop");
            //}


            // Do-While loop
            i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

            // For loop
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // For loop with multiple variables 
            for (int j = 0, k = 10; j < 10; j++, k--)
            {
                Console.WriteLine(j);
                Console.WriteLine(k);
            }

            // Infinite for loop
            //for (; ; )
            //{
            //    Console.WriteLine("Infinite loop");
            //}
            
            // For loop with break and continue
            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    continue;
                }
                if (j == 8)
                {
                    break;
                }
                Console.WriteLine(j);
            }


            // Nested loops
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine($"{j} - {k}");
                }
            }

            // ForEach loop
            var names = new string[] { "Ahmad", "Ali", "Mohammad" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            // Jump statements => break, continue, goto, return, throw
            // Break statement => is used to terminate the loop or switch statement and transfer control to the statement immediately following the loop or switch.
            // Continue statement => is used to skip the execution of the rest of the loop and jump to the next iteration.
            // Goto statement => is used to transfer control to a different part of the program.
            // Return statement => is used to return a value from a method.
            // Throw statement => is used to throw an exception.
            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine(j);
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine(j);
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    goto outer;
                }
                Console.WriteLine(j);
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    return;
                }
                Console.WriteLine(j);
            }

            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    throw new Exception("Error");
                }
                Console.WriteLine(j);
            }


            // Labeled statements => is a statement followed by a colon and an identifier.
            // The identifier is the label of the statement.
            // The label can be used as a target for the goto statement.
            // The goto statement transfers the program control directly to a labeled statement.
            // The goto statement is used to transfer control to a different part of the program.
            // The target of the goto statement is a labeled statement.
            // The goto statement is used to exit from a nested loop.
            // The goto statement is used to skip the execution of a block of code.
            outer:
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (k == 5)
                    {
                        goto outer;
                    }
                    Console.WriteLine($"{j} - {k}");
                }
            }
        }
    }
}
