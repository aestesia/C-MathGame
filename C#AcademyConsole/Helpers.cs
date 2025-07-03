
namespace C_AcademyConsole
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static void GetScores()
        {
            Console.Clear();
            Console.WriteLine("Scores");
            Console.WriteLine("-----------------------");

            foreach (var game in games)
                Console.WriteLine(game);

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
        
        internal static void AddToHistory(int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score: {score} pts");
        }

    }
}
