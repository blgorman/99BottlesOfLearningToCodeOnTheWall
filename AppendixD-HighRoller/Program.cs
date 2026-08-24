namespace HighRoller;

public class Program
{
    public static void Main(string[] args)
    {
        Random rng = new Random();
        string playAgain;

        do
        {
            int totalScore = 0;
            Console.WriteLine("\n--- Starting 5 Rounds of High Roller ---");

            // The 'for' loop is perfect here because we know we want exactly 5 rounds.
            for (int round = 1; round <= 5; round++)
            {
                int roll = rng.Next(1, 7); // Generates 1 to 6
                totalScore += roll;
                Console.WriteLine($"Round {round}: You rolled a {roll}");
            }

            Console.WriteLine($"\nFinal Score: {totalScore}");

            if (totalScore > 20)
            {
                Console.WriteLine("Wow! Great score!");
            }

            Console.Write("Play again? (yes/no): ");
            playAgain = Console.ReadLine();

        } while (playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Thanks for playing!");
    }
}
