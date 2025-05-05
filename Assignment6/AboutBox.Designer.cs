namespace Assignment6
{
    partial class AboutBox
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            
            // 
            // label1 - Title
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(400, 50);
            label1.Text = "ToDo Reminder";
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            
            // 
            // label2 - Version
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 110);
            label2.Name = "label2";
            label2.Size = new Size(400, 30);
            label2.Text = "Version 1.0";
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(220, 220, 220);
            label2.Font = new Font("Segoe UI Light", 16F);
            
            // 
            // label3 - Copyright
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 160);
            label3.Name = "label3";
            label3.Size = new Size(400, 30);
            label3.Text = "© 2025 Manish Raj Moriche";
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(220, 220, 220);
            label3.Font = new Font("Segoe UI Light", 14F);
            
            // 
            // label4 - Description
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 210);
            label4.Name = "label4";
            label4.Size = new Size(400, 60);
            label4.Text = "A beautiful and efficient way to manage\nyour daily tasks and reminders.";
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(200, 200, 200);
            label4.Font = new Font("Segoe UI Light", 14F);
            
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 290);
            pictureBox1.Size = new Size(600, 300);  // Made image bigger
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Assets", "img.png"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 620);  // Adjusted form size to fit bigger image
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About ToDo Reminder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}