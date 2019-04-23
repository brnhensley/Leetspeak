using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void LeetSpeakConverter_ReturnNonAlphaInput_False()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "ab c";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("ab c", testLeetSpeak.LeetSpeakConverter(arr));
    }

    [TestMethod]
    public void LeetSpeakConverter_ReturnAThree_Three()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "abec";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("ab3c", testLeetSpeak.LeetSpeakConverter(arr));
    }

    [TestMethod]
    public void LeetSpeakConverter_ReturnAZero_Zero()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "abeco";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("ab3c0", testLeetSpeak.LeetSpeakConverter(arr));
    }

    [TestMethod]
    public void LeetSpeakConverter_ReturnAOne_One()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "abecoLl";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("ab3c01l", testLeetSpeak.LeetSpeakConverter(arr));
    }

    [TestMethod]
    public void LeetSpeakConverter_ReturnASeven_Seven()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "abecoLltT";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("ab3c01l77", testLeetSpeak.LeetSpeakConverter(arr));
    }

    [TestMethod]
    public void LeetSpeakConverter_ReturnAtwo_two()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      string arr = "sabecoLltTsS";
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.AreEqual("sab3c01l77zz", testLeetSpeak.LeetSpeakConverter(arr));
    }
  }
}
