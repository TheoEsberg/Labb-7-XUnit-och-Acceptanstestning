
namespace Labb_7_XUnit_och_Acceptanstestning.UI
{
    public class Inputs
    {
        public static decimal GetDecimalInput(string prompt, TextReader reader = null)
        {
            if (reader == null)
            {
                reader = Console.In;
            }

            while (true)
            {
                Console.WriteLine(prompt);
                string input = reader.ReadLine();

                if (decimal.TryParse(input, out decimal result)) return result;
                Console.WriteLine("Invalid input. Please write a valid integer or decimal.\n");
            }
        }

        public static (decimal, decimal) GetTwoDecimalInputs()
        {
            // Get the values
            decimal value1 = GetDecimalInput("Enter your first value: ");
            decimal value2 = GetDecimalInput("Enter your second value: ");

            // Return the values as a Tuple
            return (value1, value2);
        }
    }
}
