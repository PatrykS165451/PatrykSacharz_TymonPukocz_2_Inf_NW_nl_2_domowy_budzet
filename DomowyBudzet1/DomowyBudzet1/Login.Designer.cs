namespace DomowyBudzet1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            UsernameTb = new TextBox();
            label1 = new Label();
            PasswordTb = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            SignupBtn = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 531);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 281);
            label7.Name = "label7";
            label7.Size = new Size(200, 40);
            label7.TabIndex = 5;
            label7.Text = "SmartBudget";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(38, 147);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(133, 131);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(300, 147);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(524, 23);
            UsernameTb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 129);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 2;
            label1.Text = "Nazwa użytkownika";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(300, 247);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(524, 23);
            PasswordTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 229);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Hasło";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(360, 405);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(148, 88);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Logowanie";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignupBtn
            // 
            SignupBtn.Location = new Point(588, 405);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(148, 88);
            SignupBtn.TabIndex = 4;
            SignupBtn.Text = "Rejestracja";
            SignupBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(849, 9);
            label3.Name = "label3";
            label3.Size = new Size(36, 40);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 531);
            Controls.Add(label3);
            Controls.Add(SignupBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(label1);
            Controls.Add(UsernameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UsernameTb;
        private PictureBox pictureBox7;
        private Label label1;
        private TextBox PasswordTb;
        private Label label2;
        private Button LoginBtn;
        private Button SignupBtn;
        private Label label7;
        private Label label3;
    }
}