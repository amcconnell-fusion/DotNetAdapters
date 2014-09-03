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
            environment = new EnvironmentAdapter();
        }

        private IEnvironment environment;

        [Test]
        public void MachineName_returns_expected_value()
        {
            Assert.AreEqual(Environment.MachineName, environment.MachineName);
        }
    }
}