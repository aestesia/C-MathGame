// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome. Please enter your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;
int score = 0;

Menu(name, date);

void Menu(string name, DateTime date)
{
    Console.WriteLine("------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. Welcome to Math Game\n");
    Console.WriteLine(@$"Choose what to play: 
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("------------------------------------------");

    var select = Console.ReadLine();

    switch (select.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition Game");
            break;
        case "s":
            SubstractionGame("Substraction Game");
            break;
        case "m":
            MultiplicationGame("Multiplication Game");
            break;
        case "d":
            DivisionGame("Division Game");
            break;
        case "q":
            Console.WriteLine("Bye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    
    int firstNum;
    int secondNum;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNum = random.Next(0, 9);
        secondNum = random.Next(0, 9);

        Console.WriteLine($"{firstNum} + {secondNum}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum + secondNum)
        {
            Console.WriteLine("Correct");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    Console.WriteLine($"You answered correctly {score} out of 5");

}

void SubstractionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();

    int firstNum;
    int secondNum;
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        firstNum = random.Next(0, 9);
        secondNum = random.Next(0, 9);

        Console.WriteLine($"{firstNum} - {secondNum}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNum - secondNum)
        {
            Console.WriteLine("Correct");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    Console.WriteLine($"You answered correctly {score} out of 5");
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
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
            Console.WriteLine("Correct");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }

    Console.WriteLine($"You answered correctly {score} out of 5");
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

