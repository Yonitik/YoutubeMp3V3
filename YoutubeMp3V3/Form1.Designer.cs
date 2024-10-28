namespace YoutubeMp3V3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            SuspendLayout();
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.RoyalBlue;
            rjButton1.BackgroundColor = Color.RoyalBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(80, 51);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Download Mp3";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.RoyalBlue;
            rjButton2.BackgroundColor = Color.RoyalBlue;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(266, 51);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 40);
            rjButton2.TabIndex = 4;
            rjButton2.Text = "Download Mp4";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.RoyalBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(13, 13);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(470, 34);
            rjTextBox1.TabIndex = 5;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(494, 105);
            Controls.Add(rjTextBox1);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Name = "Form1";
            Text = "YoutubeMp3V3";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
    }
}
