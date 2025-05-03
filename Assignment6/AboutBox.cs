using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            StyleForm();
        }

        private void StyleForm()
        {
            this.BackColor = Color.FromArgb(245, 245, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Style title
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(60, 60, 150);

            // Style version
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(60, 60, 60);

            // Style copyright
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(80, 80, 80);

            // Style description
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(80, 80, 80);

            // Add a border to the picture box
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
