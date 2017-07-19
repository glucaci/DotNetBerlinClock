using System;
using System.Text.RegularExpressions;

namespace BerlinClock
{
    /// <summary>
    /// Representing a 24h format time with support for 24:00:00 representation.
    /// </summary>
    public class Time
    {
        private static readonly Regex Pattern = new Regex(@"^([0-9]|0[0-9]|1[0-9]|2[0-4]):[0-5][0-9]:[0-5][0-9]$");

        public Time(short hours, short minutes, short seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public short Hours { get; }
        public short Minutes { get; }
        public short Seconds { get; }

        public static Time Parse(string time)
        {
            ValidateInput(time);

            var input = time.Split(':');
            return new Time(short.Parse(input[0]), short.Parse(input[1]), short.Parse(input[2]));
        }

        private static void ValidateInput(string time)
        {
            var parsedTime = Pattern.Match(time);
            if (!parsedTime.Success)
            {
                throw new InvalidOperationException("No valid input for time format HH:mm:ss");
            }
        }
    }
}