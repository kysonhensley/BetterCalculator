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

            while (userQuit == false)
            {
                Console.WriteLine("Please enter a number: \nor enter Q anytime to quit.");
                userInputOne = Console.ReadLine();

                try
                {
                    numberOne = int.Parse(userInputOne);
                    isValidInput = false;

                }
                catch (Exception ex)
                {
                    if (userInputOne == "Q" || userInputOne == "q")
                    {
                        message = "Have a nice day!";
                        userQuit = true;
                    }
                    else
                    {
                        message = $"{userInputOne} is not a number";
                    }
                }

                userInputTwo = Console.ReadLine();

                try
                {
                    numberTwo = int.Parse(userInputTwo);
                    Console.WriteLine("Select an operation: +, -, *, / \nor enter Q anytime to quit.");
                    operation = Console.ReadLine();
                    userQuit = true;
                }
                catch (Exception ex)
                {
                    if (userInputTwo == "Q" || userInputTwo == "q")
                    {
                        message = "Have a nice day!";
                        userQuit = false;
                    }
                    else
                    {
                        message = $"{userInputTwo} is not a number";
                    }
                }


            
                switch (operation)
                {
                        case "+":
                            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
                            break;
                        case "-":
                            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
                            break;
                        case "*":
                            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
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
                            break;
                        case "Q":
                        case "q":
                            userInputOne = "Q"; // to exit the loop
                            break;
                        default:
                            Console.WriteLine("Invalid operation selected. Please try again.");
                            break;
                }
                Console.WriteLine("Press enter to continue or Q to quit.");
                
                if (Console.ReadLine() == "Q" || Console.ReadLine() == "q")
                {
                    userQuit = true;
                }
                Console.Clear();

            }

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
