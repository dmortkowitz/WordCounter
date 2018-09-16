using System;
using System.Collections.Generic;

namespace WordCounter.Models {
  public class RepeatCounter {

    public static bool wordChecker (string inputWord, string inputSentence) {
      string testWord = inputWord;
      string testSentence = inputSentence;
      string[] testArray = testSentence.Split(' ');
      for (int i=0; i <testArray.Length; i++)
      if (testWord.ToUpper() == testArray[i].ToUpper()){
        return true;
      }
      return false;
    }
    public static int userCount (string inputWord, string inputSentence) {

      string[] arrayContent = inputSentence.Split (' ');
      int arrayCount = 0;

      for (int i = 0; i < arrayContent.Length; i++) 
      {
        if (inputWord.ToUpper() == arrayContent[i].ToUpper()) {
          arrayCount += 1;
        }
      }
      return arrayCount;
    }
  }
}