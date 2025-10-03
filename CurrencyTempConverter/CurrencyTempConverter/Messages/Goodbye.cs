namespace CurrencyTempConverter;

public class Goodbye
{
    public void FarewellMessage()
    {
        Console.WriteLine("Thank you for using the Currency & Temperature Converter. Goodbye!");
    }

    public bool ShouldExit(string? input)
    {
        // it has to be Y to continue, and N to exit
        if (input != null && input.ToUpper() != "Y" && input.ToUpper() != "N")
        {
            Console.WriteLine($"Invalid input '{input}'. Exiting the application.");
            return true; // exit on invalid input
        }
        return input == null || input.ToUpper() != "Y";
    }

    public void PromptForAnotherConversion()
    {
        Console.Write("Do you want to perform another conversion? (Y/N): ");
    }

}
