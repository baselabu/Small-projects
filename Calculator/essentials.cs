

class Testing
{
    public static void Operation(float num1, float num2, string operationType)
    {
        try
        {
            if (operationType == "+")
            {
                Console.WriteLine("the answer of your operation is: " + (num1 + num2));
            }
            else if (operationType == "-")
            {
                Console.WriteLine("the answer of your operation is: " + (num1 - num2));
            }
            else if (operationType == "*")
            {
                Console.WriteLine("the answer of your operation is: " + num1 * num2);
            }
            else if (operationType == "/")
            {
                Console.WriteLine("the answer of your operation is: " + ((double)num1 / num2).ToString("F3"));
            }
            else
            {
                throw new Exception("Invalid operation.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
                