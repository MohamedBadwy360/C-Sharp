// NotAllowed to declare namespace and class at the top of the file before the top level statements.
//namespace NotAllowed
//{
//    class NotAllowed
//    {

//    }
//}


// Top Level Statements are supported in C# 9 and later versions from .NET 6.0 onwards.
// This is the entry point of the application.
// The Main method is not required in this case.

// Top Level Statements are used to simplify the code by removing the Main method.
// The compiler will automatically generate the Main method.
// The compiler under the hood will generate the Main method and the program class and the namespace and the using directives and execute the code.

// Why? 
// 1. To simplify the code.
// 2. To reduce the boilerplate code.
// 3. To make the code more readable.
// 4. To ease the learning curve for beginners.
// 5. To ease making utitlity programs or small programs or scheduling tasks.

// Note: 
// 1. The Main method is not allowed in the file.

// The compiler will choose the type or the signature of main method depending on the logic in the code.
// The compiler will choose the Main method with the correct signature based on the logic in the code.

// --------------------------------------------------------------------------------

// Rules: 
// 1. It is allowed to write namespaces and define classes and methods down the file not at the top before the top level statements.
// 2. It is not allowed to write namespaces and define classes and methods at the top of the file before the top level statements.
// 3. Top level statements are not allowed in the middle of the file it should precede all other code.
// 4. The Main method is not allowed in the file.
// 5. All methods inside the top level statements are considered local methods.

// --------------------------------------------------------------------------------

var number = 9;

if (number % 2 == 0)
    Console.WriteLine($"{number} is Even");
else
    Console.WriteLine($"{number} is Odd");

// --------------------------------------------------------------------------------

// Local methods can be defined inside the top level statements.
void DecideEvenOddV2(int number)
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is Even");
    else
        Console.WriteLine($"{number} is Odd");
}

Console.WriteLine("Hello, World!");
DecideEvenOdd(9);
DecideEvenOdd(10);

// local method inside the top level statements.
void DecideEvenOdd(int number)
{
    if (number % 2 == 0)
        Console.WriteLine($"{number} is Even");
    else
        Console.WriteLine($"{number} is Odd");
}




Console.ReadKey();

// --------------------------------------------------------------------------------

// Namespace and class can be defined down the file.
namespace AllowedHere
{
    class Allowed
    {

    }
}
