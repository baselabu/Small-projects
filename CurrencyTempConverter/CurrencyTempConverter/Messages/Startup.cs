namespace CurrencyTempConverter;

public class Startup
{
    public void Message()
    {
        Console.WriteLine("Hello, and welcome to the Currency & Temperature Converter!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("C. Convert Currency");
        Console.WriteLine("T. Convert Temperature");
        Console.Write("Your choice: ");
    }

    public void TempratureMenu()
    {
        Console.WriteLine("Temperature Conversion Options:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Celsius to Kelvin");
        Console.Write("Your choice: ");
    }

    public void CurrencyMenu()
    {
        Console.WriteLine("Currency Conversion Options:");
        Console.WriteLine("1. USD to EUR");
        Console.WriteLine("2. USD to NOK");
        Console.Write("Your choice: ");
    }
}
