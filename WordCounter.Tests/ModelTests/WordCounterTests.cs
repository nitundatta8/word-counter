using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests{
  [TestClass]
  public class WordCounterTests{
  [TestMethod]
    public void CounterAppContructor_CreateInstanceOfCounterApp_CounterApp(){
      string word = "cat";
      string sentence = "I have a cat in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      Assert.AreEqual(typeof(CounterApp),counterApp.GetType()); 
    }
    [TestMethod]
    public void ValidateStrings_CheackInput_True(){
      string word = "cat";
      string sentence = "I have a cat in the cathedral";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.ValidateStrings(counterApp);
      Assert.AreEqual(true,result); 
    }
    [TestMethod]
    public void ValidateStrings_CheackInput_False(){
      string word = "cat12";
      string sentence = "I have& a cat% in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.ValidateStrings(counterApp);
      Assert.AreEqual(false,result); 
    }
    [TestMethod]
    public void IsSrtingNullOrEmpty_CheackInputNullOrEmpty_True(){
      string word = "cat";
      string sentence = "I have a cat in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.IsSrtingNullOrEmpty(counterApp);
      Assert.AreEqual(true,result); 
    }
    [TestMethod]
    public void IsSrtingNullOrEmpty_CheackInputNullOrEmpty_False(){
      string word = "cat";
      string sentence = "";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.IsSrtingNullOrEmpty(counterApp);
      Assert.AreEqual(false,result); 
    }
    [TestMethod]
    public void ContainWord_CheackWordContain_True(){
      string word = "Cat";
      string sentence = "I have a cat in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.ContainWord(counterApp);
      Assert.AreEqual(true,result); 
    }
    [TestMethod]
    public void ContainWord_CheackWordContain_False(){
      string word = "Cathe";
      string sentence = "I have a cat in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.ContainWord(counterApp);
      Assert.AreEqual(false,result); 
    }
    [TestMethod]
    public void CountWords_CountMatchesWords_CounterApp(){
      string word = "Cat";
      string sentence = "I have a cat in the cathedral.";
      CounterApp counterApp = new CounterApp(word,sentence);
      int result = counterApp.CountWords(counterApp);
      Assert.AreEqual(1,result); 
    }


  }
}