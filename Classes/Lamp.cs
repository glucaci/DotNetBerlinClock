namespace BerlinClock
{
    public class Lamp
    {
        private const string DefaultValue = "O";

        private readonly int _multiplier;
        private readonly string _activeValue;
        private readonly bool _isOn = false;

        public Lamp(int multiplier, string activeValue, bool isOn = false)
        {
            _multiplier = multiplier;
            _activeValue = activeValue;
            _isOn = isOn;
        }

        public int Multiplier => _multiplier;

        public Lamp TurnOn()
        {
            return new Lamp(_multiplier, _activeValue, isOn: true);
        }

        public Lamp TurnOff()
        {
            return new Lamp(_multiplier, _activeValue, isOn: false);
        }

        public override string ToString()
        {
            return _isOn ? _activeValue : DefaultValue;
        }
    }
}