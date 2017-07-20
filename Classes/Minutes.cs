using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class Minutes
    {
        private const string ActiveValueQuarter = "R";
        private const string ActiveValue = "Y";

        private readonly IList<Lamp> _firstRow;
        private readonly IList<Lamp> _secondRow;

        public Minutes(Time time)
        {
            _firstRow = new List<Lamp>
            {
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue)
            };

            var firstRowActiveLamps = time.Minutes / 5;
            for (int i = 0; i < firstRowActiveLamps; i++)
            {
                _firstRow[i] = _firstRow[i].TurnOn();
            }

            _secondRow = new List<Lamp> { new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue) };

            var secondRowActiveLamps = time.Minutes % 5;
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