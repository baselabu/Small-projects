// See https://aka.ms/new-console-template for more information
Console.WriteLine(
    "Hello, and welcome to the number guessing game!"
    + "\n" +"A number between 1 and 100 will be generated and your job is to guess what that number is"
);


while (true)
{
    Creatgame.Creator();
    if (!Endgame.Ender())
    {
        break;
    }
}


