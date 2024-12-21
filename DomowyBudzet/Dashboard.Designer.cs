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
            Logout_Button = new Button();
            Category_Button = new Button();
            Dashboard_Button = new Button();
            Expense_Button = new Button();
            Income_Button = new Button();
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
            Close.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Close.Location = new Point(1226, 13);
            Close.Name = "Close";
            Close.Size = new Size(29, 32);
            Close.TabIndex = 2;
            Close.Text = "X";
            Close.Click += Close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(Logout_Button);
            panel2.Controls.Add(Category_Button);
            panel2.Controls.Add(Dashboard_Button);
            panel2.Controls.Add(Expense_Button);
            panel2.Controls.Add(Income_Button);
            panel2.Location = new Point(-1, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 589);
            panel2.TabIndex = 1;
            // 
            // Logout_Button
            // 
            Logout_Button.BackColor = Color.MediumSeaGreen;
            Logout_Button.FlatAppearance.BorderSize = 0;
            Logout_Button.FlatAppearance.MouseOverBackColor = Color.Red;
            Logout_Button.FlatStyle = FlatStyle.Flat;
            Logout_Button.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
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
            // Category_Button
            // 
            Category_Button.BackColor = Color.MediumSeaGreen;
            Category_Button.FlatAppearance.BorderSize = 0;
            Category_Button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Category_Button.FlatStyle = FlatStyle.Flat;
            Category_Button.Font = new Font("Segoe UI", 9.75F);
            Category_Button.Image = Properties.Resources.Plus;
            Category_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Category_Button.Location = new Point(13, 156);
            Category_Button.Name = "Category_Button";
            Category_Button.Size = new Size(191, 68);
            Category_Button.TabIndex = 2;
            Category_Button.Text = "Dodaj kategorię";
            Category_Button.TextAlign = ContentAlignment.MiddleRight;
            Category_Button.UseVisualStyleBackColor = false;
            Category_Button.Click += button1_Click;
            // 
            // Dashboard_Button
            // 
            Dashboard_Button.BackColor = Color.MediumSeaGreen;
            Dashboard_Button.FlatAppearance.BorderSize = 0;
            Dashboard_Button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Dashboard_Button.FlatStyle = FlatStyle.Flat;
            Dashboard_Button.Font = new Font("Segoe UI", 9.75F);
            Dashboard_Button.Image = Properties.Resources.Summary;
            Dashboard_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard_Button.Location = new Point(13, 78);
            Dashboard_Button.Name = "Dashboard_Button";
            Dashboard_Button.Size = new Size(191, 68);
            Dashboard_Button.TabIndex = 2;
            Dashboard_Button.Text = "Podsumowanie";
            Dashboard_Button.TextAlign = ContentAlignment.MiddleRight;
            Dashboard_Button.UseVisualStyleBackColor = false;
            Dashboard_Button.Click += button1_Click;
            // 
            // Expense_Button
            // 
            Expense_Button.BackColor = Color.MediumSeaGreen;
            Expense_Button.FlatAppearance.BorderSize = 0;
            Expense_Button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Expense_Button.FlatStyle = FlatStyle.Flat;
            Expense_Button.Font = new Font("Segoe UI", 9.75F);
            Expense_Button.Image = Properties.Resources.expense;
            Expense_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Expense_Button.Location = new Point(13, 289);
            Expense_Button.Name = "Expense_Button";
            Expense_Button.Size = new Size(191, 68);
            Expense_Button.TabIndex = 2;
            Expense_Button.Text = "Wydatki";
            Expense_Button.TextAlign = ContentAlignment.MiddleRight;
            Expense_Button.UseVisualStyleBackColor = false;
            Expense_Button.Click += button1_Click;
            // 
            // Income_Button
            // 
            Income_Button.BackColor = Color.MediumSeaGreen;
            Income_Button.FlatAppearance.BorderSize = 0;
            Income_Button.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            Income_Button.FlatStyle = FlatStyle.Flat;
            Income_Button.Font = new Font("Segoe UI", 9.75F);
            Income_Button.Image = Properties.Resources.income;
            Income_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Income_Button.Location = new Point(13, 224);
            Income_Button.Name = "Income_Button";
            Income_Button.Size = new Size(191, 68);
            Income_Button.TabIndex = 2;
            Income_Button.Text = "Przychody";
            Income_Button.TextAlign = ContentAlignment.MiddleRight;
            Income_Button.UseVisualStyleBackColor = false;
            Income_Button.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 635);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Button Income_Button;
        private Button Dashboard_Button;
        private Button Category_Button;
        private Button Expense_Button;
    }
}