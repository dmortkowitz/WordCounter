using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers {
  public class WordCounterController : Controller 
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost ("/wordcounter/result")]
    public ActionResult Result() {
      string inputWord = Request.Form["inputWord"];
      string inputSentence = Request.Form["inputSentence"];
      Dictionary<string,object> Result = new Dictionary<string,object>{};
      
      Result.Add("Result", RepeatCounter.userCount(inputWord,inputSentence));
      {
      return View (Result);
      }
    }
  }
}