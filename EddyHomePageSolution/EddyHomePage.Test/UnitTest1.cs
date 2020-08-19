using System;
using EddyHomePage.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EddyHomePage.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CommonGetIP()
        {
            string expectedIP = "192.168.0.173";

            string actualIP = Commons.GetIPAddress();
            Assert.AreEqual(expectedIP, actualIP);
        }
    }
}
