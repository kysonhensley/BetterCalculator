namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputOne = "";
            string userInputTwo = "";
            int numberOne = 0;
            int numberTwo = 0;
            bool userQuit = false;
            bool isValidInput = false;
            string message = "";
            string operation = "";

            do while (userQuit == false)
                {
                    Console.WriteLine("Please enter a number: \nor enter Q anytime to quit.");
                    userInputOne = Console.ReadLine();

                    while (isValidInput == false)
                    {
                        try
                        {
                            numberOne = int.Parse(userInputOne);
                            isValidInput = true;
                        }
                        catch (Exception ex)
                        {
                            if (userInputOne == "Q" || userInputOne == "q")
                            {
                                userQuit = true;
                                message = "Have a nice day!";
                                isValidInput = true;
                            }
                            else
                            {
                                message = $"{userInputOne} is not a number";
                            }
                        }
                    }

                    isValidInput = false;
                    Console.WriteLine("Please enter another number:");
                    userInputTwo = Console.ReadLine();

                    while (isValidInput == false)
                    {
                        try
                        {
                            numberTwo = int.Parse(userInputTwo);
                            isValidInput = true;
                        }
                        catch (Exception ex)
                        {
                            if (userInputTwo == "Q" || userInputTwo == "q")
                            {
                                isValidInput = true;
                                message = "Have a nice day!";
                                userQuit = true;
                            }
                            else
                            {
                                message = $"{userInputTwo} is not a number";
                            }
                        }
                    }

                    isValidInput = false;
                    Console.WriteLine("Select an operation: +, -, *, / \nor enter Q anytime to quit.");
                    operation = Console.ReadLine();

                    while (isValidInput == false)
                    {
                        switch (operation)
                        {
                            case "+":
                                Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
                                isValidInput = true;
                                break;
                            case "-":
                                Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
                                isValidInput = true;
                                break;
                            case "*":
                                Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
                                isValidInput = true;
                                break;
                            case "/":
                                if (numberTwo != 0)
                                {
                                    Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
                                    isValidInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error: The result is undefined.");
                                    isValidInput = true;
                                }
                                break;
                            case "Q":
                            case "q":
                                userQuit = true; // to exit the loop
                                break;
                            default:
                                Console.WriteLine("Invalid operation selected. Please try again.");
                                break;
                        }
                    }
                    Console.WriteLine("Press enter to continue or Q to quit.");
                    if (Console.ReadLine() == "Q" || Console.ReadLine() == "q")
                    {
                        userQuit = true;
                    }
                    else
                    {
                        userQuit = false;
                    }

                } while (userQuit == false);

            if (userQuit == true)
            {
                   Console.Clear();
                   Console.WriteLine("Have a nice day!");
            }
                //pause
                Console.Read();
        }
    }
}
