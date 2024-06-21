//bool isVip = true;

var x = 10;     // assign 10 to variable x
var y = 10;

Console.WriteLine(x == y);      // x is equal to y ? => True



// Comparison Operators
var z = x == y;     // assign the result of x == y to z

// x == y is expression that returns a boolean value
// expression is a piece of code that returns a value

Console.WriteLine(z);

var total = 1000;
var vipThreshold = 900;

var isVip = total >= vipThreshold;      // total is greater than or equal to vipThreshold
Console.WriteLine(isVip);

// >= , <= , > , < , == , !=

// negation operator
var isNotVip = !isVip;      // isVip is false
Console.WriteLine(isNotVip);


// Logical Operators

// Logical AND operator (&&) => true if both operands are true
Console.WriteLine(true && true);    // true
Console.WriteLine(true && false);   // false
Console.WriteLine(false && true);   // false
Console.WriteLine(false && false);  // false

// Logical OR operator (||) => true if at least one operand is true
Console.WriteLine(true || true);    // true
Console.WriteLine(true || false);   // true
Console.WriteLine(false || true);   // true
Console.WriteLine(false || false);  // false

// Logical XOR operator (^) => true if one of the operands is different from the other
Console.WriteLine(true ^ true);     // false
Console.WriteLine(true ^ false);    // true
Console.WriteLine(false ^ true);    // true
Console.WriteLine(false ^ false);   // false




// Short-circuiting => if the result of the expression can be determined by evaluating the first operand, the second operand is not evaluated
// short-circuiting is used to improve performance
// && and || operators are short-circuited
// & and | operators are not short-circuited


// Non-short-circuiting AND operator (&) => always evaluates both operands
Console.WriteLine(true & true);  
Console.WriteLine(true & false);   
Console.WriteLine(false & true);   
Console.WriteLine(false & false);  


// & is equivalent to && but it is not short-circuited => it always evaluates both operands even if the first operand is false 



// ternary operator
// condition ? expression1 : expression2
// if the condition is true, the value of the expression1 is returned, otherwise the value of the expression2 is returned
var isVIP = total >= vipThreshold ? true : false;