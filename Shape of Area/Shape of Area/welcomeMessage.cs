namespace Shape_of_Area;

public class welcomeProgramMessage
{
    public void StartMessage()
    {
        Console.WriteLine("Welcome to the Area Calculator!");
    }
    public string? WelcomeQuestion()
    {
        Console.WriteLine("What shape do you want to calculate the area for?");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.Write(": ");
        return Console.ReadLine();
    }
}
