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

    bool isOn = true;

    do
    {
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
                isOn = false;
                break;
        }
    } while (isOn);
}

void AdditionGame(string message)
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

    Console.WriteLine($"Your score is {score}. Press Enter to go back to Menu");
    Console.ReadLine();

}

void SubstractionGame(string message)
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

    Console.WriteLine($"Your score is {score}. Press Enter to go back to Menu");
    Console.ReadLine();
}

void MultiplicationGame(string message)
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

    Console.WriteLine($"Your score is {score}. Press Enter to go back to Menu");
    Console.ReadLine();
}

void DivisionGame(string message)
{   
    for (int i = 0; i < 5; i++) 
    {
        Console.Clear();
        Console.WriteLine(message);
        
        var divisionNumbers = GetDivisionNumbers();
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

    Console.WriteLine($"Your score is {score}. Press Enter to go back to Menu");
    Console.ReadLine();

}

int[] GetDivisionNumbers()
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
