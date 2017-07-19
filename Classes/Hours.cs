using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class Hours
    {
        private const string ActiveValue = "R";

        private readonly IList<Lamp> _firstRow;
        private readonly IList<Lamp> _secondRow;

        public Hours(int hours)
        {
            if (hours < 0)
                throw new ArgumentException("Cannot be smaller than 0", nameof(hours));

            if (hours > 24)
                throw new ArgumentException("Cannot be bigger than 24", nameof(hours));

            _firstRow = new List<Lamp> { new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValue) };

            var firstRowActiveLamps = hours / 5;
            for (int i = 0; i < firstRowActiveLamps; i++)
            {
                _firstRow[i] = _firstRow[i].TurnOn();
            }

            _secondRow = new List<Lamp> { new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue) };

            var secondRowActiveLamps = hours % 5;
            for (int i = 0; i < secondRowActiveLamps; i++)
            {
                _secondRow[i] = _secondRow[i].TurnOn();
            }
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