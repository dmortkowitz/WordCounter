using System;
using WordCounter.Models;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WordCounter.Models
{
  [TestClass]
    public class WordFinder
    {
    // test1
    [TestMethod]
    public void CheckWord_InputWord_String()
    {
    //Arrange
    RepeatCounter userInput = new RepeatCounter("chewy", "chewy is a rambunctious dog");
    //Act
    string testWord = userInput.ReturnWord();
    //Assert
    Assert.AreEqual("chewy", testWord);
    }

    // test2
    [TestMethod]
    public void CheckCountk_ReturnCount_Int()
    {
    //Arrange
    RepeatCounter userInput = new RepeatCounter("chewy", "chewy is a very chewy dog");
    //Act
    int inputCount = userInput.userCount();
    //Assert
    Assert.AreEqual(2, inputCount);
    }
  }
}
