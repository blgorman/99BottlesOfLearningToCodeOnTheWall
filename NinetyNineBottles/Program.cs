namespace NinetyNineBottles;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfBottles = 99;
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
}
