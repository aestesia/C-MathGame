
using C_AcademyConsole.Models;

namespace C_AcademyConsole
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            var random = new Random();

            int firstNum;
            int secondNum;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNum = random.Next(0, 9);
                secondNum = random.Next(0, 9);

                Console.WriteLine($"{firstNum} + {secondNum}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNum + secondNum)
                {
                    Console.WriteLine("Correct. Press enter to Continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to Continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Your score is {score}. Press Enter to return to Menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubstractionGame(string message)
        {
            var random = new Random();

            int firstNum;
            int secondNum;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNum = random.Next(0, 9);
                secondNum = random.Next(0, 9);

                Console.WriteLine($"{firstNum} - {secondNum}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNum - secondNum)
                {
                    Console.WriteLine("Correct. Press enter to Continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to Continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Your score is {score}. Press Enter to return to Menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            var random = new Random();

            int firstNum;
            int secondNum;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {

                firstNum = random.Next(0, 9);
                secondNum = random.Next(0, 9);

                Console.WriteLine($"{firstNum} * {secondNum}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNum * secondNum)
                {
                    Console.WriteLine("Correct. Press enter to Continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to Continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Your score is {score}. Press Enter to return to Menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNum = divisionNumbers[0];
                int secondNum = divisionNumbers[1];

                Console.WriteLine($"{firstNum} / {secondNum}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNum / secondNum)
                {
                    Console.WriteLine("Correct. Press enter to Continue");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect. Press enter to Continue");
                    Console.ReadLine();
                }
            }

            Console.WriteLine($"Your score is {score}. Press Enter to return to Menu");
            Console.ReadLine();

            Helpers.AddToHistory(score, GameType.Division);

        }
    }
}
