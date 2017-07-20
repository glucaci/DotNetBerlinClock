using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class Hours
    {
        private readonly Lamp[] _firstRow =
        {
            Lamp.Red, Lamp.Red, Lamp.Red, Lamp.Red
        };

        private readonly Lamp[] _secondRow =
        {
            Lamp.Red, Lamp.Red, Lamp.Red, Lamp.Red
        };

        public Hours(Time time)
        {
            var firstRowActiveLamps = time.Hours / 5;
            _firstRow.ActivateLamps(firstRowActiveLamps);

            var secondRowActiveLamps = time.Hours % 5;
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