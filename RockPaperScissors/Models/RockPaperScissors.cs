using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class RockPaperScissor
  {
    private string _player1;
    private string _player2;
    private static string _player1Choice;

    public RockPaperScissor(string player1, string player2 = "rock")
    {
      _player1 = player1;
      _player2 = player2;
    }

    public static void SetPlayer1Choice(string newChoice)
    {
      _player1Choice = newChoice;
    }

    public static string GetPlayer1Choice()
    {
      return _player1Choice;
    }

    public string GetPlayer2()
    {
      return _player2;
    }

    public string GetPlayer1()
    {
      return _player1;
    }

    public void ComputerChoice()
    {
      Random myRand = new Random();
      int compChoice = myRand.Next(1,4);
      if (compChoice == 1)
      {
        _player2 = "rock";
      }
      else if (compChoice == 2)
      {
        _player2 = "paper";
      }
      else if (compChoice == 3)
      {
        _player2 = "scissors";
      }
    }

    public string EvaluatePlay()
    {
      if (_player1 == _player2)
      {
        return "draw";
      }

      else if (_player1 == "rock")
      {
          if(_player2 == "scissors")
          {
            return "Player 1 wins";
          }
          else
          {
            return "Player 2 wins";
          }
      }

      else if (_player1 == "scissors")
      {
        if (_player2 == "paper")
        {
          return "Player 1 wins";
        }
        else
        {
          return "Player 2 wins";
        }
      }

      else
      {
        if (_player2 == "rock")
        {
          return "Player 1 wins";
        }
        else
        {
          return "Player 2 wins";
        }
      }
    }
  }
}
