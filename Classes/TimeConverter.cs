namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string inputTime)
        {
            var time = Time.Parse(inputTime);
            var clock = new Clock(time);

            var value = clock.ToString();

            return value;
        }
    }
}
