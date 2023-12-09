namespace finds_the_quickest_path
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.Start_City = new System.Windows.Forms.Label();
            this.End_City = new System.Windows.Forms.Label();
            this.comboBoxStartCity = new System.Windows.Forms.ComboBox();
            this.comboBoxEndCity = new System.Windows.Forms.ComboBox();
            this.labelTravelTime = new System.Windows.Forms.Label();
            this.listBoxPath = new System.Windows.Forms.ListBox();
            this.pictureBoxMap_Paint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap_Paint)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(159, 528);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(402, 90);
            this.buttonFindPath.TabIndex = 2;
            this.buttonFindPath.Text = "Find Path";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // Start_City
            // 
            this.Start_City.AutoSize = true;
            this.Start_City.Location = new System.Drawing.Point(8, 25);
            this.Start_City.Name = "Start_City";
            this.Start_City.Size = new System.Drawing.Size(101, 20);
            this.Start_City.TabIndex = 3;
            this.Start_City.Text = "Set Off From";
            // 
            // End_City
            // 
            this.End_City.AutoSize = true;
            this.End_City.Location = new System.Drawing.Point(556, 25);
            this.End_City.Name = "End_City";
            this.End_City.Size = new System.Drawing.Size(120, 20);
            this.End_City.TabIndex = 4;
            this.End_City.Text = "Destination City";
            // 
            // comboBoxStartCity
            // 
            this.comboBoxStartCity.FormattingEnabled = true;
            this.comboBoxStartCity.Location = new System.Drawing.Point(12, 61);
            this.comboBoxStartCity.Name = "comboBoxStartCity";
            this.comboBoxStartCity.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStartCity.TabIndex = 5;
            this.comboBoxStartCity.SelectedIndexChanged += new System.EventHandler(this.comboBox_Startcity_SelectedIndexChanged);
            // 
            // comboBoxEndCity
            // 
            this.comboBoxEndCity.FormattingEnabled = true;
            this.comboBoxEndCity.Location = new System.Drawing.Point(560, 61);
            this.comboBoxEndCity.Name = "comboBoxEndCity";
            this.comboBoxEndCity.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEndCity.TabIndex = 6;
            this.comboBoxEndCity.SelectedIndexChanged += new System.EventHandler(this.comboBox_endcity_SelectedIndexChanged);
            // 
            // labelTravelTime
            // 
            this.labelTravelTime.AutoSize = true;
            this.labelTravelTime.Location = new System.Drawing.Point(155, 73);
            this.labelTravelTime.Name = "labelTravelTime";
            this.labelTravelTime.Size = new System.Drawing.Size(97, 20);
            this.labelTravelTime.TabIndex = 8;
            this.labelTravelTime.Text = "Travel Time :";
            // 
            // listBoxPath
            // 
            this.listBoxPath.FormattingEnabled = true;
            this.listBoxPath.ItemHeight = 20;
            this.listBoxPath.Location = new System.Drawing.Point(159, 108);
            this.listBoxPath.Name = "listBoxPath";
            this.listBoxPath.Size = new System.Drawing.Size(402, 204);
            this.listBoxPath.TabIndex = 9;
            // 
            // pictureBoxMap_Paint
            // 
            this.pictureBoxMap_Paint.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxMap_Paint.Location = new System.Drawing.Point(159, 318);
            this.pictureBoxMap_Paint.Name = "pictureBoxMap_Paint";
            this.pictureBoxMap_Paint.Size = new System.Drawing.Size(402, 204);
            this.pictureBoxMap_Paint.TabIndex = 10;
            this.pictureBoxMap_Paint.TabStop = false;
            this.pictureBoxMap_Paint.Click += new System.EventHandler(this.pictureBoxMap_Paint_Click);
            this.pictureBoxMap_Paint.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_grid);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 670);
            this.Controls.Add(this.pictureBoxMap_Paint);
            this.Controls.Add(this.listBoxPath);
            this.Controls.Add(this.labelTravelTime);
            this.Controls.Add(this.comboBoxEndCity);
            this.Controls.Add(this.comboBoxStartCity);
            this.Controls.Add(this.End_City);
            this.Controls.Add(this.Start_City);
            this.Controls.Add(this.buttonFindPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathFinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap_Paint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.Label Start_City;
        private System.Windows.Forms.Label End_City;
        private System.Windows.Forms.ComboBox comboBoxStartCity;
        private System.Windows.Forms.ComboBox comboBoxEndCity;
        private System.Windows.Forms.Label labelTravelTime;
        private System.Windows.Forms.ListBox listBoxPath;
        private System.Windows.Forms.PictureBox pictureBoxMap_Paint;
    }
}

