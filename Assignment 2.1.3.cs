/* Assignment 2.1.3
3. Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .
Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.
Inherit square class from shape and change the calculate area logic. Add property like side of square.
Take the input from user to select circle or square and display the calculated area . no hard coded values!
*/
namespace Assignment2_1_3
{
    public class Program
    {
        // Helpful methods for input validation "GetRequiredString", "GetRequiredInt", and "GetRequiredDouble"
        // "GetRequiredString()" enables "GetRequiredInt()" and "GetRequiredDouble()" to function properly.

        /// <summary>
        /// Prompts the user for input and ensures a non-empty string is returned.
        /// </summary>
        /// <param name="prompt">The message to display to the user.</param>
        /// <returns>A non-null, non-whitespace string from the user.</returns>
        private static string GetRequiredString(string prompt)
        {
            string? input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        /// <summary>
        /// Prompts the user for an integer and ensures a valid integer is returned.
        /// </summary>
        /// <param name="prompt">The message to display to the user.</param>
        /// <returns>A valid integer from the user.</returns>
        private static int GetRequiredInt(string prompt)
        {
            int value;
            while (!int.TryParse(GetRequiredString(prompt), out value))
            {
                Console.WriteLine("Invalid input. Please enter a whole number.");
            }
            return value;
        }

        /// <summary>
        /// Prompts the user for a double and ensures a valid double is returned.
        /// </summary>
        /// <param name="prompt">The message to display to the user.</param>
        /// <returns>A valid double from the user.</returns>
        private static double GetRequiredDouble(string prompt)
        {
            double value;
            while (!double.TryParse(GetRequiredString(prompt), out value))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            return value;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Select shape to calculate area:");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            int userChoice = GetRequiredInt("Enter your choice (1 or 2): ");

            Shape? shape = null;

            switch (userChoice)
            {
                case 1: // Circle
                    int circleId = GetRequiredInt("Enter Circle ID: ");
                    string circleName = GetRequiredString("Enter Circle Name: ");
                    string circleColor = GetRequiredString("Enter Circle Color: ");
                    double radius = GetRequiredDouble("Enter Circle Radius: ");
                    shape = new Circle(circleId, circleName, circleColor, radius);
                    break;

                case 2: // Square
                    int squareId = GetRequiredInt("Enter Square ID: ");
                    string squareName = GetRequiredString("Enter Square Name: ");
                    string squareColor = GetRequiredString("Enter Square Color: ");
                    double side = GetRequiredDouble("Enter Square Side Length: ");
                    shape = new Square(squareId, squareName, squareColor, side);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please run the program again and select 1 or 2.");
                    return;
            }

            double area = shape.CalculateArea();
            Console.WriteLine($"The area of the {shape.Name} is: {area:F2}");
        }
    }
}
