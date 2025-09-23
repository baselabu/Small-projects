using System;

namespace Shape_of_Area;

public class ValidationsChecks
{

    public bool ValidateYesNoInput(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        input = input.ToLower();
        return input == "y" || input == "n" || input == "yes" || input == "no";
    }
    public bool ValidateShapeChoice(string? input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        return input == "1" || input == "2" || input == "3";
    }

    public bool ValidatePositiveNumber(string? input)
    {
        if (double.TryParse(input, out double number))
        {
            return number > 0;
        }
        return false;
    }


}
