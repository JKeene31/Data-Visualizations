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
    public partial class Form3 : Form
    {
        Series points1 = new Series();
        Series points2 = new Series();
        
        public Form3()
        {
            InitializeComponent();
            using (StreamReader fileIn = new StreamReader("FirstRatings.txt"))
            {
                string lineread;
                while ((lineread = fileIn.ReadLine()) != null)
                {
                    //reads data from file to add to the first series.
                    points1.Points.Add(Convert.ToDouble(lineread));
                }
                
            }
            using (StreamReader fileIn2 = new StreamReader("FinalRatings.txt"))
            {
                string lineread2;
                while ((lineread2 = fileIn2.ReadLine()) != null)
                {
                    //reads data from the file to add to the second series.
                    points2.Points.Add(Convert.ToDouble(lineread2));
                }

            }
            //setup series info.
            points1.ChartArea = "ChartArea1";
            points1.Legend = "Legend1";
            points1.Name = "First Episode";
            points2.ChartArea = "ChartArea1";
            points2.Legend = "Legend1";
            points2.Name = "Final Episode";
            chart1.Series.Clear();//removes place holder data from form creation.
            chart1.Series.Add(points1);
            chart1.Series.Add(points2);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //returns to the portal page on exit button.
            new Portal().Show(); this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //returns to the portal page when return button is clicked.
            new Portal().Show(); this.Hide();
        }
    }
}
