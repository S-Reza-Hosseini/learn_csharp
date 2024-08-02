using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public class Gamenet
{
    private Game _game;

    private List<Game> GameList = new List<Game>();
    
    public void PlayGame()
    {
        _game.Start();
    }
    public void AddGame(Game game)
    {
        GameList.Add(game);
    }
    public void RentGame()
    {
        int count = 0;
        foreach (Game item in GameList)
        {
            count++;
            Console.WriteLine($"{count}-{item.Name}");
            
        }
        
        int chooseGame;
        do
        {
            Console.WriteLine("do you which one ?\n" +
                              "1 for Guess Number  ");

            chooseGame = GetNumber();

            switch (chooseGame)
            {
                case 1:
                    _game = GameList[0];
                    PlayGame();
                    break;
                case 2:
                    _game = GameList[1];
                    PlayGame();
                    break;
            }
        } while (chooseGame != 3);
    }
    
    private int GetNumber()
    {
        bool canParseNumber = false;

        var number = 0;
        while (!canParseNumber)
        {
            //Console.WriteLine("enter number of game that you want play it :");
            canParseNumber = int.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }
}
