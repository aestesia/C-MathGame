using C_AcademyConsole;

namespace C_MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {
            bool isOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. Welcome to Math Game\n");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine(@$"Choose what to play: 
A - Addition
S - Substraction
M - Multiplication
D - Division
V - View Previous Scores
Q - Quit the program");
                Console.WriteLine("------------------------------------------");

                var select = Console.ReadLine();

                switch (select.Trim().ToLower())
                {
                    case "a":
                        engine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        engine.SubstractionGame("Substraction Game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        engine.DivisionGame("Division Game");
                        break;
                    case "v":
                        Helpers.PrintScores();
                        break;
                    case "q":
                        Console.WriteLine("Bye");
                        isOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. type any key to try again");
                        Console.ReadLine();
                        break;
                }
            } while (isOn);
        }
    }
}
