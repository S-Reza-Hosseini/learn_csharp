using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public class GuessNumberGame : Game
{
    public override string Name { get; set; } = "Guess Number";

    protected override void Play()
    {
        StartGame();
    }

    public GuessNumberGame()
    {
        _number = RandomNumber();
    }

    public string PlayerName { get; set; }
    
    private int _number;

    private int countGuess = 0;

    private void StartGame()
    {
        Console.WriteLine("enter your player name :");
        PlayerName = Console.ReadLine();
        
        
        bool Guess = false;

        while (!Guess)
        {
            countGuess++;

            int number = GetNumber();

            if (number > _number)

                Console.WriteLine($"please Enter number smaller than {number}");

            if (number < _number)
                Console.WriteLine($"please enter number grater than {number}");
            if (number == _number)
            {
                Console.WriteLine
                    ($"correct {PlayerName}!! you could guess number with {countGuess} time ");
                Guess = true;
            }
        }
    }

    private int GetNumber()
    {
        bool canParseNumber = false;

        var number = 0;
        while (!canParseNumber)
        {
            Console.WriteLine("enter your guess (between 1 to 100) :");
            canParseNumber = int.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }

    private int RandomNumber()
    {
        Random random = new Random();

        return random.Next(1, 100);
    }
}
