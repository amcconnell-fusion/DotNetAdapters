namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public class FileSystemAdapter : IFileSystem
    {
        private readonly IDirectory directoryImpl;
        private readonly IFile fileImpl;
        private readonly IPath pathImpl;

        public FileSystemAdapter()
            : this(new DirectoryAdapter(), new FileAdapter(), new PathAdapter())
        {
        }

        public FileSystemAdapter(IDirectory directory, IFile file, IPath path)
        {
            directoryImpl = directory;
            fileImpl = file;
            pathImpl = path;
        }

        public string ReadAllText(string path)
        {
            return fileImpl.ReadAllText(path);
        }

        public void WriteAllText(string path, string contents)
        {
            fileImpl.WriteAllText(path, contents);
        }

        public void AppendAllText(string path, string contents)
        {
            fileImpl.AppendAllText(path, contents);
        }

        public bool Exists(string path)
        {
            return fileImpl.Exists(path);
        }

        public void Delete(string path)
        {
            fileImpl.Delete(path);
        }

        public string Combine(string path1, string path2)
        {
            return pathImpl.Combine(path1, path2);
        }

        public void CreateDirectory(string path)
        {
            directoryImpl.CreateDirectory(path);
        }

        public void DeleteDirectory(string path)
        {
            directoryImpl.DeleteDirectory(path);
        }
    }
}