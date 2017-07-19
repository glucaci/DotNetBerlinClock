using System.Collections.Generic;

namespace BerlinClock
{
    public class Minutes
    {
        private readonly IList<Lamp> _firstRow;
        private readonly IList<Lamp> _secondRow;

        public Minutes()
        {
            _firstRow = new List<Lamp>
            {
                new Lamp(5), new Lamp(5), new Lamp(5),
                new Lamp(5), new Lamp(5), new Lamp(5),
                new Lamp(5), new Lamp(5), new Lamp(5),
                new Lamp(5), new Lamp(5)
            };

            _secondRow = new List<Lamp> { new Lamp(1), new Lamp(1), new Lamp(1), new Lamp(1) };
        }
    }
}