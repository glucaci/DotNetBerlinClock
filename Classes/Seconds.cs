using System;

namespace BerlinClock
{
    public class Seconds
    {
        private const string ActiveValue = "Y";

        private readonly Lamp _lamp;

        public Seconds(int seconds)
        {
            if (seconds < 0)
                throw new ArgumentException("Cannot be smaller than 0", nameof(seconds));

            if (seconds > 59)
                throw new ArgumentException("Cannot be bigger than 59", nameof(seconds));

            var isLampActive = seconds % 2 == 0;

            _lamp = new Lamp(1, ActiveValue, isLampActive);
        }

        public override string ToString()
        {
            return _lamp.ToString();
        }
    }
}