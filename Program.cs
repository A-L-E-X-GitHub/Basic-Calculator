namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Controls the run state of the application.
            bool runState = true;

            // While the runState is set to true, keep looping.
            while (runState)
            {

                // Clear the console for a clean window then print the
                // instructions on how to perform an operation.
                Console.Clear();
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("Select an operation to perfom:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Input: ");

                // Get the user input.
                string? input = Console.ReadLine();

                // Determine which action to perform based on input.
                switch (input)
                {
                    case "1": PerformBasicOperation("Add");      break;
                    case "2": PerformBasicOperation("Subtract"); break;
                    case "3": PerformBasicOperation("Multiply"); break;
                    case "4": PerformBasicOperation("Divide");   break;
                    case "5": runState = false;                  break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;

                }

            }

        }

        static void PerformBasicOperation(string operation)
        {
            // Space out the console text for a cleaner display.
            Console.WriteLine();
            Console.WriteLine($"{operation} operator selected.");

            // Prompt the user for two constant values to perform the operation on.
            double number01 = GetValidNumber($"Enter the first number to {operation}: ");
            double number02 = GetValidNumber($"Enter the second number to {operation}: ");
            double result = 0;

            switch (operation)
            {
                case "Add":
                    result = number01 + number02;
                    break;

                case "Subtract":
                    result = number01 - number02;
                    break;

                case "Multiply":
                    result = number01 * number02;
                    break;

                case "Divide":
                    // Handle division by zero error.
                    if (number02 == 0)
                    {
                        Console.WriteLine("Division by zero no possible.");
                        return;
                    }

                    result = number01 / number02;
                    break;
            }

            // Print the results to the user.
            Console.WriteLine();
            Console.WriteLine($"The result of the operation is: {result}");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static double GetValidNumber(string prompt)
        {

            double number;

            // Keep prompting for a number until a valid value is entered.
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // Attempt to convert the given number to a double.
                try
                {
                    number = Convert.ToDouble(input);
                    break;
                }

                // Inform the user that the given value is not a valid number.
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }

            return number;

        }

    }

}