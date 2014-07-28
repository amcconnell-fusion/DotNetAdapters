using System;

namespace FusionAlliance.DotNetAdapters.Common
{
    public interface IDateTime
    {
        DateTime Now { get; }
        DateTime Today { get; }
        DateTime UtcNow { get; }
    }
}