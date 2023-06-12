using Labb_7_XUnit_och_Acceptanstestning.Models;
using Labb_7_XUnit_och_Acceptanstestning.UI;

namespace Labb_7_XUnit_och_Acceptanstestning.Calculations
{
    public class Division
    {
        public static void Div()
        {
            // Get Inputs
            var (x, y) = Inputs.GetTwoDecimalInputs();

            // Handle Division
            decimal result = HandleDivision(x, y);

            // Show Result
            ShowResult(x, y, result);

            // Wait Before Return
            Menu.Wait();
        }

        private static void ShowResult(decimal x, decimal y, decimal result)
        {
            var CombinedResult = Results.Show(x, y, "/", result);
            Console.WriteLine(CombinedResult);
            ResultsFile.SaveCalculationResults(CombinedResult, "Division");
        }

        public static decimal HandleDivision(decimal x, decimal y) { return x / y; }
    }
}
