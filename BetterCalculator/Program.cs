//Kyson Hensley
//RCET2265
//Fall 2025
//Better Calculator Program
//

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int firstNumber = 0;
            int secondNumber = 0;
            bool userHasQuit = false;



            while (!userHasQuit)
            {
                while (true)
                {
                    Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.");
                    Console.Write("Choose a Number: ");
                    string userInput = Console.ReadLine();

                    if (userInput == "Q")
                    {
                        userHasQuit = true;
                        break;
                    }
                    

                    if (int.TryParse(userInput, out firstNumber))
                    {
                        Console.WriteLine($"You entered \"{userInput}\"");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You entered \"{userInput}\", please enter a whole number.");
                    }



                }

                if (userHasQuit) break;

                while (true)
                {
                    Console.Write("Choose a Number: ");
                    string userInput = Console.ReadLine();

                    if (userInput == "Q")
                    {
                        userHasQuit = true;
                        break;
                    }
                    

                    if (int.TryParse(userInput, out secondNumber))
                    {
                        Console.WriteLine($"You entered \"{userInput}\"");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You entered \"{userInput}\", please enter a whole number.");
                    }



                }

                    while (true)
                    {
                    Console.WriteLine("Choose one of the following options:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    string userInput = Console.ReadLine();

                    if (userInput == "Q")
                    {
                        userHasQuit = true;
                        break;
                    }
                   

                        Console.WriteLine($"You entered \"{userInput}\"");
                    bool validOperation = true;

                    switch (userInput)
                    {
                        case "1":
                            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                            break;
                        case "2":
                            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                            break;
                        case "3":
                            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                            break;
                        case "4":
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber}");
                            break;
                        default:
                            validOperation = false;
                            break;

                    }

                    if (validOperation)
                        break;
                }
            }

            Console.WriteLine("Have a nice day!");
            Console.WriteLine("Press enter to close this window");
            Console.ReadLine();
        }
    }
}