namespace FusionAlliance.DotNetAdapters.Common.IO
{
    /// <summary>
    /// File system facade.
    /// </summary>
    public interface IFileSystem : IFile, IPath, IDirectory
    {
        string ReadAllText(string path);
        void WriteAllText(string path, string contents);
        void AppendAllText(string path, string contents);
        bool Exists(string path);
        void Delete(string path);
        string Combine(string path1, string path2);
        void CreateDirectory(string path);
        void DeleteDirectory(string path);
    }
}