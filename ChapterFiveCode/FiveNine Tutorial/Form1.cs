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

namespace FiveNine_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {  // Declare a virable to hold a country name.
                string countryName;

                // Declare a streamreader variable.
                StreamReader inputFile;

                // Open the file and get a streamreader object.
                inputFile = File.OpenText("Countries.txt");

                // Read the file's contents.
                while (!inputFile.EndOfStream)
                {
                    // Get a country name.
                    countryName = inputFile.ReadLine();

                    // Add the country name to the listbox.
                    countriesListBox.Items.Add(countryName);
                }
                // Closes the file
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Displays error
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
