using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapterFiveCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            //Local Variables
            decimal balance; // The account balance
            int months; // The number of months
            int count = 1; //Loop counter, initialized with 1

            //Get the starting balance.
            if (int.TryParse(monthsTextBox.Text, out months))
            {
                //The following loop calculates the ending balance
            }
        }
    }
}
