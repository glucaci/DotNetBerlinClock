using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class Minutes
    {
        private readonly Lamp[] _firstRow =
        {
            Lamp.Yellow, Lamp.Yellow, Lamp.Red,
            Lamp.Yellow, Lamp.Yellow, Lamp.Red,
            Lamp.Yellow, Lamp.Yellow, Lamp.Red,
            Lamp.Yellow, Lamp.Yellow
        };

        private readonly Lamp[] _secondRow =
        {
            Lamp.Yellow, Lamp.Yellow, Lamp.Yellow, Lamp.Yellow
        };

        public Minutes(Time time)
        {
            var firstRowActiveLamps = time.Minutes / 5;
            _firstRow.ActivateLamps(firstRowActiveLamps);

            var secondRowActiveLamps = time.Minutes % 5;
            _secondRow.ActivateLamps(secondRowActiveLamps);
        }
        
        public override string ToString()
        {
            var value = new StringBuilder();

            value.AppendLine(string.Join("", _firstRow.Select(lamp => lamp.ToString())));
            value.Append(string.Join("", _secondRow.Select(lamp => lamp.ToString())));

            return value.ToString();
        }
    }
}