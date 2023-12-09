using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finds_the_quickest_path
{
    internal class Road_Data
    {
        public Dictionary<string, City> Cities { get; set; }

        public Road_Data()
        {
            Cities = new Dictionary<string, City>();
            InitializeCities();
            InitializeRoads();
        }

        private void InitializeCities()
        {
            Cities.Add("Varna", new City("Varna"));
            Cities.Add("Burgas", new City("Burgas"));
            Cities.Add("Dobrich", new City("Dobrich"));
            Cities.Add("Silistra", new City("Silistra"));
            Cities.Add("Razgrad", new City("Razgrad"));
            Cities.Add("Tyrgowishte", new City("Tyrgowishte"));
            Cities.Add("Shumen", new City("Shumen"));
            Cities.Add("Veliko", new City("Veliko"));
            Cities.Add("Sliven", new City("Sliven"));
            Cities.Add("Yambol", new City("Yambol"));
            Cities.Add("Kazanlyk", new City("Kazanlyk"));
            Cities.Add("Stara Zagora", new City("Stara Zagora"));
        }

        private void InitializeRoads()
        {
            // Adding roads with hypothetical distances (in km) and maximum speeds (in km/h)
            Cities["Varna"].Roads.Add(new Road(Cities["Burgas"], 115.8, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Dobrich"], 52.6, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Silistra"], 141, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Razgrad"], 128.2, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Tyrgowishte"], 121.3, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Shumen"], 88.7, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Veliko"], 115.8, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Sliven"], 221.3, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Yambol"], 200.8, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Kazanlyk"], 297.8, 90));
            Cities["Varna"].Roads.Add(new Road(Cities["Stara Zagora"], 279.5, 90));
            //
            Cities["Dobrich"].Roads.Add(new Road(Cities["Varna"], 52.6, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Burgas"], 150.4, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Silistra"], 80.2, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Razgrad"], 35.7, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Tyrgowishte"], 70.9, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Shumen"], 60.3, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Veliko"], 120.8, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Sliven"], 160.2, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Yambol"], 140.5, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Kazanlyk"], 230.1, 90));
            Cities["Dobrich"].Roads.Add(new Road(Cities["Stara Zagora"], 210.9, 90));
            //
            Cities["Burgas"].Roads.Add(new Road(Cities["Varna"], 115.8, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Dobrich"], 150.4, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Silistra"], 210.5, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Razgrad"], 190.3, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Tyrgowishte"], 180.7, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Shumen"], 135.2, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Veliko"], 215.6, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Sliven"], 245.3, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Yambol"], 280.6, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Kazanlyk"], 320.1, 90));
            Cities["Burgas"].Roads.Add(new Road(Cities["Stara Zagora"], 290.7, 90));
            //
            Cities["Silistra"].Roads.Add(new Road(Cities["Varna"], 141, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Burgas"], 210.5, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Dobrich"], 80.2, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Razgrad"], 65.3, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Tyrgowishte"], 110.1, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Shumen"], 45.6, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Veliko"], 180.4, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Sliven"], 205.3, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Yambol"], 240.6, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Kazanlyk"], 330.2, 90));
            Cities["Silistra"].Roads.Add(new Road(Cities["Stara Zagora"], 300.9, 90));
            //
            Cities["Razgrad"].Roads.Add(new Road(Cities["Varna"], 128.2, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Burgas"], 190.3, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Dobrich"], 35.7, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Silistra"], 65.3, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Tyrgowishte"], 45.8, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Shumen"], 40.1, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Veliko"], 100.6, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Sliven"], 125.3, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Yambol"], 160.6, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Kazanlyk"], 250.2, 90));
            Cities["Razgrad"].Roads.Add(new Road(Cities["Stara Zagora"], 220.9, 90));
            //
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Varna"], 121.3, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Burgas"], 180.7, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Dobrich"], 70.9, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Silistra"], 110.1, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Razgrad"], 45.8, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Shumen"], 65.4, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Veliko"], 85.6, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Sliven"], 110.3, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Yambol"], 120.6, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Kazanlyk"], 210.2, 90));
            Cities["Tyrgowishte"].Roads.Add(new Road(Cities["Stara Zagora"], 180.9, 90));
            //
            Cities["Shumen"].Roads.Add(new Road(Cities["Varna"], 88.7, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Burgas"], 135.2, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Dobrich"], 60.3, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Silistra"], 45.6, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Razgrad"], 40.1, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Tyrgowishte"], 65.4, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Veliko"], 50.8, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Sliven"], 75.3, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Yambol"], 110.6, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Kazanlyk"], 200.2, 90));
            Cities["Shumen"].Roads.Add(new Road(Cities["Stara Zagora"], 170.9, 90));
            //
            Cities["Veliko"].Roads.Add(new Road(Cities["Varna"], 115.8, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Burgas"], 215.6, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Dobrich"], 120.8, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Silistra"], 180.4, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Razgrad"], 100.6, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Tyrgowishte"], 85.6, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Shumen"], 50.8, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Sliven"], 120.3, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Yambol"], 155.6, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Kazanlyk"], 245.2, 90));
            Cities["Veliko"].Roads.Add(new Road(Cities["Stara Zagora"], 215.9, 90));
            //         
            Cities["Sliven"].Roads.Add(new Road(Cities["Varna"], 221.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Burgas"], 245.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Dobrich"], 160.2, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Silistra"], 205.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Razgrad"], 125.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Tyrgowishte"], 110.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Shumen"], 75.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Veliko"], 120.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Yambol"], 35.7, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Kazanlyk"], 125.3, 90));
            Cities["Sliven"].Roads.Add(new Road(Cities["Stara Zagora"], 95.9, 90));
            //
            Cities["Yambol"].Roads.Add(new Road(Cities["Varna"], 200.8, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Burgas"], 280.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Dobrich"], 140.5, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Silistra"], 240.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Razgrad"], 160.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Tyrgowishte"], 120.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Shumen"], 110.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Veliko"], 155.6, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Sliven"], 35.7, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Kazanlyk"], 95.3, 90));
            Cities["Yambol"].Roads.Add(new Road(Cities["Stara Zagora"], 65.9, 90));
            //
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Varna"], 297.8, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Burgas"], 320.1, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Dobrich"], 230.1, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Silistra"], 330.2, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Razgrad"], 250.2, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Tyrgowishte"], 210.2, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Shumen"], 200.2, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Veliko"], 245.2, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Sliven"], 125.3, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Yambol"], 95.3, 90));
            Cities["Kazanlyk"].Roads.Add(new Road(Cities["Stara Zagora"], 75.9, 90));
            //
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Varna"], 279.5, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Burgas"], 290.7, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Dobrich"], 220.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Silistra"], 300.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Razgrad"], 220.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Tyrgowishte"], 180.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Shumen"], 170.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Veliko"], 215.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Sliven"], 95.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Yambol"], 65.9, 90));
            Cities["Stara Zagora"].Roads.Add(new Road(Cities["Kazanlyk"], 75.9, 90));
        }
    }
}