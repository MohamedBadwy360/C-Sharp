// Single Dimensional Array

// Array Declaration
string[] friends = new string[5];

// Accessing Array Elements
friends[0] = "John";
friends[1] = "Jane";
friends[2] = "Jack";
friends[3] = "Jill";
friends[4] = "Joe";

// Iterating Array Elements
for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine(friends[i]);
}

// Array Initialization
string[] friends_2 = new string[] { "John", "Jane", "Jack", "Jill", "Joe" };
string[] friends_3 = { "John", "Jane", "Jack", "Jill", "Joe" };



// Multi Dimensional Array (2D Array)
int[,] sudoko = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};



// Jagged Array (Array of Arrays)
int[][] jaggedArray = new int[][]
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5 },
    new int[] { 6, 7, 8 }
};



// Array Slice
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] slice = numbers[3..7]; // {4, 5, 6, 7}
int[] slice_2 = numbers[3..^3]; // {4, 5, 6, 7}
int[] slice_3 = numbers[..5]; // {1, 2, 3, 4, 5}
int[] slice_4 = numbers[5..]; // {6, 7, 8, 9, 10}



// Bounds Checking
int[] numbers_2 = { 1, 2, 3, 4, 5 };
int index = 5;
if (index >= 0 && index < numbers_2.Length)
{
    Console.WriteLine(numbers_2[index]);
}
else
{
    Console.WriteLine("Index out of bounds");
}