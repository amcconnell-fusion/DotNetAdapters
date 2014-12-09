using System;

namespace FusionAlliance.DotNetAdapters.Common
{
    public class DateTimeOffsetAdapter : IDateTimeOffset
    {
        public DateTimeOffset Now
        {
            get { return DateTimeOffset.Now; }
        }

        public DateTimeOffset UtcNow
        {
            get { return DateTimeOffset.UtcNow; }
        }
    }
}