using System.Collections.Generic;
using System.IO;

namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public interface IDirectory
    {
        void CreateDirectory(string path);
        void DeleteDirectory(string path);

        /// <summary>
        ///     Returns an enumerable collection of file names that match a search pattern in a specified path, and optionally
        ///     searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">
        ///     The search string to match against the names of files in path. This parameter can contain a
        ///     combination of valid literal path and wildcard (* and ?) characters, but doesn't support regular expressions.
        /// </param>
        /// <param name="searchOption">
        ///     One of the enumeration values that specifies whether the search operation should include
        ///     only the current directory or should include all subdirectories.
        /// </param>
        /// <returns>
        ///     An enumerable collection of the full names (including paths) for the files in the directory specified by path
        ///     and that match the specified search pattern and option.
        /// </returns>
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
    }
}