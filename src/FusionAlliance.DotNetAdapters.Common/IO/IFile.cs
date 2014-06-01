namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public interface IFile
    {
        string ReadAllText(string path);
        void WriteAllText(string path, string contents);
        void AppendAllText(string path, string contents);
        bool Exists(string path);
        void Delete(string path);
    }
}