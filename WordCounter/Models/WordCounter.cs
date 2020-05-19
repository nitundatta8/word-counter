using System;
namespace WordCounter.Models
{
  public class CounterApp
  {
    private string _word;
    private string _sentence;
    public CounterApp(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    private bool ValidateLetter(string wordInput)
    {
      string word = wordInput.Replace(" ", string.Empty);
      char[] charArray = word.ToLower().ToCharArray();
      foreach (char ch in charArray)
      {
        if (!Char.IsLetter(ch))
        {
          return false;
        }
      }
      return true;
    }

    public bool ValidateStrings(CounterApp counterApp)
    {
      string wordInput = counterApp._word;
      string sentenceInput = counterApp._sentence;
      bool wordResult = ValidateLetter(wordInput);
      bool sentenceResult = ValidateLetter(sentenceInput);

      if (wordResult && sentenceResult)
      {
        return true;
      }
      return false;
    }
    public bool IsSrtingNullOrEmpty(CounterApp counterApp)
    {
      string wordInput = counterApp._word;
      string sentenceInput = counterApp._sentence;
      bool word = string.IsNullOrEmpty(wordInput);
      bool sentence = string.IsNullOrEmpty(sentenceInput);
      if (!word && !sentence)
      {
        return true;
      }
      return false;
    }
    public bool ContainWord(CounterApp counterApp)
    {
      string wordInput = counterApp._word.ToLower();
      string sentenceInput = counterApp._sentence.ToLower();
      string[] sentence = sentenceInput.Split(" ");
      for (int i = 0; i < sentence.Length; i++)
      {
        if (sentence[i].Contains(wordInput))
        {
          if (sentence[i].Length == wordInput.Length)
          {
            return true;
          }
        }
      }
      return false;
    }
    public int CountWords(CounterApp counterApp)
    {
      int count = 0;
      string wordInput = counterApp._word.ToLower();
      string sentenceInput = counterApp._sentence.ToLower();
      string[] sentence = sentenceInput.Split(" ");
      for (int i = 0; i < sentence.Length; i++)
      {
        if (sentence[i].Contains(wordInput))
        {
          if (sentence[i].Length == wordInput.Length)
          {
            count++;
          }
        }
      }
      return count;
    }
  }
}