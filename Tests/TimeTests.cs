using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Tests
{
    [TestClass]
    public class TimeTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseTime_InvalidInput_ThrowsException()
        {
            var input = "24:00:01";

            Time.Parse(input);

            Assert.Fail("Didn't throw exeption");
        }

        [TestMethod]
        public void ParseTime_ValidInput_HasExpectedValues()
        {
            var input = "24:00:00";

            var time = Time.Parse(input);

            Assert.AreEqual(time.Hours.ToString(), "24");
            Assert.AreEqual(time.Minutes.ToString(), "0");
            Assert.AreEqual(time.Seconds.ToString(), "0");
        }
    }
}
