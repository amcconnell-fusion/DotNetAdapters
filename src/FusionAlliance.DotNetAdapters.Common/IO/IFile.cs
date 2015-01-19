using System.IO;

namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public interface IFile
    {
        string ReadAllText(string path);
        void WriteAllText(string path, string contents);
        void AppendAllText(string path, string contents);
        bool Exists(string path);
        void Delete(string path);
        Stream OpenRead(string path);
        Stream Create(string path);

        /// <summary>
        ///     Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
        /// <param name="destFileName">The new path and name for the file.</param>
        void Move(string sourceFileName, string destFileName);
    }
}