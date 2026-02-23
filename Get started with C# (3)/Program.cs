// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Diagnostics;

Random flip = new();

int numFlip = flip.Next(1, 3);

Console.WriteLine(numFlip == 1 ? "Heads" : "Tails");


string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level >= 55)
    {
        Console.WriteLine("YWelcome Super Admin");
    }
    else
    {
        Console.WriteLine("Welcome Admin");
    }
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine("Welcome Manager");
}
else
{
    Console.WriteLine("Welcome User");
}


bool flag = false;
int val = 2;

if (flag)
{
    val = 10;
    Console.WriteLine($"Inside the code block: {val}");
}

Console.WriteLine($"Outside the code block: {val}");


int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");



string sku = "01-MN-L";

string[] parts = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch(parts[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}



switch (parts[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    case "WH":
        color = "White";
        break;
    default:
        color = "Unknown";
        break;
}

switch (parts[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "Unknown";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
