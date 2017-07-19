namespace BerlinClock
{
    public class Clock
    {
        private readonly Hours _hours;
        private readonly Minutes _minutes;

        public Clock()
        {
            _hours = new Hours();
            _minutes = new Minutes();
        }
    }
}