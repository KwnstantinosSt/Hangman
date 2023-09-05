using HangmanGame.Constants;

namespace HangmanGame.Models;

public class Library
{
    public int Id { get; set; }
    public string Word { get; set; }
    public Language Language { get; set; }
}