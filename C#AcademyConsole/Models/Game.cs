using System.ComponentModel.DataAnnotations;

namespace C_AcademyConsole.Models;

internal class Game
{
    private int score;

    //public int Score
    //{
    //    get { return score; }
    //    set { score = value; }
    //} another way to make getter & setter
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public GameType Type { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
