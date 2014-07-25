using System.IO;

namespace FusionAlliance.DotNetAdapters.Common.IO
{
    public class PathAdapter : IPath
    {
        public string Combine(string path1, string path2)
        {
            return Path.Combine(path1, path2);
        }
    }
}
