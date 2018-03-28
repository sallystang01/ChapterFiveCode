namespace FiveSix_Tutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.getCountriesBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Countries of South America";
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(33, 56);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(218, 121);
            this.countriesListBox.TabIndex = 1;
            // 
            // getCountriesBTN
            // 
            this.getCountriesBTN.Location = new System.Drawing.Point(53, 206);
            this.getCountriesBTN.Name = "getCountriesBTN";
            this.getCountriesBTN.Size = new System.Drawing.Size(75, 44);
            this.getCountriesBTN.TabIndex = 2;
            this.getCountriesBTN.Text = "Get Countries";
            this.getCountriesBTN.UseVisualStyleBackColor = true;
            this.getCountriesBTN.Click += new System.EventHandler(this.getCountriesBTN_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(150, 206);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(75, 44);
            this.exitBTN.TabIndex = 3;
            this.exitBTN.Text = "Exit";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.getCountriesBTN);
            this.Controls.Add(this.countriesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.Button getCountriesBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}

