using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
using System.Collections.Generic;
using System;

namespace WordCounterApp.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void Word_ReturnsWord_String()
    {
      RepeatCounter newWord = new RepeatCounter("hello", "hello, hello, goodbye!")
      Assert.AreEqual("hello", newWord.GetWord());
    }
  }
}
