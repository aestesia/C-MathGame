
using C_MathGame;
using C_MathGame;

var menu = new Menu();
var date = DateTime.UtcNow;
var games = new List<string>();

String name = Helpers.GetName();

menu.ShowMenu(name, date);
