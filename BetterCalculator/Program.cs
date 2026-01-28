namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            string userInput = "";
            string operation = "";

            Console.WriteLine("Please Enter the first number: \nor Press Q at any time to quit.");
            userInput = Console.ReadLine();
            numberOne = int.Parse(userInput);
            Console.WriteLine("Please Enter the second number: \nor Press Q at any time to quit.");
            userInput = Console.ReadLine();
            numberTwo = int.Parse(userInput);


            while (userInput.ToUpper() != "Q")
            {
                Console.WriteLine("Select an operation to perform: \n + for Addition \n - for Subtraction \n * for Multiplication \n / for Division \n or Press Q to quit.");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"The result is: {numberOne + numberTwo}");
                        break;
                    case "-":
                        Console.WriteLine($"The result is: {numberOne - numberTwo}");
                        break;
                    case "*":
                        Console.WriteLine($"The result is: {numberOne * numberTwo}");
                        break;
                    case "/":
                        if (numberTwo != 0)
                        {
                            Console.WriteLine($"The result is: {numberOne / numberTwo}");
                        }
                        else
                        {
                            Console.WriteLine("Error: The result is undefined.");
                        }
                        break;
                    case "Q":
                    case "q":
                        userInput = "Q"; // to exit the loop
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected. Please try again.");
                        break;
                }
            }

            //pause
            Console.Read();
        }
    }
}
