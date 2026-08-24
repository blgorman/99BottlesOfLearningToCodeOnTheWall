namespace NinetyNineBottles;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfBottles = 99;
        int nextNumberOfBottles = numberOfBottles - 1;

        Console.WriteLine($"{numberOfBottles} bottles of beer on the wall, {numberOfBottles} bottles of beer. Take one down, pass it around, {nextNumberOfBottles} bottles of beer on the wall.");
    }
}
