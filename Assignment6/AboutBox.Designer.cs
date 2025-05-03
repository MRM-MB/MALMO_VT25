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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 60);
            label1.Name = "label1";
            label1.Size = new Size(400, 50);
            label1.TabIndex = 0;
            label1.Text = "The ToDo list";
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 130);
            label2.Name = "label2";
            label2.Size = new Size(400, 30);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0";
            label2.Font = new Font("Segoe UI", 14F);
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 180);
            label3.Name = "label3";
            label3.Size = new Size(400, 30);
            label3.TabIndex = 2;
            label3.Text = "Copyright: Manish Raj Moriche";
            label3.Font = new Font("Segoe UI", 12F);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 230);
            label4.Name = "label4";
            label4.Size = new Size(450, 60);
            label4.TabIndex = 3;
            label4.Text = "A form to keep track of your ToDo list.";
            label4.Font = new Font("Segoe UI", 12F);
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.todo;
            pictureBox1.Location = new Point(80, 320);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 200);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
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
            Text = "AboutBox";
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