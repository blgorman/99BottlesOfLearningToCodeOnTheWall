using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Inputs (Strings)
        Console.WriteLine("Enter your character's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your character's class (e.g., Wizard, Fighter):");
        string characterClass = Console.ReadLine();

        // 2. Random Number Generation
        // We use 'Random' to generate numbers.
        Random dice = new Random();

        // 3. Stats (Integers)
        // We use int because you can't have 15.5 Strength.
        int strength = dice.Next(3, 19); // Generates 3 to 18
        int dexterity = dice.Next(3, 19);
        int constitution = dice.Next(3, 19);
        int intelligence = dice.Next(3, 19);
        int wisdom = dice.Next(3, 19);
        int charisma = dice.Next(3, 19);

        // 4. Calculations
        int totalScore = strength + dexterity + constitution + intelligence + wisdom + charisma;
        
        // We cast (convert) totalScore to double so we get a decimal result.
        // If we didn't, 70 / 6 would be 11, not 11.66.
        double averageScore = (double)totalScore / 6.0;
        /* Optional - double vs. integer division: 
        int averageScoreNoDecimals = totalScore / 6;
        Console.WriteLine($"Double: {averageScore} and Integer {averageScoreNoDecimals}");
        */

        // 5. Output
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Name:  {name}");
        Console.WriteLine($"Class: {characterClass}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"STR: {strength}");
        Console.WriteLine($"DEX: {dexterity}");
        Console.WriteLine($"CON: {constitution}");
        Console.WriteLine($"INT: {intelligence}");
        Console.WriteLine($"WIS: {wisdom}");
        Console.WriteLine($"CHA: {charisma}");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Total Power: {totalScore}");
        // F2 formats the number to 2 decimal places
        Console.WriteLine($"Average:     {averageScore:F2}"); 
        Console.WriteLine("-----------------------------");
    }
}
