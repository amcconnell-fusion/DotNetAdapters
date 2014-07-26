using System.IO;

namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public class FileSystemAdapter : IFileSystem
    {
        private readonly IDirectory directory;
        private readonly IFile file;
        private readonly IPath path;

        public FileSystemAdapter()
            : this(new DirectoryAdapter(), new FileAdapter(), new PathAdapter())
        {
        }

        public FileSystemAdapter(IDirectory directory, IFile file, IPath path)
        {
            this.directory = directory;
            this.file = file;
            this.path = path;
        }

        public string ReadAllText(string path)
        {
            return file.ReadAllText(path);
        }

        public void WriteAllText(string path, string contents)
        {
            file.WriteAllText(path, contents);
        }

        public void AppendAllText(string path, string contents)
        {
            file.AppendAllText(path, contents);
        }

        public bool Exists(string path)
        {
            return file.Exists(path);
        }

        public void Delete(string path)
        {
            file.Delete(path);
        }

        public string Combine(string path1, string path2)
        {
            return path.Combine(path1, path2);
        }

        public void CreateDirectory(string path)
        {
            directory.CreateDirectory(path);
        }

        public void DeleteDirectory(string path)
        {
            directory.DeleteDirectory(path);
        }
    }
}