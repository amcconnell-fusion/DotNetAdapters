using System;

namespace FusionAlliance.DotNetAdapters.Common
{
    public class EnvironmentAdapter : IEnvironment
    {
        public string MachineName
        {
            get { return Environment.MachineName; }
        }

        public void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }
    }
}