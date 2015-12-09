using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    public struct Location
    {
        private const int LatitudeMin = 0;
        private const int LatitudeMax = 90;
        private const int LongitudeMin = 0;
        private const int LongitudeMax = 180;

        private Planet planet;
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            :this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < LatitudeMin || value > LatitudeMax)
                {
                    throw new ArgumentOutOfRangeException("latitude", "Latitude must be in the range [0...90] degrees.");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < LongitudeMin || value > LongitudeMax)
                {
                    throw new ArgumentOutOfRangeException("longitude", "Longitude must be in the range [0...180].");
                }

                this.longitude = value;
            }
        }

        public Planet Planet
        {
            get { return this.planet; }
            set { this.planet = value; }
        }

        public override string ToString()
        {
            return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
        }
    }
}
