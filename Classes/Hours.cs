using System.Collections.Generic;

namespace BerlinClock
{
    public class Hours
    {
        private readonly IList<Lamp> _firstRow;
        private readonly IList<Lamp> _secondRow;

        public Hours()
        {
            _firstRow = new List<Lamp> { new Lamp(5), new Lamp(5), new Lamp(5), new Lamp(5) };
            _secondRow = new List<Lamp> { new Lamp(1), new Lamp(1), new Lamp(1), new Lamp(1) };
        }
    }
}