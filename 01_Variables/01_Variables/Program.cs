// 1. Declaration [ <datatype> <identifier>; 
int number;

// 2. Assignment [ <identifier> = <value>; ]
number = 10;

// 3. Initialization [ <datatype> <identifier> = <initial value>; ]
int number2 = 10;

// string reference type
string s1;

s1 = "Moahmed";

string s2 = "Ahmed";

// regular concatenation (plus operator)
string s3 = s1 + " " + s2;
Console.WriteLine(s3);  // Moahmed Ahmed

// string interpolation
string s4 = $"{s1} {s2}";
Console.WriteLine(s4);  // Moahmed Ahmed


// int data type values
Console.WriteLine($"int: [{int.MinValue} -> {int.MaxValue}]");  // int: [-2147483648 -> 2147483647]
Console.WriteLine($"uint: [{uint.MinValue} -> {uint.MaxValue}]");  // uint: [0 -> 4294967295]

Console.WriteLine($"byte: [{byte.MinValue} -> {byte.MaxValue}]");  // byte: [0 -> 255]
Console.WriteLine($"sbyte: [{sbyte.MinValue} -> {sbyte.MaxValue}]");    // sbyte: [-128 -> 127]

Console.WriteLine($"short: [{short.MinValue} -> {short.MaxValue}]");  // short: [-32768 -> 32767]
Console.WriteLine($"ushort: [{ushort.MinValue} -> {ushort.MaxValue}]");  // ushort: [0 -> 65535]

Console.WriteLine($"long: [{long.MinValue} -> {long.MaxValue}]");  // long: [-9223372036854775808 -> 9223372036854775807]
Console.WriteLine($"ulong: [{ulong.MinValue} -> {ulong.MaxValue}]");  // ulong: [0 -> 18446744073709551615]

Console.WriteLine($"float: [{float.MinValue} -> {float.MaxValue}]");  // float: [-3.402823E+38 -> 3.402823E+38]
Console.WriteLine($"double: [{double.MinValue} -> {double.MaxValue}]");  // double: [-1.79769313486232E+308 -> 1.79769313486232E+308]
Console.WriteLine($"decimal: [{decimal.MinValue} -> {decimal.MaxValue}]");  // decimal: [-79228162514264337593543950335 -> 79228162514264337593543950335]



// var keyword (implicitly typed local variables) => type inference
var s = "hello";

var i = 0;      // int
var f = 0f;     // float
var d = 0d;     // double
var m = 0m;     // decimal
var u = 0u;     // uint
var l = 0l;     // long
var ul = 0ul;   // ulong

int oneMillion = 1_000_000;     // 1000000

var x = 10;
// x = "hello";    // Error: Cannot implicitly convert type 'string' to 'int'

// dynamic keyword (late binding) => type checking at runtime
dynamic y = "hello";
y = 10;    // no error
y = new List<int>();    // no error



// char data type
char c = 'A';