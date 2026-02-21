// See https://aka.ms/new-console-template for more information
using System.Linq;

// Console.WriteLine("This is the First line");
// Console.WriteLine("This is the Second Line");
// Console.WriteLine(420);
// Console.WriteLine(0.25F);

string first_name;
first_name = "Miki";

Console.WriteLine("My name is " + first_name);

var name = "Bob";
var messages = 3;
var temp = 34.4;

Console.WriteLine("Hello, " + name + "! You have " + messages + " messages in your inbox. The temperature is " + temp + " celcius");


int version = 11;
string updateTesxt = "Update to Windows";
string message = $"{updateTesxt} {version}";

Console.WriteLine(message);

int firstNum = 30;
int secondNum = 12;

Console.WriteLine(firstNum + secondNum);

string firstName = "Mikelele";
int sold = 7;

Console.WriteLine(firstName + " sold " + sold + 7 + " cards");
Console.WriteLine(firstName + " sold " + (sold + 7) + " cards");


int sum = 7 + 5;
int diff = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"diff: {diff}");
Console.WriteLine($"product: {product}");
Console.WriteLine($"quotient: {quotient}");

decimal decimalQuotient = 7.0m / 5;

Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

int first = 7;
int second = 5;

decimal quotientCast = (decimal)first / (decimal)second;

Console.WriteLine(quotientCast);


Console.WriteLine($"Module of 200/5 -> {200 % 5}");
Console.WriteLine($"Module of 7/5 -> {7 % 5}");

int orderOne = 3 + 4 * 5;
int orderTwo = (3 + 4) * 5;

Console.WriteLine(orderOne);
Console.WriteLine(orderTwo);

int farenheith = 94;
decimal celcius = ((decimal)farenheith - 32) * (5m / 9m);
Console.WriteLine($"The temperature is {celcius:F2} Celcius");



var sophiaGrades = new List<int> {93, 87, 98, 95, 100};
var nicolasGrades = new List<int> {80, 83, 82, 88, 85};
var zahirahGrades = new List<int> {84, 96, 73, 85, 79};
var jeongGrades = new List<int> {90, 92, 98, 100, 97};


decimal sopihaGrade = (decimal)sophiaGrades.Average();

Console.WriteLine(sopihaGrade);

var studentGrades = new Dictionary<string, List<int>>
{
    {"Sophia", new List<int> {93, 87, 98, 95, 100}},
    {"Nicolas", new List<int> {80, 83, 82, 88, 85}},
    {"Zahira", new List<int> {84, 96, 73, 85, 79}},
    {"Jeong", new List<int> {99, 99, 98, 100, 97}}
};

foreach(var student in studentGrades)
{
    decimal avg = (decimal)student.Value.Average();
    string letterGrade;

    if (avg >= 97)
    {
        letterGrade = "A+";
    } else if (avg >= 93)
    {
        letterGrade = "A";
    } else if (avg >= 90 )
    {
        letterGrade = "A-";
    } else if (avg >= 87)
    {
        letterGrade = "B+";
    } else
    {
        letterGrade = "B";
    }

    Console.WriteLine($"{student.Key} Average Grade is: {avg} ({letterGrade})");
}