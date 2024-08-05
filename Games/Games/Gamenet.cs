using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public class Gamenet
{
    public Gamenet(params Game[] games)
    {
        GameList = games.ToList();
    }
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
    public void RentGame(string playerName)
    {
        bool stillPlay = true;
        do
        {
            ShowEnteringMenu(playerName);
            ChoosingGame(GetChoice(ShowGames()), playerName);
            
            stillPlay = MenuTimeLife();
       
        } while (stillPlay);
    }
    
    private int GetChoice(string msg)
    {
        bool canParseNumber = false;

        var choice= 0;
        while (!canParseNumber)
        {
            Console.WriteLine(msg);
            canParseNumber = int.TryParse(Console.ReadLine(), out choice);
            if (choice > GameList.Count)
            {
                Console.WriteLine("Wrong Choice !!! please enter correct choice");
                canParseNumber = false;
            }
        }
        return choice;
    }

    private string ShowGames()
    {
        int count = 0;
        string msg = "";
        foreach (Game item in GameList)
        {
            count++;
            msg += $"{count}-{item.Name}\n";
            
        } 
        
        return msg ;
    }

    private void ShowEnteringMenu(string name)
    {
        Console.WriteLine($" hey {name} Welcome to us gamenet :");
        ShowGames();
        Console.WriteLine("do you which one ?");
    }

    private void ChoosingGame(int chooseGame, string name)
    {
        _game = GameList[chooseGame - 1];
        Console.WriteLine($"Dear {name} the description of game is :" +
                          $"{_game.Description} \n good luck!!");
        PlayGame();
    }

    private static bool MenuTimeLife()
    {
        Console.WriteLine("do you want still play ? (yes/no)!");
        string stillPlaying = Console.ReadLine().ToLower();

        if (stillPlaying == "no")
        {
            Console.WriteLine("Do you want really exit the gamenet ? (yes/no)");
            string exit = Console.ReadLine().ToLower();

            if (exit == "yes")
                return false;
        }

        return true;
    }
}