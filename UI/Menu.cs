using Labb_7_XUnit_och_Acceptanstestning.Calculations;

namespace Labb_7_XUnit_och_Acceptanstestning.UI
{
    public class Menu
    {
        public static void MainChoises()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Previous Calculations");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice (1-6): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ClearConsole();
                        Console.WriteLine("You selected Addition\n");

                        // Perform addition operation
                        Addition.Add();
                        ClearConsole();
                        break;

                    case "2":
                        ClearConsole();
                        Console.WriteLine("You selected Subtraction\n");
                        
                        // Perform subtraction operation
                        Subtraction.Sub();
                        ClearConsole();
                        break;

                    case "3":
                        ClearConsole();
                        Console.WriteLine("You selected Multiplication\n");

                        // Perform multiplication operation
                        Multiplication.Multi();
                        ClearConsole();
                        break;

                    case "4":
                        ClearConsole();
                        Console.WriteLine("You selected Division\n");
                        
                        // Perform division operation
                        Division.Div();
                        ClearConsole();
                        break;

                    case "5":
                        ClearConsole();
                        Console.WriteLine("You selected Previous Calculations\n");
                        
                        // Display previous calculations
                        ResultChoises();
                        break;
                    
                    case "6":
                        // Exit the application
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    
                    default:
                        ClearConsole();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void ResultChoises()
        {
            bool exit = false;
            while (!exit)
            {
                ClearConsole();
                Console.WriteLine("Choose File to Read:");
                Console.WriteLine("1. Addition Calculations");
                Console.WriteLine("2. Subtraction Calculations");
                Console.WriteLine("3. Multiplication Calculations");
                Console.WriteLine("4. Division Calculations");
                Console.WriteLine("5. All Previous Calculations");
                Console.WriteLine("6. Return");

                Console.Write("Enter your choice (1-6): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ClearConsole();
                        Results.ViewPreviousResults("AdditionResults.txt");
                        Menu.Wait();
                        break;

                    case "2":
                        ClearConsole();
                        Results.ViewPreviousResults("SubtractionResults.txt");
                        Menu.Wait();
                        break;

                    case "3":
                        ClearConsole();
                        Results.ViewPreviousResults("MultiplicationResults.txt");
                        Menu.Wait();
                        break;

                    case "4":
                        ClearConsole();
                        Results.ViewPreviousResults("DivisionResults.txt");
                        Menu.Wait();
                        break;

                    case "5":
                        ClearConsole();
                        Results.ViewPreviousResults("PreviousResults.txt");
                        Menu.Wait();
                        break;

                    case "6":
                        ClearConsole();
                        exit = true;
                        break;

                    default:
                        ClearConsole();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void Wait()
        {
            Console.WriteLine("\nPress any key to return...");
            Console.ReadKey();
        }
    }
}
