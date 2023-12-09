using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finds_the_quickest_path
{
    internal class PathFinder
    {
        public List<City> FindShortestPath(Road_Data network, string startCityName, string endCityName)
        {
            Dictionary<City, double> distance = new Dictionary<City, double>();
            Dictionary<City, City> previous = new Dictionary<City, City>();
            HashSet<City> visited = new HashSet<City>();

            // Initialize distances and the start city's distance to 0
            foreach (var city in network.Cities.Values)
            {
                distance[city] = double.PositiveInfinity;
                previous[city] = null;
            }
            distance[network.Cities[startCityName]] = 0;

            while (true)
            {
                City currentCity = null;
                double shortestDistance = double.PositiveInfinity;

                // Find the city with the shortest distance
                foreach (var city in network.Cities.Values)
                {
                    if (!visited.Contains(city) && distance[city] < shortestDistance)
                    {
                        currentCity = city;
                        shortestDistance = distance[city];
                    }
                }

                if (currentCity == null)
                    break;

                visited.Add(currentCity);

                // Update distances
                foreach (var road in currentCity.Roads)
                {
                    double alt = distance[currentCity] + (road.Distance / road.MaxSpeed);
                    if (alt < distance[road.Destination])
                    {
                        distance[road.Destination] = alt;
                        previous[road.Destination] = currentCity;
                    }
                }
            }

            // Reconstruct the path from endCity to startCity
            List<City> path = new List<City>();
            City current = network.Cities[endCityName];
            while (current != null)
            {
                path.Add(current);
                current = previous[current];
            }

            path.Reverse(); // Reverse the path to start from startCity

            return path;
        }
        public string CalculateTravelTime(List<City> path)
        {
            double travelTime = 0;
            for (int i = 0; i < path.Count - 1; i++)
            {
                City currentCity = path[i];
                City nextCity = path[i + 1];
                foreach (var road in currentCity.Roads)
                {
                    if (road.Destination == nextCity)
                    {
                        travelTime += road.Distance / road.MaxSpeed;
                        break;
                    }
                }
            }

            // Convert travelTime to hours, minutes, and seconds
            int hours = (int)travelTime;
            int minutes = (int)((travelTime - hours) * 60);
            int seconds = (int)((((travelTime - hours) * 60) - minutes) * 60);
            return $"{hours} hours, {minutes} minutes, {seconds} seconds";
        }

        
    }
}
