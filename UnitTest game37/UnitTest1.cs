using System;
using System.Media;
using game37;
using game37.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_game37
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SoundPlayer soundplayer = new SoundPlayer();
            Assert.IsTrue(soundplayer != null);
        }
    }
}
