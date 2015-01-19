namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public interface IPath
    {
        /// <summary>
        ///     Combines strings into a path.
        /// </summary>
        /// <returns>
        ///     The combined paths. If one of the specified paths is a zero-length string, this method returns the other path.
        ///     If path2 contains an absolute path, this method returns path2.
        /// </returns>
        string Combine(string path1, string path2);

        /// <summary>
        ///     Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>The path to the temporary folder, ending with a backslash.</returns>
        string GetTempPath();

        /// <summary>
        ///     Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>The full path of the temporary file.</returns>
        string GetTempFileName();
    }
}