using System;

namespace ConsoleExample
{
    /// <summary>
    /// The main application class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                // Call with a positive value
                int positiveResult = PerformComplexCalculation(5);
                Console.WriteLine($"Result for positive input (5): {positiveResult}");

                // Call with zero
                int zeroResult = PerformComplexCalculation(0);
                Console.WriteLine($"Result for zero input: {zeroResult}");

                // Call with a negative value
                int negativeResult = PerformComplexCalculation(-3);
                Console.WriteLine($"Result for negative input (-3): {negativeResult}");

                // Call Calculator.Add
                int sum = Calculator.Add(10, 5);
                Console.WriteLine($"Result of Calculator.Add(10, 5): {sum}");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Performs a complex calculation based on the input value.
        /// </summary>
        /// <param name="inputValue">The input integer for the calculation.</param>
        /// <returns>The result of the calculation.</returns>
        public static int PerformComplexCalculation(int inputValue)
        {
            int result = 0;
            if (inputValue > 0)
            {
                for (int i = 1; i <= inputValue; i++)
                {
                    result += i * i;
                }
            }
            else if (inputValue == 0)
            {
                result = -1;
            }
            else
            {
                result = -99;
            }
            return result;
        }
    }
}
