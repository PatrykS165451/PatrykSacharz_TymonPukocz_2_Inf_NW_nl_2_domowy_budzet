namespace DomowyBudzet
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
            panel1 = new Panel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            Close = new Label();
            label3 = new Label();
            login_UserName = new TextBox();
            login_Password = new TextBox();
            label4 = new Label();
            label5 = new Label();
            login_Button = new Button();
            login_SignUp = new Button();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(lblLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 450);
            panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(38, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 100);
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(3, 115);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(171, 37);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "SmartBudget";
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Red;
            Close.BorderStyle = BorderStyle.FixedSingle;
            Close.Cursor = Cursors.Hand;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Close.Location = new Point(769, 9);
            Close.Name = "Close";
            Close.Size = new Size(21, 22);
            Close.TabIndex = 1;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(253, 80);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "Witamy";
            // 
            // login_UserName
            // 
            login_UserName.Location = new Point(253, 144);
            login_UserName.Name = "login_UserName";
            login_UserName.Size = new Size(317, 23);
            login_UserName.TabIndex = 3;
            // 
            // login_Password
            // 
            login_Password.Location = new Point(253, 213);
            login_Password.Name = "login_Password";
            login_Password.PasswordChar = '*';
            login_Password.Size = new Size(317, 23);
            login_Password.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 126);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 5;
            label4.Text = "Nazwa użytkownika";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 195);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 6;
            label5.Text = "Hasło";
            // 
            // login_Button
            // 
            login_Button.BackColor = SystemColors.ButtonFace;
            login_Button.Location = new Point(253, 267);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(322, 40);
            login_Button.TabIndex = 7;
            login_Button.Text = "Logowanie";
            login_Button.UseVisualStyleBackColor = false;
            login_Button.Click += login_Button_Click;
            // 
            // login_SignUp
            // 
            login_SignUp.BackColor = SystemColors.ButtonFace;
            login_SignUp.Location = new Point(253, 321);
            login_SignUp.Name = "login_SignUp";
            login_SignUp.Size = new Size(322, 40);
            login_SignUp.TabIndex = 8;
            login_SignUp.Text = "Rejestracja";
            login_SignUp.UseVisualStyleBackColor = false;
            login_SignUp.Click += login_SignUp_Click;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Location = new Point(487, 242);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(88, 19);
            login_showPass.TabIndex = 9;
            login_showPass.Text = "Pokaż hasło";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(login_showPass);
            Controls.Add(login_SignUp);
            Controls.Add(login_Button);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(login_Password);
            Controls.Add(login_UserName);
            Controls.Add(label3);
            Controls.Add(Close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Close;
        private Label lblLogo;
        private PictureBox picLogo;
        private Label label3;
        private TextBox login_UserName;
        private TextBox login_Password;
        private Label label4;
        private Label label5;
        private Button login_Button;
        private Button login_SignUp;
        private CheckBox login_showPass;
    }
}
