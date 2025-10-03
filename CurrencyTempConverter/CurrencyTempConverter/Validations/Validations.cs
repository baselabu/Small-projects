namespace CurrencyTempConverter;

public class Validations
{
    public bool IsValidChoice(string? choice)
    {
        return choice == "C" || choice == "T";
    }

    public bool IsValidCurrencyChoice(string? currencyChoice)
    {
        return currencyChoice == "1" || currencyChoice == "2";
    }

    public bool IsValidTempChoice(string? tempChoice)
    {
        return tempChoice == "1" || tempChoice == "2";
    }

    public bool IsValidDecimalInput(string? input)
    {
        return decimal.TryParse(input, out _);
    }
    public bool IsValidDoubleInput(string? input)
    {
        return double.TryParse(input, out _);
    }

    

}
