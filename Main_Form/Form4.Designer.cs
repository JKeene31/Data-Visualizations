
namespace Main_Form
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel13 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel14 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel15 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel16 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel17 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel18 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel19 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel20 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel21 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel22 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel23 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel24 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            customLabel13.ForeColor = System.Drawing.Color.Black;
            customLabel13.FromPosition = 0.5D;
            customLabel13.MarkColor = System.Drawing.Color.Black;
            customLabel13.Text = "Jan";
            customLabel13.ToPosition = 1.5D;
            customLabel14.FromPosition = 1.5D;
            customLabel14.Text = "Feb";
            customLabel14.ToPosition = 2.5D;
            customLabel15.FromPosition = 2.5D;
            customLabel15.Text = "Mar";
            customLabel15.ToPosition = 3.5D;
            customLabel16.FromPosition = 3.5D;
            customLabel16.Text = "Apr";
            customLabel16.ToPosition = 4.5D;
            customLabel17.FromPosition = 4.5D;
            customLabel17.Text = "May";
            customLabel17.ToPosition = 5.5D;
            customLabel18.FromPosition = 5.5D;
            customLabel18.Text = "Jun";
            customLabel18.ToPosition = 6.5D;
            customLabel19.FromPosition = 6.5D;
            customLabel19.Text = "Jul";
            customLabel19.ToPosition = 7.5D;
            customLabel20.FromPosition = 7.5D;
            customLabel20.Text = "Aug";
            customLabel20.ToPosition = 8.5D;
            customLabel21.FromPosition = 8.5D;
            customLabel21.Text = "Sept";
            customLabel21.ToPosition = 9.5D;
            customLabel22.FromPosition = 9.5D;
            customLabel22.Text = "Oct";
            customLabel22.ToPosition = 10.5D;
            customLabel23.FromPosition = 10.5D;
            customLabel23.Text = "Nov";
            customLabel23.ToPosition = 11.5D;
            customLabel24.FromPosition = 11.5D;
            customLabel24.Text = "Dec";
            customLabel24.ToPosition = 12.5D;
            chartArea2.AxisX.CustomLabels.Add(customLabel13);
            chartArea2.AxisX.CustomLabels.Add(customLabel14);
            chartArea2.AxisX.CustomLabels.Add(customLabel15);
            chartArea2.AxisX.CustomLabels.Add(customLabel16);
            chartArea2.AxisX.CustomLabels.Add(customLabel17);
            chartArea2.AxisX.CustomLabels.Add(customLabel18);
            chartArea2.AxisX.CustomLabels.Add(customLabel19);
            chartArea2.AxisX.CustomLabels.Add(customLabel20);
            chartArea2.AxisX.CustomLabels.Add(customLabel21);
            chartArea2.AxisX.CustomLabels.Add(customLabel22);
            chartArea2.AxisX.CustomLabels.Add(customLabel23);
            chartArea2.AxisX.CustomLabels.Add(customLabel24);
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffset = 1D;
            chartArea2.AxisX.Title = "Month";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Title = "Degrees F / % Humidity";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, -1);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(803, 451);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Average Weather in DeKalb, IL by Month";
            this.chart1.Titles.Add(title2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form4";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

