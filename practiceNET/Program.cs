using Humanizer;
// Console.WriteLine("What is your favorite Color?");

// string favoriteColor = Console.ReadLine() ?? "";
// if it's null use left side for the data type and right if it's null
// I can also do string? favoriteColor = but that means the datatype inputed 
// could be null but that's fine. Without ? it means it will be string no matter what

// Console.WriteLine($"Your favorite Color is {favoriteColor}");

// launch 1

// Console.WriteLine("Welcome to the greetings program!");

// Console.Write("What is your name? ");
// string name = Console.ReadLine()!;
// // ! at the end means don't worry it will always be string

// Console.WriteLine($"Welcom {name} It's great to meet you.");

// launch 2

Console.Write("What is your name?");
string name = Console.ReadLine()!;

Console.Write("What is your age?");
int age = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Welcome {name}! You are {age} years old!");