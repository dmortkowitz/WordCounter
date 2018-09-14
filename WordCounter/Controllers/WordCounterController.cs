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
      string userWord = Request.Form["inputWord"];
      string userSentence = Request.Form["inputSentence"];

      RepeatCounter newRepeatCounter = new RepeatCounter (userWord, userSentence);
      int count = newRepeatCounter.userCount();
      {
      return View ("Result", newRepeatCounter);
      }
    }
  }
}