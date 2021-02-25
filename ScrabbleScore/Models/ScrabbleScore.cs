//take in a word
//evaluate word, break word down into letters 
//check letters against score values (dictionary)
//return score to user
using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class WordChecker
  {
    // public string MyWordToCheck
    // // private string _wordToCheck { get; }
    private int _score = 0;
    public void WordArray(string wordToCheck)
    {
      char[] wordArray = wordToCheck.ToCharArray();
      int score = 0;
      foreach(char letter in wordArray)
      {
        string _letter = letter.ToString().ToLower();
        if(_letter == "a" || _letter == "e" || _letter == "i" || _letter == "o" || _letter == "u" || _letter == "l" || _letter == "n" || _letter == "r" || _letter == "s" || _letter == "t")
        {
          score += 1;
        }
        else if(_letter == "d" || _letter == "g")
        {
          score += 2;
        }
        else if(_letter == "b" || _letter == "c" || _letter == "m" || _letter == "p")
        {
          score += 3;
        }
        else if(_letter == "f" || _letter == "h" || _letter == "v" || _letter == "w" || _letter == "y")
        {
          score += 4;
        }
        else if(_letter == "k")
        {
          score += 5;
        }
        else if(_letter == "j" || _letter == "x")
        {
          score += 8;
        }
        else if(_letter == "q" || _letter == "z")
        {
          score += 10;
        }
      }
      SetScore(score);
    }
    public int GetScore()
    {
      return _score;
    }

    public void SetScore(int score)
    {
      _score = score;
      Console.WriteLine(_score);
    }
  }
}