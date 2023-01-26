
namespace Main_Form
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel3 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel4 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel5 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel6 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel9 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel10 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            customLabel1.FromPosition = 0.5D;
            customLabel1.Text = "Jul";
            customLabel1.ToPosition = 1.5D;
            customLabel2.FromPosition = 1.5D;
            customLabel2.Text = "Aug";
            customLabel2.ToPosition = 2.5D;
            customLabel3.FromPosition = 2.5D;
            customLabel3.Text = "Sep";
            customLabel3.ToPosition = 3.5D;
            customLabel4.FromPosition = 3.5D;
            customLabel4.Text = "Oct";
            customLabel4.ToPosition = 4.5D;
            customLabel5.FromPosition = 4.5D;
            customLabel5.Text = "Nov";
            customLabel5.ToPosition = 5.5D;
            customLabel6.FromPosition = 5.5D;
            customLabel6.Text = "Dec";
            customLabel6.ToPosition = 6.5D;
            customLabel7.FromPosition = 6.5D;
            customLabel7.Text = "Jan";
            customLabel7.ToPosition = 7.5D;
            customLabel8.FromPosition = 7.5D;
            customLabel8.Text = "Feb";
            customLabel8.ToPosition = 8.5D;
            customLabel9.FromPosition = 8.5D;
            customLabel9.Text = "Mar";
            customLabel9.ToPosition = 9.5D;
            customLabel10.FromPosition = 9.5D;
            customLabel10.Text = "Apr";
            customLabel10.ToPosition = 10.5D;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.AxisX.CustomLabels.Add(customLabel3);
            chartArea1.AxisX.CustomLabels.Add(customLabel4);
            chartArea1.AxisX.CustomLabels.Add(customLabel5);
            chartArea1.AxisX.CustomLabels.Add(customLabel6);
            chartArea1.AxisX.CustomLabels.Add(customLabel7);
            chartArea1.AxisX.CustomLabels.Add(customLabel8);
            chartArea1.AxisX.CustomLabels.Add(customLabel9);
            chartArea1.AxisX.CustomLabels.Add(customLabel10);
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "GME Stock Price";
            series1.XValueMember = "Month";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(801, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "GME Stock Price Per Month";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title2";
            title2.Text = "Price of Stock (USD)";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Title3";
            title3.Text = "Month";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}