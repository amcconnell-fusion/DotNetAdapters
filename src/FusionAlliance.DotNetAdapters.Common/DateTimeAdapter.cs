using System;

namespace FusionAlliance.DotNetAdapters.Common
{
    public class DateTimeAdapter : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }

        public DateTime Today
        {
            get { return DateTime.Today; }
        }

        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}