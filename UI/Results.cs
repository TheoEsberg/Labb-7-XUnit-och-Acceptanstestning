using Labb_7_XUnit_och_Acceptanstestning.Models;

namespace Labb_7_XUnit_och_Acceptanstestning.UI
{
    public class Results
    {
        public static string Show(decimal x, decimal y, string opperator, decimal result)
        {
            return $"{x} {opperator} {y} = {result}";
        }

        public static void ViewPreviousResults(string fileName)
        {
            string path = ResultsFile.GetPath();
            string fullPath = Path.Combine(path, fileName);

            if (File.Exists(fullPath))
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
