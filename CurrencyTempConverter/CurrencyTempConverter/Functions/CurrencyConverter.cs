namespace CurrencyTempConverter;

public class CurrencyConverter
{
    public void ConvertCurrencyUSDToEUR()
    {
        Console.Write("Enter amount in USD: ");
        string? userInput = Console.ReadLine();
        if (!new Validations().IsValidDecimalInput(userInput))
        {
            Console.WriteLine($"Invalid amount entered '{userInput}'. Please enter a valid decimal number.");
            return;
        }
        else
        {
            decimal usdAmount = decimal.Parse(userInput!);
            decimal eurAmount = usdAmount * 0.9m; // Example conversion rate
            Console.WriteLine($"{usdAmount} USD is approximately {eurAmount} EUR.");
        }
    }

    public void ConvertCurrencyUSDToNOK()
    {
        Console.Write("Enter amount in USD: ");
        string? userInput = Console.ReadLine();
        if (!new Validations().IsValidDecimalInput(userInput))
        {
            Console.WriteLine($"Invalid amount entered '{userInput}'. Please enter a valid decimal number.");
            return;
        }
        else
        {
            decimal usdAmount = decimal.Parse(userInput!);
            decimal nokAmount = usdAmount * 10.0m; // Example conversion rate
            Console.WriteLine($"{usdAmount} USD is approximately {nokAmount} NOK.");
        }
    }

}
