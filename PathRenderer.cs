using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finds_the_quickest_path
{
    internal class PathRenderer
    {
        private PictureBox pictureBox;
        private Road_Data roadData;
        private Dictionary<string, Point> cityPoints;
        private string startCityName;
        private string endCityName;
        private List<City> currentPath;


        public PathRenderer(PictureBox pictureBox, Road_Data roadData)
        {
            this.pictureBox = pictureBox;
            this.roadData = roadData;
            this.cityPoints = new Dictionary<string, Point>();
            // Initialize city points mapping
            InitializeCityPoints();
            this.pictureBox.Paint += PictureBox_Paint;
        }
        public void SetSelectedCities(string startCity, string endCity)
        {
            startCityName = startCity;
            endCityName = endCity;
            Refresh(); // Redraw the paths when the selected cities change
        }
        public void SetCurrentPath(List<City> path)
        {
            currentPath = path;
            Refresh(); // Redraw the paths with the new current path
        }


        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawPaths(e.Graphics);
        }
        private void DrawPaths(Graphics graphics)
        {
            // Draw dots for all cities in the current path
            if (currentPath != null)
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    foreach (var city in currentPath)
                    {
                        if (cityPoints.TryGetValue(city.Name, out Point cityPoint))
                        {
                            // Draw circle for each city
                            graphics.FillEllipse(brush, cityPoint.X - 5, cityPoint.Y - 5, 10, 10);
                        }
                    }
                }

                // Draw lines between cities 
                using (Pen pen = new Pen(Color.Blue, 2))
                {
                    for (int i = 0; i < currentPath.Count - 1; i++)
                    {
                        if (cityPoints.TryGetValue(currentPath[i].Name, out Point startPoint) &&
                            cityPoints.TryGetValue(currentPath[i + 1].Name, out Point endPoint))
                        {
                            graphics.DrawLine(pen, startPoint, endPoint);
                        }
                    }
                }
            }

            // different colors for the start and end cities
            if (currentPath != null && currentPath.Count > 0)
            {
                if (cityPoints.TryGetValue(currentPath.First().Name, out Point startCityPoint))
                {
                    DrawCityDot(graphics, startCityPoint, Color.Green); // Start city
                }
                if (cityPoints.TryGetValue(currentPath.Last().Name, out Point endCityPoint))
                {
                    DrawCityDot(graphics, endCityPoint, Color.Red); // End city
                }
            }
        }

        private void DrawCityDot(Graphics graphics, Point cityPoint, Color color)
        {
            using (SolidBrush brush = new SolidBrush(color))
            {
                int dotSize = 10; 
                graphics.FillEllipse(brush, cityPoint.X - dotSize / 2, cityPoint.Y - dotSize / 2, dotSize, dotSize);
            }
        }

        private void InitializeCityPoints()
        {
            // See how much space each city will take up in map
            int spacingX = pictureBox.Width / (roadData.Cities.Count / 2);
            int spacingY = pictureBox.Height / (roadData.Cities.Count / 2);

            // Starting position for first city
            int x = spacingX, y = spacingY;

            // Loop over each city in road data
            foreach (var city in roadData.Cities.Keys)
            {
                // Check if the city is already there
                if (!cityPoints.ContainsKey(city))
                {
                    cityPoints[city] = new Point(x, y);
                    // Move right for the next city
                    x += spacingX;

                    //start a new row
                    if (x > pictureBox.Width - spacingX)
                    {
                        x = spacingX; // Reset to the first column.
                        y += spacingY; // Move down to the next row.
                    }
                }
            }
        }

        public void Refresh()
        {
            pictureBox.Invalidate();
        }
    }
}