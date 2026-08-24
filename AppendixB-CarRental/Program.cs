namespace CarRental;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            Console.Write("Do you have a valid driver's license? (yes/no): ");
            string licenseInput = Console.ReadLine();
            bool hasLicense = licenseInput.Equals("yes", StringComparison.OrdinalIgnoreCase);

            Console.Write("Do you have insurance? (yes/no): ");
            string insuranceInput = Console.ReadLine();
            bool hasInsurance = insuranceInput.Equals("yes", StringComparison.OrdinalIgnoreCase);

            // Complex condition using && and ||
            // Case 1: Standard renter (25+, license, insurance)
            // Case 2: Young renter (21-24, license, insurance)
            if ((age >= 25 && hasLicense && hasInsurance) || 
                (age >= 21 && age < 25 && hasLicense && hasInsurance))
            {
                Console.WriteLine("Rental Approved");
                if (age < 25)
                {
                    Console.WriteLine("(Surcharge added for driver under 25)");
                }
            }
            else
            {
                Console.WriteLine("Rental Denied");
            }
        }
        else
        {
            Console.WriteLine("Invalid age entered.");
        }
    }
}
