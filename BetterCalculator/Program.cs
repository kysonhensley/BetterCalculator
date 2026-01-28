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
            bool isValidInput = false;
            string message = "";
            string operation = "";

            do while (isValidInput == false)
            {
                Console.WriteLine("Please enter a number: \nor enter Q anytime to quit.");
                userInputOne = Console.ReadLine();

                try
                {
                    numberOne = int.Parse(userInputOne);
                    isValidInput = true;
                    Console.WriteLine("Please enter a second number: ");
                }
                catch (Exception ex)
                {
                    if (userInputOne == "Q" || userInputOne == "q")
                    {
                        message = "Have a nice day!";
                        isValidInput = false;
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
                    isValidInput = true;
                }
                catch (Exception ex)
                {
                    if (userInputTwo == "Q" || userInputTwo == "q")
                    {
                        message = "Have a nice day!";
                        isValidInput = false;
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
                    isValidInput = false;
                }
                Console.Clear();
            } while (userInputOne != "Q" && userInputOne != "q" && userInputTwo != "Q" && userInputTwo != "q");

            //pause
            Console.Read();
        }
    }
}
