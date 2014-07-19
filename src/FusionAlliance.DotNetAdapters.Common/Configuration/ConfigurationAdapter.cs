using System.Configuration;

namespace FusionAlliance.DotNetAdapters.Common.Configuration
{
    public class ConfigurationAdapter : IConfiguration
    {
        public string GetAppSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }

        public string GetAppSetting(string name, string defaultValue)
        {
            var val = ConfigurationManager.AppSettings[name];
            return string.IsNullOrEmpty(val) ? defaultValue : val;
        }

        public ConnectionStringSettings GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name];
        }
    }
}