using System;
using WordCounter.Models;

namespace WordCounter{
  public class Program{
    public static void Start(){
      Console.WriteLine("Let's check how frequently a word appears in the sentence.");
      Console.WriteLine("Enter a word......");
      string word = Console.ReadLine();
      string wordInput = word.ToUpper();
      Console.WriteLine("Enter a sentence......");
      string sentence = Console.ReadLine();
      CounterApp counterApp = new CounterApp(word,sentence);
      int count = counterApp.CountWords(counterApp);
      Console.WriteLine($"{wordInput} appears {count} times in your sentence.");
    }
    public static void Main(){
      Start();
    }
  }
}