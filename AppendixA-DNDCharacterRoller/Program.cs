namespace DNDCharacterRoller;

public class Program
{
    public static void Main(string[] args)
    {
        // Appendix A Mini Challenge - The D&D Character Roller
        //
        // The Goal:
        // 1. Ask for the character's name (string).
        // 2. Ask for the character's class (string).
        // 3. Generate 6 random stats between 3 and 18 (int).
        //    Use dice.Next(3, 19) - 3 is inclusive, 19 is exclusive, so 18 is the maximum.
        // 4. Calculate the average score (double).
        //    Cast the total to a double before dividing, or C# will truncate the decimal.
        // 5. Print the character sheet.

        // Place the Random instance as the first line in Main:
        Random dice = new Random();

        // Your code goes here.
    }
}
