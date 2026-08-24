namespace BattleBot;

public class Program
{
    public static void Main(string[] args)
    {
        int energy = 100;

        // 1. Ternary for status
        string status = (energy > 20) ? "Ready" : "Critical";
        Console.WriteLine($"System Status: {status}");

        // 2. Switch for commands
        Console.Write("Enter command: ");
        string command = Console.ReadLine();

        switch (command)
        {
            case "fire":
                Console.WriteLine("Pew Pew!");
                break;
            case "jump":
                Console.WriteLine("Whoosh!");
                break;
            case "shutdown":
                Console.WriteLine("Powering down...");
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }
}
