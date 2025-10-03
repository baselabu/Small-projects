namespace CurrencyTempConverter;

public class Converter
{
    public void Run()
    {
        string? input = Console.ReadLine();
        string? choice = input?.ToUpper() ?? string.Empty;

        Validations validations = new Validations();
        if (!validations.IsValidChoice(choice))
        {
            Console.WriteLine($"Invalid choice '{choice}'. Please restart the application and select either 'C' or 'T'.");
            return;
        }

        if (choice == "C")
        {
            new Startup().CurrencyMenu();
            string? currencyChoice = Console.ReadLine();

            if (!validations.IsValidCurrencyChoice(currencyChoice))
            {
                Console.WriteLine($"Invalid currency choice '{currencyChoice}'. Please restart the application and select either '1' or '2'.");
                return;
            }

            CurrencyConverter currencyConverter = new CurrencyConverter();

            if (currencyChoice == "1")
            {
                currencyConverter.ConvertCurrencyUSDToEUR();
            }
            else if (currencyChoice == "2")
            {
                currencyConverter.ConvertCurrencyUSDToNOK();
            }
        }
        else if (choice == "T")
        {
            new Startup().TempratureMenu();
            string? tempChoice = Console.ReadLine();
            if (!validations.IsValidTempChoice(tempChoice))
            {
                Console.WriteLine($"Invalid temperature choice '{tempChoice}'. Please restart the application and select either '1' or '2'.");
                return;
            }

            TempConverter tempConverter = new TempConverter();

            if (tempChoice == "1")
            {
                tempConverter.ConvertTemperatureFahrenheit();
            }
            else if (tempChoice == "2")
            {
                tempConverter.ConvertTemperatureKelvin();
            }
        }
    }
}
