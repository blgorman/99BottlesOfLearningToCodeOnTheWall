namespace NinetyNineBottles;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfBottles = GetInputFromUserAsInteger("How many bottles should we start with?", 6, 10000);
        int originalNumberOfBottles = numberOfBottles;
        while (numberOfBottles >= 0)
        {
            PrintVerse(numberOfBottles, originalNumberOfBottles);
            numberOfBottles--;
        }

        Console.WriteLine("The program has completed.");
    }

    public static void PrintVerse(int numberOfBottles, int originalNumberOfBottles)
    {
        int nextNumberOfBottles = numberOfBottles - 1;
        if (numberOfBottles > 2)
        {
            Console.WriteLine($"{numberOfBottles} bottles of beer on the wall, {numberOfBottles} bottles of beer. Take one down, pass it around, {nextNumberOfBottles} bottles of beer on the wall.");
        }
        else if (numberOfBottles == 2)
        {
            Console.WriteLine($"{numberOfBottles} bottles of beer on the wall, {numberOfBottles} bottles of beer. Take one down, pass it around, {nextNumberOfBottles} bottle of beer on the wall.");
        }
        else if (numberOfBottles == 1)
        {
            Console.WriteLine($"{numberOfBottles} bottle of beer on the wall, {numberOfBottles} bottle of beer. Take one down, pass it around, no more bottles of beer on the wall.");
        }
        else
        {
            Console.WriteLine($"No more bottles of beer on the wall, no more bottles of beer. Go to the store and buy some more, {originalNumberOfBottles} bottles of beer on the wall.");
        }
    }

    public static int GetInputFromUserAsInteger(string prompt, int minValue, int maxValue)
    {
        int valueFromUser = 0;
        bool success = false;
        string input = string.Empty;
        while (!success)
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine();
            success = int.TryParse(input, out valueFromUser);
            if (valueFromUser < minValue)
            {
                success = false;
            }
            else if (valueFromUser > maxValue)
            {
                success = false;
            }
            if (!success)
            {
                Console.WriteLine($"You need at least {minValue}. Please enter a whole number from {minValue} - {maxValue}");
            }
        }
        return valueFromUser;
    }
}
