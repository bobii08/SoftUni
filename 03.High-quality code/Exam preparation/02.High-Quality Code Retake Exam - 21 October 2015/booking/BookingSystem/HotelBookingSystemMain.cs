namespace BookingSystem
{
    using System;
    using System.Threading;
    using System.Globalization;

    public class HotelBookingSystemMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var engine = Activator.CreateInstance(typeof(Engine)) as Engine;
            engine.StartOperation();
        }
    }
}