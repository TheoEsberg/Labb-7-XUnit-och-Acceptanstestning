using System;
using Labb_7_XUnit_och_Acceptanstestning.Models;
using Labb_7_XUnit_och_Acceptanstestning.UI;


namespace Labb_7_XUnit_och_Acceptanstestning.Calculations
{
    public class Addition
    {
        public static void Add()
        {
            // Get Inputs
            var (x, y) = Inputs.GetTwoDecimalInputs();

            // Handle Addition
            decimal result = HandleAddition(x, y);

            // Show Result
            ShowResults(x, y, result);

            // Wait Before Return
            Menu.Wait();
        }

        public static void ShowResults(decimal x, decimal y, decimal result)
        {
            var CombinedResult = Results.Show(x, y, "+", result);
            Console.WriteLine(CombinedResult);
            ResultsFile.SaveCalculationResults(CombinedResult, "Addition");
        }

        public static decimal HandleAddition(decimal x, decimal y) { return x + y; }
    }
}
