/************************************************************************************
Assignment 6: Uncharted
Jacob Keene Z1651665
Parker Psaltis Z1771638
Date due: 4/15/21
Purpose: Portal form and charts assignment
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }
        //load chart 1
        private void chart1_button_Click(object sender, EventArgs e)
        {
            //open form 1 and hide the portal form.
            new Form1().Show(); this.Hide();
        }
        //exit buitton
        private void Exit_button_Click(object sender, EventArgs e)
        {
            //Exit the application when the exit button is clicked.
            Process.GetCurrentProcess().Kill();
        }

        private void chart2_button_Click(object sender, EventArgs e)
        {
            //open form 2 and hide the portal form.
            new Form2().Show(); this.Hide();
        }

        private void chart3_button_Click(object sender, EventArgs e)
        {
            //open form 3 and hide the portal form.
            new Form3().Show(); this.Hide();
        }

        private void chart4_button_Click(object sender, EventArgs e)
        {
            //open form 4 and hide the portal form.
            new Form4().Show(); this.Hide();
        }

        private void Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ensure the program is terminated when closing the form through the corner x button.
            Process.GetCurrentProcess().Kill();
        }
    }
}
