using Labb_7_XUnit_och_Acceptanstestning.Models;
using Labb_7_XUnit_och_Acceptanstestning.UI;

namespace Labb_7_XUnit_och_Acceptanstestning.Calculations
{
    public class Subtraction
    {
        public static void Sub()
        {
            // Get Inputs
            var (x, y) = Inputs.GetTwoDecimalInputs();

            // Handle Subtraction
            var result = HandleSubtraction(x, y);

            // Show Result
            ShowResult(x, y, result);

            // Wait Before Return
            Menu.Wait();
        }

        private static void ShowResult(decimal x, decimal y, decimal result)
        {
            var CombinedResult = Results.Show(x, y, "-", result);
            Console.WriteLine(CombinedResult);
            ResultsFile.SaveCalculationResults(CombinedResult, "Subtraction");
        }

        public static decimal HandleSubtraction(decimal x, decimal y) { return x - y; }

    }
}
