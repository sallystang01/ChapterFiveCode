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

namespace FiveFive_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare a StreamWriter variable
                StreamWriter outputFile;

                // Create a file and get a StreamWriter object.
                outputFile = File.CreateText("Friend.txt");

                // Write the friend's name to the file.
                outputFile.WriteLine(nameTextBox.Text);

                // Close the file.
                outputFile.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
