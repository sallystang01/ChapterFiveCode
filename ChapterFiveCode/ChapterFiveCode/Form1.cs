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
            try
            {
                //Constant for the monthly interest rate.
                const decimal INTEREST_RATE = 0.005m;

                //Local Variables
                decimal balance; // The account balance
                int months; // The number of months
                int count = 1; //Loop counter, initialized with 1
                               // Get the starting balance
                if (decimal.TryParse(startingBalTextBox.Text, out balance))
                {


                    //Get the number of months
                    if (int.TryParse(monthsTextBox.Text, out months))
                    {
                        //The following loop calculates the ending balance
                        while (count <= months)
                        {
                            // Add this month's interest to the balance.
                            balance = balance + (INTEREST_RATE * balance);
                            // Add one to the loop counter.
                            count = count + 1;
                        }
                        //Display the ending balance.
                        endingBalanceLabel.Text = balance.ToString("c");

                    }
                    else
                    {
                        //Invalid number of months was entered.
                        MessageBox.Show("Invalid value for months.");
                    }
                }
                else
                {
                    // Invalid starting balance was entered.
                    MessageBox.Show("Invalid value for starting balance");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Shows Excetion

            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Text = null; // Clears all text fields
            monthsTextBox.Text = null;
            endingBalanceLabel.Text = null;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes form
        }
    }
}
