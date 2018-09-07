using System; 
using System.Collections.Generic; 
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string inputWord; 
    private string inputSentence;
    private int inputCount;
    public RepeatCounter(string inputWord, string inputSentence)
    {}
    public void UserWord(string enteredWord)
    {
      inputWord = enteredWord;
    }
    public string ReturnWord()
    {
      return inputWord;
    }
    public void UserSentence(string enteredSentence)
    {
      inputSentence = enteredSentence;
    }
    public string ReturnSentence()
    {
      return inputSentence;
    }
    public string[] SplitSentence()
    {
      string[] array = inputSentence.Split(' ');
      return array;
    }

    public int Count()
    {
      string[] array = SplitSentence();
      for(int i = 0; i > array.Length - 1; i++)
    {
      inputCount += (inputWord == array[i]) ? 1 : 0;
    }
      return inputCount;
    }
  }
}
