using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class AboutBox : Form
    {
        private bool isDragging = false;
        private Point dragStartPoint;

        public AboutBox()
        {
            InitializeComponent();
            this.Paint += AboutBox_Paint;
            this.MouseDown += AboutBox_MouseDown;
            this.MouseMove += AboutBox_MouseMove;
            this.MouseUp += AboutBox_MouseUp;
            this.KeyPreview = true;
            this.KeyDown += AboutBox_KeyDown;

            // Make all labels clickable to close
            foreach (Control control in Controls)
            {
                if (control is Label || control is PictureBox)
                {
                    control.Cursor = Cursors.Hand;
                    control.Click += (s, e) => this.Close();
                }
            }
        }

        private void AboutBox_Paint(object sender, PaintEventArgs e)
        {
            // Create gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(40, 50, 90),    // Dark blue start
                Color.FromArgb(80, 90, 120),    // Lighter blue end
                45F))                           // 45-degree angle
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Add subtle pattern overlay
            using (HatchBrush hatchBrush = new HatchBrush(
                HatchStyle.LightDownwardDiagonal,
                Color.FromArgb(10, Color.White),
                Color.Transparent))
            {
                e.Graphics.FillRectangle(hatchBrush, this.ClientRectangle);
            }
        }

        private void AboutBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AboutBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void AboutBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point difference = new Point(e.X - dragStartPoint.X, e.Y - dragStartPoint.Y);
                this.Location = new Point(this.Location.X + difference.X, this.Location.Y + difference.Y);
            }
        }

        private void AboutBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
