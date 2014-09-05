namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public class FileSystemAdapter : IFileSystem
    {
        private readonly IDirectory _directory;
        private readonly IFile _file;
        private readonly IPath _path;

        public FileSystemAdapter()
            : this(new DirectoryAdapter(), new FileAdapter(), new PathAdapter())
        {
        }

        public FileSystemAdapter(IDirectory directory, IFile file, IPath path)
        {
            _directory = directory;
            _file = file;
            _path = path;
        }

        public string ReadAllText(string path)
        {
            return _file.ReadAllText(path);
        }

        public void WriteAllText(string path, string contents)
        {
            _file.WriteAllText(path, contents);
        }

        public void AppendAllText(string path, string contents)
        {
            _file.AppendAllText(path, contents);
        }

        public bool Exists(string path)
        {
            return _file.Exists(path);
        }

        public void Delete(string path)
        {
            _file.Delete(path);
        }

        public string Combine(string path1, string path2)
        {
            return _path.Combine(path1, path2);
        }

        public void CreateDirectory(string path)
        {
            _directory.CreateDirectory(path);
        }

        public void DeleteDirectory(string path)
        {
            _directory.DeleteDirectory(path);
        }
    }
}