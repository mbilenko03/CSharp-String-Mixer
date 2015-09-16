using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMixerUtils;

namespace StringMixerTests
{
  [TestClass]
  public class CaseSwitcherTests
  {
    [TestMethod]
    public void StringMichaelIsCaseCorrectly()
    {
      char[] input = "Michael".ToCharArray();
      string result = CaseSwitcher.CaseSwitch(input);
      Assert.AreEqual("mICHAEL", result);
    }

    [TestMethod]
    public void EmptyStringTest()
    {
      char[] input = "".ToCharArray();
      string result = CaseSwitcher.CaseSwitch(input);
      Assert.AreEqual("", result);
    }

    [TestMethod]
    public void OneLetterTest()
    {
      char[] input = "A".ToCharArray();
      string result = CaseSwitcher.CaseSwitch(input);
      Assert.AreEqual("a", result);
    }

    [TestMethod]
    public void SpecialCharacter()
    {
      char[] input = "?.,:'".ToCharArray();
      string result = CaseSwitcher.CaseSwitch(input);
      Assert.AreEqual("?.,:'", result);
    }


    [TestMethod]
    public void NullTest()
    {
      string result = CaseSwitcher.CaseSwitch(null);
      Assert.AreEqual(null, result);
    }
  }
}
