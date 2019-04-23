using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak
namespace LeetSpeak.Tests
{
  [TestClass]
  public class PongTest
  {
        [TestMethod]
    public void LeetSpeakConverter_ReturnNonAlphaInput_()
    {
        // any necessary logic to prep for test; instantiating new classes, etc.
        Pong testIsPong = new Pong();
        Assert.AreEqual("Ping-Pong", testIsPong.IsPong(15));
    }
  }
}
