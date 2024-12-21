namespace DomowyBudzet
{
    partial class Dashboard
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
            panel1 = new Panel();
            lblLogo = new Label();
            picLogo = new PictureBox();
            Close = new Label();
            panel2 = new Panel();
            button4 = new Button();
            Logout_Button = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(lblLogo);
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(Close);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1268, 60);
            panel1.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(49, 10);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(171, 37);
            lblLogo.TabIndex = 5;
            lblLogo.Text = "SmartBudget";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(13, 13);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(30, 30);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Red;
            Close.BorderStyle = BorderStyle.FixedSingle;
            Close.Cursor = Cursors.Hand;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Close.Location = new Point(1234, 13);
            Close.Name = "Close";
            Close.Size = new Size(21, 22);
            Close.TabIndex = 2;
            Close.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(Logout_Button);
            panel2.Location = new Point(-1, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 589);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumSeaGreen;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9.75F);
            button4.Location = new Point(194, 340);
            button4.Name = "button4";
            button4.Size = new Size(118, 45);
            button4.TabIndex = 2;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.MediumSeaGreen;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Segoe UI", 9.75F);
            Logout_Button.Image = Properties.Resources.Logout;
            Logout_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Logout_Button.Location = new Point(3, 500);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(214, 74);
            Logout_Button.TabIndex = 2;
            Logout_Button.Text = "Wyloguj";
            Logout_Button.UseVisualStyleBackColor = false;
            Logout_Button.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(388, 215);
            button2.Name = "button2";
            button2.Size = new Size(118, 45);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumSeaGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.Location = new Point(388, 298);
            button3.Name = "button3";
            button3.Size = new Size(118, 45);
            button3.TabIndex = 2;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 635);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Close;
        private PictureBox picLogo;
        private Label lblLogo;
        private Panel panel2;
        private Button Logout_Button;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}