using System.Configuration;

namespace FusionAlliance.DotNetAdapters.Common.Configuration
{
    public class ConfigurationAdapter : IConfiguration
    {
        public string GetAppSetting(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }

        public ConnectionStringSettings GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name];
        }
    }
}