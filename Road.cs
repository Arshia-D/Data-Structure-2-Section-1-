using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finds_the_quickest_path
{
    internal class Road
    {
        public City Destination { get; set; }
        public double Distance { get; set; } // in kilometers
        public double MaxSpeed { get; set; } // in km/h

        public Road(City destination, double distance, double maxSpeed)
        {
            Destination = destination;
            Distance = distance;
            MaxSpeed = maxSpeed;
        }

        public double TravelTime()
        {
            return Distance / MaxSpeed; // Time = Distance / Speed, in hours
        }
    }
}
