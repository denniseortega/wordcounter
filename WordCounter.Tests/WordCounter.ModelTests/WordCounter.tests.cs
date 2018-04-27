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
    public void GetCountWord_ReturnsWordCount_InString()
    {
      Assert.AreEqual(3, WordCounterGenerator.CountWord("hello", "hello, hello, goodbye!"));
    }
  }
}
