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

        public Minutes(int minutes)
        {
            if (minutes < 0)
                throw new ArgumentException("Cannot be smaller than 0", nameof(minutes));

            if (minutes > 59)
                throw new ArgumentException("Cannot be bigger than 59", nameof(minutes));


            _firstRow = new List<Lamp>
            {
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue), new Lamp(5, ActiveValueQuarter),
                new Lamp(5, ActiveValue), new Lamp(5, ActiveValue)
            };

            var firstRowActiveLamps = minutes / 5;
            for (int i = 0; i < firstRowActiveLamps; i++)
            {
                _firstRow[i] = _firstRow[i].TurnOn();
            }

            _secondRow = new List<Lamp> { new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue), new Lamp(1, ActiveValue) };

            var secondRowActiveLamps = minutes % 5;
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