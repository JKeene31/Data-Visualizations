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
    public partial class Form2 : Form
    {
        Series series1 = new Series();
        public Form2()
        {
            InitializeComponent();
            chart1.Series.Clear();//remove place holder series.
            series1.ChartType = SeriesChartType.Area;
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 10;
            series1.Name = "GME Stock Price";

            using (StreamReader fileIn = new StreamReader("chart2_data2.txt"))
            {
                string readline;
                while ((readline = fileIn.ReadLine()) != null)
                {
                    //read data from file and add to the series.
                    series1.Points.Add(Convert.ToDouble(readline));
                }
            }
            //add series to the chart.
            chart1.Series.Add(series1);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //return to the portal page on exit.
            new Portal().Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to the portal page when return button is clicked.
            new Portal().Show(); this.Hide();
        }
    }
}
