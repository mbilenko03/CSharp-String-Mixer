using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMixerUtils;

namespace StringMixerTests
{
  [TestClass]
  public class StringReverseTests
  {
    [TestMethod]
    public void StringMichaelIsReversedCorrectly()
    {
      char[] input = "Michael".ToCharArray();
      string result = StringReverser.Reverse(input);
      Assert.AreEqual("leahciM", result);
    }

    [TestMethod]
    public void EmptyStringTest()
    {
      char[] input = "".ToCharArray();
      string result = StringReverser.Reverse(input);
      Assert.AreEqual("", result);
    }

    [TestMethod]
    public void OneLetterTest()
    {
      char[] input = "A".ToCharArray();
      string result = StringReverser.Reverse(input);
      Assert.AreEqual("A", result);
    }

    [TestMethod]
    public void NullTest()
    {
      string result = StringReverser.Reverse(null);
      Assert.AreEqual(null, result);
    }
  }
}
