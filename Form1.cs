using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finds_the_quickest_path
{
    public partial class Form1 : Form
    {
        private Road_Data roadData;
        private PathFinder pathFinder;
        private PathRenderer pathRenderer;

        public Form1()
        {
            InitializeComponent();
            ShowTipsPopup();
            roadData = new Road_Data();
            pathFinder = new PathFinder();
            pathRenderer = new PathRenderer(pictureBoxMap_Paint, roadData);

        }

        private void comboBox_Startcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_endcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            string startCity = comboBoxStartCity.SelectedItem.ToString();
            string endCity = comboBoxEndCity.SelectedItem.ToString();

            var path = pathFinder.FindShortestPath(roadData, startCity, endCity);
            var travelTime = pathFinder.CalculateTravelTime(path);

            listBoxPath.Items.Clear();
            for (int i = 0; i < path.Count - 1; i++)
            {
                var currentCity = path[i];
                var nextCity = path[i + 1];
                var road = currentCity.Roads.FirstOrDefault(r => r.Destination == nextCity);
                if (road != null)
                {
                    listBoxPath.Items.Add($"{currentCity.Name} to {nextCity.Name} - {road.Distance} km at {road.MaxSpeed} km/h");
                }
            }
        
            labelTravelTime.Text = $"Total Travel Time: {travelTime} ";

            pathRenderer.SetSelectedCities(startCity, endCity);
            pathRenderer.SetCurrentPath(path);
            pathRenderer.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var roadData = new Road_Data();


            foreach (var city in roadData.Cities.Values)
            {
                comboBoxStartCity.Items.Add(city.Name);
                comboBoxEndCity.Items.Add(city.Name);
            }

            if (comboBoxStartCity.Items.Count > 0)
            {
                comboBoxStartCity.SelectedIndex = 0;
            }

            if (comboBoxEndCity.Items.Count > 0)
            {
                comboBoxEndCity.SelectedIndex = 0;
            }
        }
        private void ShowTipsPopup()
        {
            string tipsMessage = "Green = Start City.\n\n"
                               + "Red = End City.\n\n"
                               + "Black = Stopover city.";

            string tipsTitle = "Map Tips";

            MessageBox.Show(tipsMessage, tipsTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Paint_grid(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMap_Paint_Click(object sender, EventArgs e)
        {
            ShowTipsPopup();
        }
    }
}

