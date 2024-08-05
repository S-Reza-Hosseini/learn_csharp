// See https://aka.ms/new-console-template for more information

using Games.consoleApp;

Game guessNumber = new GuessNumberGame("guess number",
    " guess number between 1 and 100 " +
    "try guess with minimum guess that you could "); 

Game guessWord= new GuessWordGame("guess word",
    " first choce the level of play it game and " +
    "guess word from the above words ");

var gamenet = new Gamenet(guessNumber, guessWord);

/*
gamenet.AddGame(guessNumber);
gamenet.AddGame(guessWord);
*/
gamenet.RentGame("reza");




