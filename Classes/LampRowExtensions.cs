namespace BerlinClock
{
    public static class LampRowExtension
    {
        public static void ActivateLamps(this Lamp[] row, int lampsToActivate)
        {
            for (var lampPosition = 0; lampPosition < lampsToActivate; lampPosition++)
            {
                row[lampPosition] = row[lampPosition].TurnOn();
            }
        }
    }
}