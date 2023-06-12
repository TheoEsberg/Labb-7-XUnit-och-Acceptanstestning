using Labb_7_XUnit_och_Acceptanstestning.Models;
using Labb_7_XUnit_och_Acceptanstestning.UI;

namespace Labb_7_XUnit_och_Acceptanstestning.Calculations
{
    public class Multiplication
    {
        public static void Multi()
        {
            // Get Inputs
            var (x, y) = Inputs.GetTwoDecimalInputs();

            // Handle Multiplication
            decimal result = HandleMultiplication(x, y);

            // Show Result
            ShowResult(x, y, result);

            // Wait Before Return
            Menu.Wait();
        }

        private static void ShowResult(decimal x, decimal y, decimal result)
        {
            var CombinedResult = Results.Show(x, y, "*", result);
            Console.WriteLine(CombinedResult);
            ResultsFile.SaveCalculationResults(CombinedResult, "Multiplication");
        }

        public static decimal HandleMultiplication(decimal x, decimal y) { return x * y; }
    }
}
