using System;
using System.Formats.Asn1;

namespace CurrencyTempConverter;

public class TempConverter
{
    public void ConvertTemperatureFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        string? userTemp = Console.ReadLine();
        if (!new Validations().IsValidDoubleInput(userTemp))
        {
            Console.WriteLine($"Invalid temperature entered ('{userTemp}').");
            return;
        }
        else
        {
            double celsius = double.Parse(userTemp!);
            double fahrenheit = (celsius * 9 / 5) + 32; // Conversion formula
            Console.WriteLine($"{celsius}°C is approximately {fahrenheit}°F.");
        }
    }

    public void ConvertTemperatureKelvin()
    {
        Console.Write("Enter temperature in Celsius: ");
        string? userTemp = Console.ReadLine();
        if (!new Validations().IsValidDoubleInput(userTemp))
        {
            Console.WriteLine($"Invalid temperature entered ('{userTemp}').");
            return;
        }
        else
        {
            double celsius = double.Parse(userTemp!);
            double kelvin = celsius + 273.15; // Conversion formula
            Console.WriteLine($"{celsius}°C is approximately {kelvin}K.");
        }
    }

}
