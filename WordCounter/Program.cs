using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Start()
    {
      Console.WriteLine("Let's check how frequently a word appears in the sentence.");
      Console.WriteLine("Enter a word......");
      string word = Console.ReadLine();
      string wordInput = word.ToUpper();
      Console.WriteLine("Enter a sentence......");
      string sentence = Console.ReadLine();
      CounterApp counterApp = new CounterApp(word, sentence);
      int count = counterApp.CountWords(counterApp);
      if (count > 0)
      {
        Console.WriteLine($"{wordInput} appears {count} times in your sentence.");
      }
      else
      {
        Console.WriteLine("No mathching word is found.");
      }
      Console.WriteLine("Would you like to check one more time.[Y/N]");
      string userInput = Console.ReadLine();
      string answer = userInput.ToLower();
      if (answer == "y")
      {
        Start();
      }
      else
      {
        Console.WriteLine("Good Bye");
      }

    }
    public static void Main()
    {
      Start();
    }
  }
}