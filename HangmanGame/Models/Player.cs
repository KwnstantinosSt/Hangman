namespace HangmanGame.Models;

public class Player
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Wins { get; set; }
    public int Loses { get; set; }
}