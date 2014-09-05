using System;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests
{
    [TestFixture]
    public class DateTimeAdapterTests
    {
        [SetUp]
        public void Before_each_test()
        {
            _dateTime = new DateTimeAdapter();
        }

        private IDateTime _dateTime;

        [Test]
        public void UtcNow_returns_the_expected_value()
        {
            /* This test can be off by a millisecond just depending on when
             * and how it is called. Instead of testing that both values of
             * UtcNow are equal, we will test that they are within 1 ms of
             * each other. */
            var delta = (DateTime.UtcNow - _dateTime.UtcNow).TotalMilliseconds;
            Assert.Less(delta, 1.0);
        }
    }
}