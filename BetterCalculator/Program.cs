namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            string userInput = Console.ReadLine();

            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.");

            while (userInput != "Q")
            {
                Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.");
                Console.WriteLine("Press Q to quit");
               
            }




            Console.Read();
        }
    }
}
