
namespace Shape_of_Area;

public class AreaCalculator
{
    public void CalculateArea()
    {
        string? input = new welcomeProgramMessage().WelcomeQuestion();
        if (!new ValidationsChecks().ValidateShapeChoice(input))
        {
            Console.WriteLine($"Invalid choice {input}. Please enter 1, 2, or 3.");
            return;
        }
        switch (input)
        {
            case "1":
                Console.Write("Enter the radius of the circle: ");
                string? radiusAnswer = Console.ReadLine();
                if (!new ValidationsChecks().ValidatePositiveNumber(radiusAnswer))
                {
                    Console.WriteLine($"Invalid input {radiusAnswer}. Please enter a positive number for the radius.");
                    return;
                }
                double radius = Convert.ToDouble(radiusAnswer);
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle is {circleArea:F3}");
                break;

            case "2":
                Console.Write("Enter the length of the rectangle: ");
                string? lengthAnswer = Console.ReadLine();
                if (!new ValidationsChecks().ValidatePositiveNumber(lengthAnswer))
                {
                    Console.WriteLine($"Invalid input {lengthAnswer}. Please enter a positive number for the length.");
                    return;
                }
                double length = Convert.ToDouble(lengthAnswer);
                Console.Write("Enter the width of the rectangle: ");
                string? widthAnswer = Console.ReadLine();
                if (!new ValidationsChecks().ValidatePositiveNumber(widthAnswer))
                {
                    Console.WriteLine($"Invalid input {widthAnswer}. Please enter a positive number for the width.");
                    return;
                }
                double width = Convert.ToDouble(widthAnswer);
                double rectangleArea = length * width;
                Console.WriteLine($"The area of the rectangle is {rectangleArea}");
                break;
                

            case "3":
                Console.Write("Enter the base length of the triangle: ");
                string? baseLengthAnswer = Console.ReadLine();

                if (!new ValidationsChecks().ValidatePositiveNumber(baseLengthAnswer))
                {
                    Console.WriteLine($"Invalid input {baseLengthAnswer}. Please enter a positive number for the base.");
                    return;
                }
                double baseLength = Convert.ToDouble(baseLengthAnswer);
                Console.Write("Enter the height of the triangle: ");
                string? heightAnswer = Console.ReadLine();
                if (!new ValidationsChecks().ValidatePositiveNumber(heightAnswer))
                {
                    Console.WriteLine($"Invalid input {heightAnswer}. Please enter a positive number for the height.");
                    return;
                }
                double height = Convert.ToDouble(heightAnswer);
                double triangleArea = 0.5 * baseLength * height;
                Console.WriteLine($"The area of the triangle is {triangleArea}");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
