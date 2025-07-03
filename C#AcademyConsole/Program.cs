
using C_MathGame;

var menu = new Menu();
var date = DateTime.UtcNow;
var games = new List<string>();

String name = GetName();

menu.ShowMenu(name, date);

String GetName()
{
    Console.WriteLine("Welcome. Please enter your name");
    var name = Console.ReadLine();
    return name;
}

