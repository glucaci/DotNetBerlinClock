using System;

namespace BerlinClock
{
    /// <summary>
    /// Representing a 24h format time with support for 24:00:00 representation.
    /// </summary>
    public class Time
    {
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
            var input = time.Split(':');

            var hours = GetValueInRange(input[0], 0, 24);
            var minutes = GetValueInRange(input[1], 0, 59);
            var seconds = GetValueInRange(input[2], 0, 59);

            ValidateMidnightFormat(hours, minutes, seconds);

            return new Time(hours, minutes, seconds);
        }

        private static short GetValueInRange(string input, short min, short max)
        {
            short value;
            if (short.TryParse(input, out value))
            {
                if (value < min)
                {
                    throw new ArgumentException($"Input cannot be smaller than {min}");
                }

                if (value > max)
                {
                    throw new ArgumentException($"Input cannot be bigger than {max}");
                }

                return value;
            }

            throw new InvalidOperationException("Invalid input format.");
        }

        private static void ValidateMidnightFormat(short hours, short minutes, short seconds)
        {
            if (hours > 23 && (minutes != 0 || seconds != 0))
            {
                throw new InvalidOperationException("Invalid time value.");
            }
        }
    }
}