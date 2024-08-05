using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public class GuessNumberGame : Game
{
    public GuessNumberGame(string name, string description)
    {
        Name = name;
        Description = description;
        _number = RandomNumber();
    }
    protected override void Play()
    {
        StartGame();
    }
    public override string Name { get; } 

    public override string Description { get; } 

    public string PlayerName { get; set; }
    
    private int _number;

    private int countGuess = 0;

    private void StartGame()
    {
        
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
                    ($"correct !! you could guess number with {countGuess} time ");
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
