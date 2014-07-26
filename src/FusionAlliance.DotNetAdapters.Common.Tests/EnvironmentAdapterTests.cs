using System;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests
{
    [TestFixture]
    public class EnvironmentAdapterTests
    {
        [SetUp]
        public void Before_each_test()
        {
            _environment = new EnvironmentAdapter();
        }

        private IEnvironment _environment;

        [Test]
        public void MachineName_returns_expected_value()
        {
            Assert.AreEqual(Environment.MachineName, _environment.MachineName);
        }
    }
}