using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class WordCounterControllerTest 
  {
    [TestMethod]
    public void Index_CorrectLocation_True() 
    {

      WordCounterController controller = new WordCounterController();

      ActionResult indexPage = controller.Index();

      Assert.IsInstanceOfType (indexPage, typeof(ViewResult));
    }
  }
}