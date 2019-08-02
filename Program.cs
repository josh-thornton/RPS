using System;
using System.Collections.Generic;
namespace RPS
{
  class Program
  {
    static int Main(string[] args)
    {
      Console.WriteLine("It's time for some dang Rock! Paper! Scissors!");
      int winStreak = 0;
      int compWin = 0;
      int playerWin = 0;
      int draw = 0;
      while (true)
      {
        var rdm = new Random();
        int compNum = rdm.Next(1, 4);
        Console.WriteLine("Make your choice:\n1: Rock\n2: Paper\n3: Scissors");
        string playerChoice = Console.ReadLine();
        int guess = 0;
        bool isInt = Int32.TryParse(playerChoice, out guess);
        if (!isInt)
        {
          Console.WriteLine("Select 1, 2, or 3.");
          continue;
        }
        if (guess < 1 || guess > 3)
        {
          Console.WriteLine("That wasn't an option dingus");
          continue;
        }
        if (guess == compNum)
        {
          Console.WriteLine("Draw!");
          draw++;
          Console.WriteLine($"Wins: {playerWin}\nLosses: {compWin}\n Draws: {draw}\n {winStreak} wins in a row!");
          continue;
        }
        if (guess == 1 && compNum == 3)
        {
          Console.WriteLine("You win!");
          playerWin++;
          winStreak++;
          Console.WriteLine($"Wins: {playerWin}\nLosses: {compWin}\n Draws: {draw}\n {winStreak} wins in a row!");
          continue;
        }
        if (guess == 3 && compNum == 1)
        {
          Console.WriteLine("You lose :(");
          winStreak = 0;
          compWin++;
          Console.WriteLine($"Wins: {playerWin}\nLosses: {compWin}\nDraws: {draw}\n{winStreak} wins in a row!");
          continue;
        }
        if (guess > compNum)
        {
          Console.WriteLine("You win!");
          winStreak++;
          playerWin++;
          Console.WriteLine($"Wins: {playerWin}\nLosses: {compWin}\n Draws: {draw}\n {winStreak} wins in a row!");
          continue;
        }
        if (guess < compNum)
        {
          Console.WriteLine("You lose :(");
          winStreak = 0;
          compWin++;
          Console.WriteLine($"Wins: {playerWin}\nLosses: {compWin}\n Draws: {draw}\n {winStreak} wins in a row!");
          continue;
        }
      }
    }
  }
}
