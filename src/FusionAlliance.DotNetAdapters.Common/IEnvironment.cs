namespace FusionAlliance.DotNetAdapters.Common
{
    public interface IEnvironment
    {
        string MachineName { get; }
        void Exit(int exitCode);
    }
}