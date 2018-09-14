using System;
using System.Collections.Generic;

namespace WordCounter.Models 
{
  public class RepeatCounter 
  {
    private string _inputWord;
    private string _inputSentence;

    public RepeatCounter (string inputWord, string inputSentence) {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }
    public void UserWord (string enteredWord) {
      _inputWord = enteredWord;
    }
    public string ReturnWord () {
      return _inputWord;
    }
    public void UserSentence (string enteredSentence) {
      _inputSentence = enteredSentence;
    }
    public string ReturnSentence () {
      return _inputSentence;
    }
    public string[] SplitSentence () {
      string[] arrayContent = _inputSentence.Split (' ');
      return arrayContent;
    }
    public int userCount () {
      string[] arrayContent = this.SplitSentence ();
      int arrayCount = 0;
      foreach (string word in arrayContent)
        arrayCount = (word.Equals (_inputWord) ? ++arrayCount : arrayCount);
      return arrayCount;
    }
  }
}