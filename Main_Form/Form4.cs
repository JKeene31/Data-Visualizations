/************************************************************************************
Assignment 6: Uncharted
Jacob Keene Z1651665
Parker Psaltis Z1771638
Date due: 4/15/21
Purpose: Portal form and charts assignment
*************************************************************************************/
using System;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Form4 : Form
    {
        Series series1 = new Series();
        Series series2 = new Series();
        Series series3 = new Series();
        public Form4()
        {
            InitializeComponent();
            //set up all series for use with the chart.
            chart1.Series.Clear();//removes the place holder series in the chart from form setup.
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Average High Temp";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Average Low Temp";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Average Humidity";
            using (StreamReader fileIn = new StreamReader("High.txt"))//opens file for first series of data points.
            {
                string lineread;
                while ((lineread = fileIn.ReadLine()) != null)
                {
                    //reads all data points from file and adds to the first series.
                    series1.Points.Add(Convert.ToDouble(lineread));
                }
            }
            using (StreamReader fileIn = new StreamReader("Low.txt"))
            {
                string lineread;
                while ((lineread = fileIn.ReadLine()) != null)
                {
                    //reads all data points from file and adds to the second series.
                    series2.Points.Add(Convert.ToDouble(lineread));
                }
            }
            using (StreamReader fileIn = new StreamReader("Humidity.txt"))
            {
                string lineread;
                while ((lineread = fileIn.ReadLine()) != null)
                {
                    //reads all data points from file and adds to the third series.
                    series3.Points.Add(Convert.ToDouble(lineread));
                }
            }

            //add the 3 series to the chart.
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            //when the chart is closed through the x button, return to the portal form.
            new Portal().Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return button sends user back to the portal form.
            new Portal().Show(); this.Hide();
        }
    }
}
