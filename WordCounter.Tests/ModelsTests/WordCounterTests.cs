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
        RepeatCounter userInput = new RepeatCounter("chewy.", "chewy is a rambunctious dog");
        //Act
        string inputWord = userInput.ReturnWord();
        //Assert
        Assert.AreEqual("chewy", inputWord);
        }

        // test2
        [TestMethod]
        public void CheckBlank_ReturnInput_String()
        {
        //Arrange
        RepeatCounter userInput = new RepeatCounter("", "");
        //Act
        string inputWord = userInput.ReturnWord();
        //Assert
        Assert.AreEqual("chewy", inputWord);
        }



    }
}
