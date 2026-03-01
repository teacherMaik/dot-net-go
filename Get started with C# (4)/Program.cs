// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

// Unassigned types use bytes for only posoitive values.    
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

int first = 2;
string second = "4";

// int sum = first + second; Willl not compile because of type mismatch. We need to convert the string to an int first.

string sum = first + second; // This will compile because of string concatenation. The int will be converted to a string and concatenated with the second string.

/*
Console.WriteLine(sum); // concatenates to string -> 24

int val = (int)1.5m; // truncates
Console.WriteLine(val);

int val2 = Convert.ToInt32(1.5m); // rounds up
Console.WriteLine(val2);


string meassurement = "102";
int result = 0;

if (int.TryParse(meassurement, out result))
{
    Console.WriteLine($"Parsed successfully: {result}");
}
else
{
    Console.WriteLine("Failed to parse the measurement.");
}

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal sumVals = 0;
string stringVals = "";

foreach (var value in values)
{
    if (decimal.TryParse(value, out decimal parsedVal))
    {
        sumVals += parsedVal;
    }
    else
    {
        stringVals += value;
    }
}

Console.WriteLine($"Sum of numeric values: {sumVals}");
Console.WriteLine($"Non-numeric values: {stringVals}");

string[] palletes = ["B13", "A11", "B11", "A13"];
Array.Sort(palletes);

Console.WriteLine("After sorting:");
foreach (var pallete in palletes)
{
    Console.WriteLine(pallete);
}

Console.WriteLine("And reversed");
Array.Reverse(palletes);
foreach (var pallete in palletes)
{
    Console.WriteLine(pallete);
}

string str = "abc123";
char[] strVals = str.ToCharArray();

Array.Reverse(strVals);

string strRev = String.Join(',', strVals);

Console.WriteLine(strRev);

string[] items = strRev.Split(',');

foreach (var item in items)
{
    Console.WriteLine(item);
}
*/

string message = "Find what is (inside the parentheses)";

int firstParenIndex = message.IndexOf('(');
int secondParenIndex = message.IndexOf(')');

int length = secondParenIndex - firstParenIndex;

string insideParens = message.Substring(firstParenIndex + 1, length - 1);

Console.WriteLine($"Msg inside parenthesis: \"{insideParens}\"");


string newMEssage = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = newMEssage.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = newMEssage.IndexOf(')');
    int newLength = closingPosition - openingPosition;
    Console.WriteLine(newMEssage.Substring(openingPosition, newLength));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed newMEssage:
    newMEssage = newMEssage.Substring(closingPosition + 1);
}
