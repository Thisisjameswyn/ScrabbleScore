using ScrabbleScore;
using System;

namespace Program
{
  public class ScrabbleProgram
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word and I will give you a Scrabble score!");
      string enteredWord = Console.ReadLine();
      WordChecker myChecker = new WordChecker();
      myChecker.WordArray(enteredWord);
      Console.Write("Your score is: " + myChecker.GetScore());
    }
  }
}   

// public class Car
// {
//   public string MakeModel { get; set; }
//   public int Price { get; set; }
//   public string Miles { get; set; }

//   public Car(string makeModel, int price, int miles)
//   {
//       MakeModel = makeModel;
//       Price = price;
//       Miles = miles;
//   }
// }