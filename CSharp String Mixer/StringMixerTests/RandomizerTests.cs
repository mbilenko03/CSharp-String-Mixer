using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMixerUtils;

namespace StringMixerTests
{
  [TestClass]
  public class RandomizerTests
  {
    [TestMethod]
    public void StringMichaelIsCaseCorrectly()
    {
      string inputWord = "Michael";
      char[] input = inputWord.ToCharArray();
      string result = Randomizer.Randomize(input);
      Assert.IsNotNull(result);
      Assert.AreNotEqual(inputWord, result);
      Assert.AreEqual(inputWord.Length, result.Length);
    }

    [TestMethod]
    public void EmptyStringTest()
    {
      char[] input = "".ToCharArray();
      string result = Randomizer.Randomize(input);
      Assert.AreEqual("", result);
    }

    [TestMethod]
    public void OneLetterTest()
    {
      char[] input = "A".ToCharArray();
      string result = Randomizer.Randomize(input);
      Assert.AreEqual("A", result);
    }

    [TestMethod]
    public void NullTest()
    {
      string result = Randomizer.Randomize(null);
      Assert.AreEqual(null, result);
    }
  }
}
