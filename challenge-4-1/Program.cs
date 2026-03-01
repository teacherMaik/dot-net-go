// See https://aka.ms/new-console-template for more information
public class Challenge
{
    public static void Main()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] words = pangram.Split(" ");
        string finalString = "";

        foreach (string word in words)
        {
            char[] tempWordChars = word.ToCharArray();

            Array.Reverse(tempWordChars);

            string revTempWord = String.Join("", tempWordChars);
            finalString += revTempWord + " ";
        }

        finalString = finalString.TrimEnd();

        Console.WriteLine(finalString);

        // Challenge 2
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orders = orderStream.Split(",");

        Array.Sort(orders);

        foreach (var order in orders)
        {
            if (order.Length != 4)
            {
                Console.WriteLine($"{order} \t- not valid");
            }
            else
            {
                Console.WriteLine(order);
            }
        }

    }
}

