using System;

namespace BerlinClock
{
    public class Seconds
    {
        private const string ActiveValue = "Y";

        private readonly Lamp _lamp;

        public Seconds(Time time)
        {
            var isLampActive = time.Seconds % 2 == 0;

            _lamp = new Lamp(1, ActiveValue, isLampActive);
        }

        public override string ToString()
        {
            return _lamp.ToString();
        }
    }
}