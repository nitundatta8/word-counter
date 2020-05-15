using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests{
  [TestClass]
  public class WordCounterTests{
  [TestMethod]
    public void CounterAppContructor_CreateInstanceOfCounterApp_CounterApp(){
      string word = "cat";
      string sentence = "I have a cat in the cathedral";
      CounterApp counterApp = new CounterApp(word,sentence);
      Assert.AreEqual(typeof(CounterApp),counterApp.GetType()); 
    }
    [TestMethod]
    public void ValidateStrings_CheackInput_True(){
      string word = "cat";
      string sentence = "I have a at in the cathedral";
      CounterApp counterApp = new CounterApp(word,sentence);
      bool result = counterApp.ValidateStrings(counterApp);
      Assert.AreEqual(true,result); 
    }


  }
}