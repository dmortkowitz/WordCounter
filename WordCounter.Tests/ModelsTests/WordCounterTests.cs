using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
namespace WordCounter.Models 
{
  [TestClass]
  public class WordFinder 
  {

    [TestMethod]
    public void CheckWord_InputWord_String() 
    {

      string inputWord = "chewy";
      string inputSentence = "chewy is a bad dog";

      Assert.AreEqual (true, RepeatCounter.wordChecker(inputWord, inputSentence));
    }

  
    [TestMethod]
    public void CheckCountk_ReturnCount_Int() 
    {

      string inputWord = "Chewy";
      string inputSentence = "Chewy is a good dog chewy";
    
      Assert.AreEqual (2, RepeatCounter.userCount (inputWord, inputSentence));
    }
  }
}