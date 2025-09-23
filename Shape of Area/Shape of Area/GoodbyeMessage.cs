

namespace Shape_of_Area;

public class GoodbyeMessage
{

    public bool AskToContinue()
    {
        bool st = true;
        Console.Write ("Do you want to perform another calculation? (y/n) or (yes/no): ");
        string? response = Console.ReadLine();
        if (!new ValidationsChecks().ValidateYesNoInput(response))
        {
            Console.WriteLine($"Invalid input {response}. Please enter 'y' or 'n' (or 'yes' or 'no').");
            AskToContinue();
        }
        else if (response?.ToLower() == "yes" || response?.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("Starting a new calculation...");
            Console.WriteLine("Let's do another one!");
            new AreaCalculator().CalculateArea();
            st = true;
        }
        else
        {
            Console.WriteLine("Thank you for using the Area Calculator. Goodbye!");
            st = false;
        }
        return st;
    }
}
