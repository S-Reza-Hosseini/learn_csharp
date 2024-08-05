using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public class GuessWordGame : Game
{

    public GuessWordGame(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public override string Name { get;} = "Guess Word";
    public override string Description { get; } 

    protected override void Play()
    {
        StartGame();
    }
    
    public string PlayerName { get; set; }

    private string _word;

    private int countGuess = 0;

    public void StartGame()
    {
        
        Console.WriteLine("enter level for Game :\n" +
                          "1 for beginner \n" +
                          "2 for regular \n" +
                          "3 for legendery\n");
        
        int level = int.Parse(Console.ReadLine());
        switch (level)
        {
            case 1 :
                _word = BeginnerGenerateRandomWord(BeginnerWordsList());
                PlayBeginnerLevel();
                break;
            case 2 :
                _word = RegularGenerateRandomWord(RegularWordsList());
                PlayRegularLevel();
                break;
            case 3 :
                _word = LegendryGenerateRandomWord(LegendryWordsList());
                PlayLegendryLevel();
                break;
        }
    }
    private static string BeginnerGenerateRandomWord(string[] words)
    {
        Random random = new Random();
        int randomNumber  =  random.Next(1, 15);

        return words[randomNumber - 1];
    }
    private static string RegularGenerateRandomWord(string[] words)
    {
        Random random = new Random();
        int randomNumber  =  random.Next(1, 25);

        return words[randomNumber - 1];
    }
    private static string LegendryGenerateRandomWord(string[] words)
    {
        Random random = new Random();
        int randomNumber  =  random.Next(1, 50);

        return words[randomNumber - 1];
    }
    private void PlayBeginnerLevel()
    {
        ShowWordList(BeginnerWordsList());

        bool findWord = false;
        
        int countGuess = 0;
        int countAdvice = 0;
        
        while (!findWord)
        {
            string GuessWord = GetWord();
            countGuess++;

            if (_word == GuessWord)
            {
                Console.WriteLine($"well done !! your guess is correct !!");
                findWord = true;
            }
            else
            {
                Console.WriteLine("Wrong answer !! please guess again : ");

                Console.WriteLine("do you need more advice ?\n" +
                                  "please answer with (yes/no) !!");
                string advice = Console.ReadLine();

                if (advice == "yes" && countAdvice < _word.Length)
                {
                    
                    char adviceChar = _word[countAdvice];
                    countAdvice++;
                    Console.WriteLine($"char {countAdvice} of word is {adviceChar}!! ");
                    
                    
                }
            }
        }
    }
    private void PlayRegularLevel()
    {
        ShowWordList(RegularWordsList());

        bool findWord = false;
        
        int countGuess = 0;
        int countAdvice = 0;
        
        while (!findWord)
        {
            string GuessWord = GetWord();
            countGuess++;

            if (_word == GuessWord)
            {
                Console.WriteLine($"well done !! your guess is correct !!");
                findWord = true;
            }
            else
            {
                Console.WriteLine("Wrong answer !! please guess again : ");

                Console.WriteLine("do you need more advice ?\n" +
                                  "please answer with (yes/no) !!");
                string advice = Console.ReadLine();

                if (advice == "yes" && countAdvice <= 2)
                {
                    Random random = new Random();
                    int randomAdVice = random.Next(0, _word.Length);

                    char adviceChar = _word[randomAdVice];

                    Console.WriteLine($"one of the car characters " +
                                      $"of the word is {adviceChar}!! ");
                    
                    countAdvice++;
                }
            }
        }
    }
    private void PlayLegendryLevel()
    {
        ShowWordList(LegendryWordsList());

        bool findWord = false;
        int countGuess = 0;
        
        while (!findWord)
        {
            string GuessWord = GetWord();
            countGuess++;
            
            if (_word == GuessWord)
            {
                Console.WriteLine($"well done " +
                                  $"!! your guess is correct !!");
                findWord = true;
            }
            else
            {
                Console.WriteLine("Wrong answer !! please guess again : ");
                
            }
        }
    }
    private string[] BeginnerWordsList()
    {
        string[] words = new string[]
        {
            "apple", "banana", "cherry", "grape", "pineapple",
            "watermelon", "orange", "coconut", "kiwi", "lemon",
            "soap", "ocean", "sea", "swim", "island"
        };

        return words;
    }
    private string[] RegularWordsList()
    {
        string[] words = new string[]
        {
            "apple", "banana", "cherry", "grape", "pineapple",
            "watermelon", "orange", "coconut", "kiwi", "lemon",
            "mango", "carrot", "raspberry", "strawberry", "light",
            "pen", "water", "paper", "laptop", "vanilla",
            "ice", "door", "book", "music", "bag",
        };

        return words;
    }
    private string[] LegendryWordsList()
    {
        string[] words = new string[]
        {
            "apple", "banana", "cherry", "grape", "pineapple",
            "watermelon", "orange", "coconut", "kiwi", "lemon",
            "mango", "carrot", "raspberry", "strawberry", "light",
            "pen", "water", "paper", "laptop", "vanilla",
            "ice", "door", "book", "music", "bag",
            "shoe", "watch", "river", "jean", "kite",
            "salt", "tomato", "mushroom", "onion", "pepper",
            "lion", "giraffe", "sheep", "tiger", "cockroach",
            "shark", "dolphin", "rabbit", "bear", "bee",
            "soap", "ocean", "sea", "swim", "island"
        };

        return words;
    }
    
    private void ShowWordList(string[] words)
    {
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
    
    private void ShowWord()
    {
        Console.WriteLine(_word);
    }
    private string GetWord()
    {
        Console.WriteLine("Guess your word among words above :");
        return Console.ReadLine().ToLower();
    }
}
