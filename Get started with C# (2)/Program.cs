// Instance of a 'Random' class
using System.Data.Common;

Random dice = new Random();

// Call Next method on instanced class
int roll = dice.Next(1, 7);

// Print that shit
// Console.WriteLine(roll);


// New acceptable way of instantiating classes
Random newDice = new();

// No params
int roll_1 = newDice.Next();

// 1 param -> cieling
int roll_2 = newDice.Next(101);

// 2 params -> between
int roll_3 = newDice.Next(42, 101);

// Console.WriteLine($"roll 1: {roll_1}\nroll 2: {roll_2}\nroll 3: {roll_3}");


int firstVal = 555;
int secondVal = 666;

int largerVal = Math.Max(firstVal, secondVal);

// Console.Write($"The larger val is {largerVal}");


int dieRoll_1 = newDice.Next(1, 7);
int dieRoll_2 = newDice.Next(1, 7);
int dieRoll_3 = newDice.Next(1, 7);

int totalRoll = dieRoll_1 + dieRoll_2 + dieRoll_3;

Console.WriteLine($"You total roll is {totalRoll}");

if ((dieRoll_1 == dieRoll_2) || (dieRoll_2 == dieRoll_3) || (dieRoll_2 == dieRoll_3))
{
    Console.WriteLine($"You rolled double! +2 to your total: {totalRoll += 2}");
}

if (totalRoll >= 14)
{
    Console.WriteLine("You win");
} else
{
    Console.WriteLine("Try again next time");
}


Random random = new();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your subscription has expired");
} else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day");
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%");
} else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"You subscription expires within {daysUntilExpiration} days");
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
} else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires soon. Renew now!");
}



int[] inventory = [7, 14, 21, 28, 35, 42];
int sum = 0;

foreach (int i in inventory)
{
    sum += i;
    Console.WriteLine($"Sum is now {sum}");
}


string[] ids = ["A123", "B456", "C789"];

foreach (string id in ids)
{
    Console.WriteLine(id);
}

string[] idsDetect = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string id in idsDetect)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine(id);
    }
}


// Random idGenerator
Random randInt = new();

string[] orderIds = new string[5];

for (int i = 0; i < orderIds.Length; i++)
{
    int prefixNum = randInt.Next(65, 70);
    string prefixNumToStr = Convert.ToChar(prefixNum).ToString();
    string suffixStr = randInt.Next(100, 999).ToString("000");
    orderIds[i] = prefixNumToStr + suffixStr;
}

foreach (string id in orderIds)
{
    Console.WriteLine(id);
}