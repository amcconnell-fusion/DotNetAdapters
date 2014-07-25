using System;
using System.Diagnostics;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests
{
    [TestFixture]
    public class EnvironmentAdapterTests
    {
        private IEnvironment environment;

        [SetUp]
        public void Before_each_test()
        {
            environment = new EnvironmentAdapter();
        }

        [Test]
        public void MachineName_returns_expected_value()
        {
            Assert.AreEqual(Environment.MachineName, environment.MachineName);
        }
    }
}
