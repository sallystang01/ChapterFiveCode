using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FiveSix_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a country name.
                string countryName;

                // Delcare a StreamReader variable.
                StreamReader inputFile;

                // Open the file and get a StreamReader object.

                inputFile = File.OpenText("Countries.txt");

                //Clear anything currently in the listbox.
                countriesListBox.Items.Clear();

                //Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //Get a country name.
                    countryName = inputFile.ReadLine();

                    // Add the country name to the Listbox.
                    countriesListBox.Items.Add(countryName);
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
