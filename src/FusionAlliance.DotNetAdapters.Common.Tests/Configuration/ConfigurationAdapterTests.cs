using FusionAlliance.DotNetAdapters.Common.Configuration;
using NUnit.Framework;

namespace FusionAlliance.DotNetAdapters.Common.Tests.Configuration
{
    [TestFixture]
    public class ConfigurationAdapterTests
    {
        [Test]
        public void GetAppSetting_returns_configured_value()
        {
            const string configuredValue = "the config value";

            var actualValue = new ConfigurationAdapter().GetAppSetting("someConfigKeyForTesting", null);

            Assert.AreEqual(configuredValue, actualValue);
        }

        [Test]
        public void GetAppSetting_returns_default()
        {
            const string theDefault = "some default";

            var actualValue = new ConfigurationAdapter().GetAppSetting("someSettingThatDoesNotExist", theDefault);

            Assert.AreEqual(theDefault, actualValue);
        }
    }
}