using CurrencyTempConverter;


while (true)
{
    Console.Clear();
    new Startup().Message();
    new Converter().Run();
    new Goodbye().PromptForAnotherConversion();
    string? input = Console.ReadLine();
    if (new Goodbye().ShouldExit(input))
    {
        new Goodbye().FarewellMessage();
        break;
    }
}