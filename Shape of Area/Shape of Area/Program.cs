using Shape_of_Area;

Console.Clear();
new welcomeProgramMessage().StartMessage();
new AreaCalculator().CalculateArea();
while (new GoodbyeMessage().AskToContinue())
{
    if (!new GoodbyeMessage().AskToContinue())
    {
        break;
    }
}


