// Name: Terel Lewis
// Date: 3/26/2023
/* Program Description : GUI application that demonstrates prompting for user info,
                         performing calculations and printing out results */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDisplayData_Click(object sender, EventArgs e)
        {
            // Read numbers of Contestants
            int lastYearContestants = int.Parse(txtLastYrContestants.Text);
            int thisYearContestants = int.Parse(txtThisYrContestants.Text);

            // Calculate revenue expected for this year's competition
            int revenueExpected = thisYearContestants * 25;

            //Display expected revenue
            lblRevenueExpected.Text = $"Revenue expected for this year's competition: {revenueExpected.ToString("C")}";

            // Display Comparison between years
            if (thisYearContestants > lastYearContestants)
            {
                lblComparison.Text = "This year's competition has more contestants than last year's competition";
            }
            else
            {
                lblComparison.Text = "This year's competition does not have more contestants than last year's compeition";
            }
        }
    }
}
