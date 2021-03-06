﻿using System.Text;

namespace BerlinClock
{
    public class Clock
    {
        private readonly Hours _hours;
        private readonly Minutes _minutes;
        private readonly Seconds _seconds;

        public Clock(Time time)
        {
            _hours = new Hours(time);
            _minutes = new Minutes(time);
            _seconds = new Seconds(time);
        }

        public override string ToString()
        {
            var value = new StringBuilder();

            value.AppendLine(_seconds.ToString());
            value.AppendLine(_hours.ToString());
            value.Append(_minutes.ToString());

            return value.ToString();
        }
    }
}