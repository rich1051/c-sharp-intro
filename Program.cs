// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

// How to make a string:
string string1 = "This is my first string in C#!";
string string2 = "This is my second string in C#!";

Console.WriteLine(string1);
Console.WriteLine(string2);

// How to make numbers:

// integers (small range, low precision):
int firstNumber = 4;
int secondNumber = 26;

Console.WriteLine(firstNumber + secondNumber);
Console.WriteLine(firstNumber - secondNumber);
Console.WriteLine(firstNumber * secondNumber);
Console.WriteLine(firstNumber / secondNumber);

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");


// doubles (large range, medium precision):  
double a = 5;
double b = 4;
double c = 4;
double d = (a + b) / c;

Console.WriteLine(d);

double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;

// the range of double is waaaaay bigger than the range of integers:
Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");

// decimal (medium range, high precision):
decimal decimalMin = decimal.MinValue;
decimal decimalMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");

// The M suffix on the numbers is how you indicate that a constant should use the decimal type:
decimal x = 1.0M;
decimal y = 3.0M;
Console.WriteLine(x / y);

// comparison of all number ranges side-by-side:
Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");
Console.WriteLine($"The range of integers is {min} to {max}");
Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");

// How to make a boolean:
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);   // Outputs True
Console.WriteLine(isFishTasty);   // Outputs False

int intX = 10;
int intY = 9;
Console.WriteLine(intX > intY); // returns True, because 10 is higher than 9

// How to make an if / else if / else block:
int number = 5;

if (number > 0)
{
    Console.WriteLine("The number is positive");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative");
}
else
{
    Console.WriteLine("The number is zero");
}

// How to make a switch block:
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}

// How to make a for loop:
int[] forNumbers = { 1, 2, 3, 4, 5 };

for (int i = 0; i < forNumbers.Length; i++)
{
    int currentNumber = forNumbers[i];
    Console.WriteLine("Item: " + currentNumber);
}

// How to make a foreach loop:
int[] forEachNumbers = { 6, 7, 8, 9, 10 };

foreach (var num in forEachNumbers)
{
    Console.WriteLine("Item: " + num);
}

// How to do the loop with a list instead of an array:
List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

foreach (var numero in numeros)
{
    Console.WriteLine("Item: " + numero);
}