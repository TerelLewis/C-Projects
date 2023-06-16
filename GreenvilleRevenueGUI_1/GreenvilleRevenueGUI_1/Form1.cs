// Name: Terel Lewis
// Date: 3/16/2023
/* Program Description : GUI Application that demonstrates prompting for user info,
                         performing calculations and printing out results */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplayData_Click(object sender, EventArgs e)
        {
            // Read numbers of contestants
            int lastYearContestants = int.Parse(txtLastYrContestants.Text);
            int thisYearContestants = int.Parse(txtThisYrContestants.Text);

            // Calculate revenue expected for this year's competition
            int revenueExpected = thisYearContestants * 25;

            // Display expected revenue
            lblRevenueExpected.Text = $"Revenue expected for this year's competition: {revenueExpected.ToString("C")}";

            
            // Determine if this year's compeition has more contestants than last year 
            if (thisYearContestants > 2 * lastYearContestants)
            {
                lblComparison.Text = "The competition is more than twice as big this year!";
            }
            else
            {
                lblComparison.Text = "The competition is bigger than ever!";
            }
            if (thisYearContestants < lastYearContestants) 
            {
                lblComparison.Text = "A tighter race this year! Come out and cast your vote!";
            }






        }
    }
}
