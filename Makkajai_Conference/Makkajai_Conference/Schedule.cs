using System;

namespace Makkajai_Conference
{
    public class Schedule
    {
        private readonly string title;
        private readonly DateTime startTime;
        private readonly int duration;

        public Schedule(string title, DateTime startTime, int duration)
        {
            this.title = title;
            this.startTime = startTime;
            this.duration = duration;
        }

        internal string getTitle()
        {
            return title;
        }

        internal DateTime getStartTime()
        {
            return startTime;
        }

        internal int getDuration()
        {
            return duration;
        }
    }
}