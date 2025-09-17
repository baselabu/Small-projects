

using System.Security.Cryptography.X509Certificates;

class Creatgame
{
    public static void Creator()
    {
        bool isCorrect = false;
        Random random = new Random(); // creat new number
        int randomNum = random.Next(1, 101);
        Console.Write("Guess a number between (1,100): ");
        CheckingNumber.Checker(randomNum, isCorrect);
    }
}

class Endgame
{
    public static bool Ender()
    {
        Console.Write("Do you want play again? (y/n): ");
        string answer = Console.ReadLine()!.ToLower();
        if (answer == "n" || answer == "no")
        {
            System.Console.Write("Goodbye!");
            return false;
        }
        else if (answer == "y" || answer == "yes")
        {
            return true;

        }
        else
        {
            System.Console.WriteLine($"Unkown input {answer}, only put (y/n) or (yes/no)");
            return Ender();
        }
        
    }
}

class CheckingNumber : Creatgame
{
    public static void Checker(int randomNum, bool isCorrect)
    {
        while (!isCorrect)
        {
            try
            {
                int numberGussed = Convert.ToInt32(Console.ReadLine());
                bool checkerstatus = true;
                while (checkerstatus == true)
                {

                    if (numberGussed < 1 || numberGussed > 100)
                    {
                        System.Console.WriteLine($"Number {numberGussed} is outside of the range allowed! ");
                        System.Console.Write("please put a number that is in range: ");
                        numberGussed = Convert.ToInt32(Console.ReadLine());

                    }
                    
                    else
                    {
                        break;
                        
                    }
                }


                if (numberGussed < randomNum)
                {
                    System.Console.WriteLine($"The number {numberGussed} is lower than the number AI has generated");
                    System.Console.Write("Try again: ");
                }
                else if (numberGussed > randomNum)
                {
                    System.Console.WriteLine($"The number {numberGussed} is higher than the number AI has generated");
                    System.Console.Write("Try again: ");

                }
                else
                {
                    System.Console.WriteLine("Congratulation!! you have guessed the number " + randomNum);
                    isCorrect = true;
                }


            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                break;
            }


        }
    }
}

