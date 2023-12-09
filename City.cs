using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finds_the_quickest_path
{
    internal class City
    {
        public string Name { get; set; }
        public List<Road> Roads { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public City(string name)
        {
            Name = name;
            Roads = new List<Road>();
        }
    }
}
