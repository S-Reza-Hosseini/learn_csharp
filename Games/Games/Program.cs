// See https://aka.ms/new-console-template for more information

using Games.consoleApp;


Game guessNumber = new GuessNumberGame(); 
Game guessWord= new GuessWordGame();

var gamenet = new Gamenet();

gamenet.AddGame(guessNumber);
gamenet.AddGame(guessWord);

gamenet.RentGame();




