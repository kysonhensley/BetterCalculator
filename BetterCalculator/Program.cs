

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
            string operation = "";

            while (userQuit == false)
            {

                while (isValidInput == false)
                {
                    Console.WriteLine("Please enter a number: \nor enter Q anytime to quit.");
                    userInputOne = Console.ReadLine();
                    try
                    {
                        numberOne = int.Parse(userInputOne);
                        isValidInput = true;
                    }
                    catch (Exception)
                    {
                        if (userInputOne == "Q" || userInputOne == "q")
                        {
                            userQuit = true;
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine($"{userInputOne} is not a number");
                        }
                    }
                }

                if (userQuit == true)
                    break;

                isValidInput = false;

                while (isValidInput == false && userQuit == false)
                {
                    isValidInput = false;
                    Console.WriteLine("Please enter another number:");
                    userInputTwo = Console.ReadLine();

                    try
                    {
                        numberTwo = int.Parse(userInputTwo);
                        isValidInput = true;
                    }
                    catch
                    {
                        if (userInputTwo == "Q" || userInputTwo == "q")
                        {
                            userQuit = true;
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine($"{userInputTwo} is not a number");
                        }
                    }
                }

                if (userQuit == true)
                    break;

                isValidInput = false;
                while (isValidInput == false)
                {
                    Console.WriteLine("Select an operation: +, -, *, / \nor enter Q anytime to quit.");
                    operation = Console.ReadLine();

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
                            }
                            else
                            {
                                Console.WriteLine("Error: The result is undefined.");
                            }
                            isValidInput = true;
                            break;
                        case "Q":
                        case "q":
                            userQuit = true; // to exit the loop
                            isValidInput = true;
                            break;
                        default:
                            Console.WriteLine("Invalid operation selected. Please try again.");
                            break;
                    }
                }

                if (userQuit == true)
                    break;

                isValidInput = false;
                Console.WriteLine("Press enter to continue or Q to quit.");
                userInputOne = Console.ReadLine();
                if (userInputOne == "Q" || userInputOne == "q")
                {
                    userQuit = true;
                }
            }

            Console.Clear();
            Console.WriteLine("Have a nice day!");
            Console.WriteLine("Press Enter to close the program.");
            //pause
            Console.Read();
            }
        }
    }