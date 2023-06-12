using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7_XUnit_och_Acceptanstestning.Models
{
    public class ResultsFile
    {
        public static string GetPath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            // Navigate back three levels to reach the desired folder
            string desiredFolder = Path.Combine(currentDirectory, "..", "..", "..", "Models", "PreviousCalculations");
            string folderPath = Path.GetFullPath(desiredFolder);
            Directory.CreateDirectory(folderPath);

            return folderPath;
        }

        public static void SaveCalculationResults(String result, string fileName)
        {
            string filePath = GetPath();

            string singleResultPath = Path.Combine(filePath, fileName + "Results.txt");
            string combinedResultPath = Path.Combine(filePath, "PreviousResults.txt");

            using (StreamWriter sw = new StreamWriter(singleResultPath, true))
            {
                sw.WriteLine(result);
            }

            using (StreamWriter sw = new StreamWriter(combinedResultPath, true))
            {
                sw.WriteLine(result);
            }
        }
    }
}
