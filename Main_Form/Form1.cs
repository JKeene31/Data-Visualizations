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
    public partial class Form1 : Form
    {
        Series series1 = new Series();
        public Form1()
        {
            Series series1 = new Series();
            InitializeComponent();
            chart1.Series.Clear();//remove place holder series.
            series1.ChartType = SeriesChartType.Line;
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 15;
            series1.Name = "Burritos per semester week";
            using (StreamReader fileIn = new StreamReader("chart1_data2.txt"))
            {
                string readline;
                while ((readline = fileIn.ReadLine()) != null)
                {
                    //read data from file and add to the series.
                    series1.Points.Add(Convert.ToDouble(readline));
                }
            }
            chart1.Series.Add(series1);//add the series to the chart.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //show portal page on exit of the chart.
            new Portal().Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //show portal page when the return button is clicked.
            new Portal().Show(); this.Hide();
        }
    }
}
