namespace BerlinClock
{
    public class Lamp
    {
        public static readonly Lamp Red = new Lamp("R");
        public static readonly Lamp Yellow = new Lamp("Y");

        private const string DefaultValue = "O";

        private readonly string _activeValue;
        private readonly bool _isOn = false;

        private Lamp(string activeValue, bool isOn = false)
        {
            _activeValue = activeValue;
            _isOn = isOn;
        }

        public Lamp TurnOn()
        {
            return new Lamp(_activeValue, isOn: true);
        }

        public override string ToString()
        {
            return _isOn ? _activeValue : DefaultValue;
        }
    }
}