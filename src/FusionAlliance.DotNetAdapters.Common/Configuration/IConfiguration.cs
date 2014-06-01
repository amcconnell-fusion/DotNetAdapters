using System.Configuration;

namespace FusionAlliance.DotNetAdapters.Common.Configuration
{
    public interface IConfiguration
    {
        string GetAppSetting(string name);
        ConnectionStringSettings GetConnectionString(string name);
    }
}