namespace BerlinClock
{
    public class Seconds
    {
        private readonly Lamp _lamp = Lamp.Yellow;

        public Seconds(Time time)
        {
            var isLampActive = time.Seconds % 2 == 0;
            if (isLampActive)
            {
                _lamp = _lamp.TurnOn();
            }
        }

        public override string ToString()
        {
            return _lamp.ToString();
        }
    }
}