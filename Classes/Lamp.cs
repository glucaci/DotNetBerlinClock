namespace BerlinClock
{
    public class Lamp
    {
        private readonly int _multiplier;
        private readonly bool _isOn = false;

        public Lamp(int multiplier, bool isOn = false)
        {
            _multiplier = multiplier;
            _isOn = isOn;
        }

        public int Multiplier => _multiplier;

        public Lamp TurnOn()
        {
            return new Lamp(_multiplier, isOn: true);
        }

        public Lamp TurnOff()
        {
            return new Lamp(_multiplier, isOn: false);
        }
    }
}