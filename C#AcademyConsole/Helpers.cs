using C_MathGame.Models;

namespace C_MathGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static string GetName()
        {
            Console.WriteLine("Welcome. Please enter your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name Can't be empty");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static void PrintScores()
        {
            //LINQ
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2025,07,10)).OrderByDescending(x => x.Score);
            
            Console.Clear();
            Console.WriteLine("Scores");
            Console.WriteLine("-----------------------");

            foreach (var game in games)
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Score} pts");

            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Press Enter to return to Menu");
            Console.ReadLine();
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNum = random.Next(1, 99);
            int secondNum = random.Next(1, 99);

            var result = new int[2];

            while (firstNum % secondNum != 0)
            {
                firstNum = random.Next(1, 99);
                secondNum = random.Next(1, 99);
            }

            result[0] = firstNum;
            result[1] = secondNum;

            return result;
        }
        
        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Please enter an answer in number. Try Again");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
