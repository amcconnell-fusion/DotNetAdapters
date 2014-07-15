namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public interface IDirectory
    {
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
    }
}