namespace DomowyBudzet
{
    partial class SignupForm
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
            picLogo = new PictureBox();
            lblLogo = new Label();
            signup_showPass = new CheckBox();
            signup_Btn = new Button();
            label5 = new Label();
            label4 = new Label();
            signup_Password = new TextBox();
            signup_UserName = new TextBox();
            label3 = new Label();
            signup_Close = new Label();
            label1 = new Label();
            signup_PassConfirm = new TextBox();
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
            panel1.TabIndex = 10;
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
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Location = new Point(487, 242);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(88, 19);
            signup_showPass.TabIndex = 19;
            signup_showPass.Text = "Pokaż hasło";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_Btn
            // 
            signup_Btn.BackColor = SystemColors.ButtonFace;
            signup_Btn.Location = new Point(253, 321);
            signup_Btn.Name = "signup_Btn";
            signup_Btn.Size = new Size(322, 40);
            signup_Btn.TabIndex = 18;
            signup_Btn.Text = "Rejestracja";
            signup_Btn.UseVisualStyleBackColor = false;
            signup_Btn.Click += signup_Btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 195);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 16;
            label5.Text = "Hasło";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 126);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 15;
            label4.Text = "Nazwa użytkownika";
            // 
            // signup_Password
            // 
            signup_Password.Location = new Point(253, 213);
            signup_Password.Name = "signup_Password";
            signup_Password.PasswordChar = '*';
            signup_Password.Size = new Size(317, 23);
            signup_Password.TabIndex = 14;
            // 
            // signup_UserName
            // 
            signup_UserName.Location = new Point(253, 144);
            signup_UserName.Name = "signup_UserName";
            signup_UserName.Size = new Size(317, 23);
            signup_UserName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(253, 80);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 12;
            label3.Text = "Załóż konto";
            // 
            // signup_Close
            // 
            signup_Close.AutoSize = true;
            signup_Close.BackColor = Color.Red;
            signup_Close.BorderStyle = BorderStyle.FixedSingle;
            signup_Close.Cursor = Cursors.Hand;
            signup_Close.FlatStyle = FlatStyle.Flat;
            signup_Close.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            signup_Close.Location = new Point(726, 9);
            signup_Close.Name = "signup_Close";
            signup_Close.Size = new Size(62, 22);
            signup_Close.TabIndex = 11;
            signup_Close.Text = "Powrót";
            signup_Close.Click += signup_Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 261);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 21;
            label1.Text = "Powtórz hasło";
            // 
            // signup_PassConfirm
            // 
            signup_PassConfirm.Location = new Point(253, 279);
            signup_PassConfirm.Name = "signup_PassConfirm";
            signup_PassConfirm.PasswordChar = '*';
            signup_PassConfirm.ShortcutsEnabled = false;
            signup_PassConfirm.Size = new Size(317, 23);
            signup_PassConfirm.TabIndex = 20;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(signup_PassConfirm);
            Controls.Add(panel1);
            Controls.Add(signup_showPass);
            Controls.Add(signup_Btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(signup_Password);
            Controls.Add(signup_UserName);
            Controls.Add(label3);
            Controls.Add(signup_Close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picLogo;
        private Label lblLogo;
        private CheckBox signup_showPass;
        private Button signup_Btn;
        private Label label5;
        private Label label4;
        private TextBox signup_Password;
        private TextBox signup_UserName;
        private Label label3;
        private Label signup_Close;
        private Label label1;
        private TextBox signup_PassConfirm;
    }
}