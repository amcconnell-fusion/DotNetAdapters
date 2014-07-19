using System.Configuration;

namespace FusionAlliance.DotNetAdapters.Common.Configuration
{
    public interface IConfiguration
    {
        string GetAppSetting(string name);
        string GetAppSetting(string name, string defaultValue);
        ConnectionStringSettings GetConnectionString(string name);
    }
}