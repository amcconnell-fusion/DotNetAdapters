using System;

namespace FusionAlliance.DotNetAdapters.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}